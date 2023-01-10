using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Canny_Edge_Detector
{
    /// <summary>
    /// Class containing canny edge detection alogrithm
    /// 
    /// Author: Hieronim Daniel
    /// Date: 2023
    /// Date: 2023
    /// </summary>
    class Canny
    {

        // 3x3 Filter apply MASM64 DLL import
        [DllImport(@"C:\Users\hieronim\Documents\GitHub\Canny-Edge-Detector\x64\Release\JAAsm.dll")]
        static extern void Calculate3x3(IntPtr array1, IntPtr filter, IntPtr resArray, int size);

        // // 3x3 Filter apply C++ DLL import
        [DllImport(@"C:\Users\hieronim\Documents\GitHub\Canny-Edge-Detector\x64\Release\JACpp.dll")]
        static extern void Calculate3x3Cpp(IntPtr array1, IntPtr filter, IntPtr resArray, int size);

        // Gaussian filter MASM64 DLL import
        [DllImport(@"C:\Users\hieronim\Documents\GitHub\Canny-Edge-Detector\x64\Release\JAAsm.dll")]
        static extern void Gaussian(IntPtr array1, IntPtr filter, IntPtr resArray, int size, int weight);

        // Variable wchich value decides if the assembly code is used
        private readonly bool useAsseblyCode;
        // Variable wchich value decides if the threshold values are automaticly calculated
        private readonly bool useAutoThresholdValues;

        // DateTimes used for method speed calculation
        public DateTime dateTime1;
        public DateTime dateTime2;
        public DateTime dateTime3;
        public DateTime dateTime4;
        public DateTime dateTime5;
        public DateTime dateTime6;
        public DateTime dateTime7;
        public DateTime dateTime8;

        // Input image as Bitmap
        private readonly Bitmap inputImage;

        // Height of the image
        private readonly int Height;
        // Width of the image
        private readonly int Width;

        //High and low value used for double thresholding
        private float highThreshold;
        private float lowThreshold;

        // Number of threads used in calculations
        private readonly ParallelOptions numberOfThreads;
        // List of actions used for multithreding purposes
        private readonly List<Action> listOfActions;
        
        // Averaged Image from Bitmap in gray shades
        private int[,] greyImage = null!;
        // Image after Gaussian filter
        private int[,] gaussianFilteredImage = null!;
        // Derivative X of the image
        private int[,] derivativeX = null!;
        // Derivative Y of the image
        private int[,] derivativeY = null!;
        // Strong edges of image after double thresholding
        private int[,] strongEdges = null!;
        // Weak edges of image after double thresholding
        private int[,] weakEdges = null!;
        // Array containing values of the edges: 0 for no edge, 1 for strong edge, 2 for weak edge
        // used for edge tracking by hysteresis 
        private int[,] edgePoints = null!;
        // Final edge map
        private int[,] edgeMap = null!;

        // Array containg gradient of the image counted from X and Y derivatives
        private float[,] gradient = null!;
        // Non-Maximum suppressed image
        private float[,] nonMax = null!;

        // Array tracking if pixel is visited by hysterysis recurrent algorithm
        private bool[,] ifVisited;

        // Gaussian Kernel Data (n = 5, sigma = 1)
        private readonly int[,] gaussianKernel =
        {
            {1,4,7,4,1},
            {4,16,26,16,4},
            {7,26,41,26,7},
            {4,16,26,16,4},
            {1,4,7,4,1}
        };

        // Gaussian Kernel Used in Asm DLL (n = 5, sigma = 1)
        private readonly short[] modifiedGaussianKernel =
        {
            1, 4, 7, 4, 1, 0, 0, 0,
            4, 16, 26, 16, 4, 0, 0, 0,
            7, 26, 41, 26, 7, 0, 0, 0,
            4, 16, 26, 16, 4, 0, 0, 0,
            1, 4, 7, 4, 1, 0, 0, 0
        };

        // Weight of the gaussian kernel (n = 5, sigma = 1)
        private readonly int kernelWeight = 271;
        // Size of Gaussian Kernel
        private readonly int kernelSize = 5;

        //Filter used to calculate derivative X of the image, normalised for Asm DLL
        private readonly int[] modifiedDx = { 1, 0, -1, 0, 2, 0, -2, 0, 1, 0, -1, 0 };
        //Filter used to calculate derivative Y of the image, normalised for Asm DLL
        private readonly int[] modifiedDy = { 1, 2, 1, 0, 0, 0, 0, 0, -1, -2, -1, 0 };

        //Getters used for image visualization
        public int[,] GaussianFilteredImage { get => gaussianFilteredImage; }
        public int[,] EdgeMap { get => edgeMap; }
        public float[,] Gradient { get => gradient; }
        public float[,] NonMax { get => nonMax; }
        public int[,] StrongEdges { get => strongEdges; }
        public int[,] WeakEdges { get => weakEdges; }

        /// <summary>
        /// Constructor of the canny class
        /// </summary>
        /// <param name="inputImage"></param> Bitmap of image to filter
        /// <param name="hT"></param> High threshold
        /// <param name="lT"></param> Low threshold
        /// <param name="threads"></param> Number of threads used in calculations
        /// <param name="useAsseblyCode"></param> If true uses Asm DLL
        public Canny(Bitmap inputImage, float hT, float lT, int threads, bool useAsseblyCode, bool autoThresholdValues)
        {
            highThreshold = hT;
            lowThreshold = lT;
            listOfActions = new List<Action>();
            numberOfThreads = new ParallelOptions { MaxDegreeOfParallelism = threads };
            this.inputImage = inputImage;
            Height = this.inputImage.Height;
            Width = this.inputImage.Width;
            this.useAsseblyCode = useAsseblyCode;
            this.useAutoThresholdValues = autoThresholdValues;
            ifVisited = new bool[Height, Width];

            ConvertBitmapToGreyImage();
            DetectCannyEdges();
            return;
        }

        /// <summary>
        /// Converts Bimap into int values as grey image
        /// </summary>
        private void ConvertBitmapToGreyImage()
        {
            int i, j;
            greyImage = new int[inputImage.Height, inputImage.Width];
            Bitmap image = inputImage;
            BitmapData bitmapData1 = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            unsafe
            {
                byte* imagePointer1 = (byte*)bitmapData1.Scan0;
                for (i = 0; i < bitmapData1.Height; i++)
                {
                    for (j = 0; j < bitmapData1.Width; j++)
                    {
                        greyImage[i, j] = (int)((imagePointer1[0] + imagePointer1[1] + imagePointer1[2]) / 3.0);
                        imagePointer1 += 4;
                    }
                    imagePointer1 += bitmapData1.Stride - (bitmapData1.Width * 4);
                }
            }
            image.UnlockBits(bitmapData1);
            return;
        }

        /// <summary>
        /// Return image as a Bitmap from grey image
        /// </summary>
        /// <param name="GreyImage"></param> Grey image containing floats values
        /// <returns></returns> Bitmap of the input grey image
        public Bitmap ConvertGreyImageToBitmap(float[,] GreyImage)
        {
            int i;
            int j;
            int W;
            int H;
            H = GreyImage.GetLength(0);
            W = GreyImage.GetLength(1);

            Bitmap image = new(W, H);
            BitmapData bitmapData1 = image.LockBits(new Rectangle(0, 0, W, H), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            unsafe
            {
                byte* imagePointer1 = (byte*)bitmapData1.Scan0;
                for (i = 0; i < bitmapData1.Height; i++)
                {
                    for (j = 0; j < bitmapData1.Width; j++)
                    {
                        imagePointer1[0] = (byte)((int)(GreyImage[i, j]));
                        imagePointer1[1] = (byte)((int)(GreyImage[i, j]));
                        imagePointer1[2] = (byte)((int)(GreyImage[i, j]));
                        imagePointer1[3] = (byte)255;
                        imagePointer1 += 4;
                    }
                    imagePointer1 += (bitmapData1.Stride - (bitmapData1.Width * 4));
                }
            }
            image.UnlockBits(bitmapData1);
            return image;
        }

        /// <summary>
        /// Return image as a Bitmap from grey image
        /// </summary>
        /// <param name="GreyImage"></param> Grey image containing int values
        /// <returns></returns> Bitmap of the input grey image
        public Bitmap DisplayImage(int[,] GreyImage)
        {
            int i, j;
            int W, H;
            H = GreyImage.GetLength(0);
            W = GreyImage.GetLength(1);
            Bitmap image = new(W, H);
            BitmapData bitmapData1 = image.LockBits(new Rectangle(0, 0, W, H), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            unsafe
            {
                byte* imagePointer1 = (byte*)bitmapData1.Scan0;
                for (i = 0; i < bitmapData1.Height; i++)
                {
                    for (j = 0; j < bitmapData1.Width; j++)
                    {
                        imagePointer1[0] = (byte)GreyImage[i, j];
                        imagePointer1[1] = (byte)GreyImage[i, j];
                        imagePointer1[2] = (byte)GreyImage[i, j];
                        imagePointer1[3] = (byte)255;
                        imagePointer1 += 4;
                    }
                    imagePointer1 += (bitmapData1.Stride - (bitmapData1.Width * 4));
                }
            }
            image.UnlockBits(bitmapData1);
            return image;
        }

        /// <summary>
        /// Controller of the Canny class, invokes methods used for calculations
        /// </summary>
        private void DetectCannyEdges()
        {
            gaussianFilteredImage = new int[Height, Width];
            derivativeX = new int[Height, Width];
            derivativeY = new int[Height, Width];
            strongEdges = new int[Height, Width];
            weakEdges = new int[Height, Width];
            edgePoints = new int[Height, Width];
            edgeMap = new int[Height, Width];

            gradient = new float[Height, Width];
            nonMax = new float[Height, Width];

            if (useAutoThresholdValues == true)
            {
                CalculateThresholdValues();
            }

            dateTime1 = DateTime.Now;
            //Apply Gaussian blur to the grey image
            GaussianFilter();
            dateTime2 = DateTime.Now;
            //Count derivative X and Y of the gaussian filtered image 
            ApplyFilter3x3();
            dateTime3 = DateTime.Now;
            //Find the magnitude of the gradient
            GradientMagnitude();
            dateTime4 = DateTime.Now;
            //Perform non max suppression based on gradient
            NonMaxSuppressionAsync();
            dateTime5 = DateTime.Now;
            //Perform double thresholding based on highThreshold and lowThreshold
            DoubleThresholding();
            dateTime6 = DateTime.Now;
            //Perform edge tracking by hysteresis
            Hysterisis();
            dateTime7 = DateTime.Now;
            //Normalize edge map to max values
            NormalizeEdgeMap();
            dateTime8 = DateTime.Now;

            return;
        }

        /// <summary>
        /// Applies Gaussian Filter on grey image asynchronously
        /// </summary>
        private void GaussianFilter()
        {
            int i;
            gaussianFilteredImage = greyImage;
            int Limit = kernelSize / 2;
            listOfActions.Clear();
            for (i = Limit; i <= ((Height - 1) - Limit); i++)
            {
                int y = i;
                listOfActions.Add(() => GaussianRow(y));
            }
            Parallel.Invoke(numberOfThreads, listOfActions.ToArray());

            void GaussianRow(int i)
            {
                int j;
                int Limit = kernelSize / 2;
                for (j = Limit; j <= ((Width - 1) - Limit); j++)
                {
                    gaussianFilteredImage[i, j] = (ApplyFilterNxN(i, j, kernelSize, greyImage, gaussianKernel) / kernelWeight) - 1;
                }
            }

            void GaussianRowAsm(int i)
            {
                short[] newModifiedGaussianKernel = modifiedGaussianKernel;
                IntPtr arrayPtr = Marshal.UnsafeAddrOfPinnedArrayElement(greyImage, Width * i);
                IntPtr resultArrayPtr = Marshal.UnsafeAddrOfPinnedArrayElement(gaussianFilteredImage, Width * i);
                IntPtr filterPtr = Marshal.UnsafeAddrOfPinnedArrayElement(newModifiedGaussianKernel, 0);

                Gaussian(arrayPtr, filterPtr, resultArrayPtr, Width, kernelWeight);

            }
            return;
        }

        /// <summary>
        /// Applies filter on specific fragment of the grey image
        /// </summary>
        /// <param name="i"></param> Row of the image 
        /// <param name="j"></param> Column of the image
        /// <param name="size"></param> Size of filter
        /// <param name="Data"></param> Data to filter
        /// <param name="Filter"></param> Filter used
        /// <returns></returns>
        private static int ApplyFilterNxN(int i, int j, int size, int[,] Data, int[,] Filter)
        {
            int k;
            int l;
            int sum = 0;
            for (k = -size / 2; k <= size / 2; k++)
            {
                for (l = -size / 2; l <= size / 2; l++)
                {
                    sum += Data[i + k, j + l] * Filter[size / 2 + k, size / 2 + l];
                }
            }
            return sum;
        }

        /// <summary>
        /// Applies 3x3 filter on the grey image asynchronously
        /// </summary>
        private void ApplyFilter3x3()
        {
            int i;
            int size = 3;

            listOfActions.Clear();
            for (i = size / 2; i <= (Height - size / 2) - 1; i++)
            {
                int y = i;
                if(useAsseblyCode == true)
                {
                    listOfActions.Add(() => FilterRowAsm(y));
                }
                else
                {
                    listOfActions.Add(() => FilterRow(y));
                }
            }
            Parallel.Invoke(numberOfThreads, listOfActions.ToArray());

            void FilterRow(int i)
            {
                IntPtr arrayPtr = Marshal.UnsafeAddrOfPinnedArrayElement(gaussianFilteredImage, Width * i);
                IntPtr resultArrayXPtr = Marshal.UnsafeAddrOfPinnedArrayElement(derivativeX, Width * i);
                IntPtr resultArrayYPtr = Marshal.UnsafeAddrOfPinnedArrayElement(derivativeY, Width * i);
                IntPtr filterXPtr = Marshal.UnsafeAddrOfPinnedArrayElement(modifiedDx, 0);
                IntPtr filterYPtr = Marshal.UnsafeAddrOfPinnedArrayElement(modifiedDy, 0);

                Calculate3x3Cpp(arrayPtr, filterXPtr, resultArrayXPtr, Width);
                Calculate3x3Cpp(arrayPtr, filterYPtr, resultArrayYPtr, Width);

            }

            void FilterRowAsm(int i)
            {

                IntPtr arrayPtr = Marshal.UnsafeAddrOfPinnedArrayElement(gaussianFilteredImage, Width * i);
                IntPtr resultArrayXPtr = Marshal.UnsafeAddrOfPinnedArrayElement(derivativeX, Width * i);
                IntPtr resultArrayYPtr = Marshal.UnsafeAddrOfPinnedArrayElement(derivativeY, Width * i);
                IntPtr filterXPtr = Marshal.UnsafeAddrOfPinnedArrayElement(modifiedDx, 0);
                IntPtr filterYPtr = Marshal.UnsafeAddrOfPinnedArrayElement(modifiedDy, 0);

                Calculate3x3(arrayPtr, filterXPtr, resultArrayXPtr, Width);
                Calculate3x3(arrayPtr, filterYPtr, resultArrayYPtr, Width);
            }
            return;
        }

        /// <summary>
        /// Calculates Gradient of the grey image from derivatives asynchronously
        /// </summary>
        private void GradientMagnitude()
        {
            int i;

            listOfActions.Clear();
            for (i = 0; i <= (Height - 1); i++)
            {
                int y = i;
                listOfActions.Add(() => GradientMagnitudeRow(y));
            }
            Parallel.Invoke(numberOfThreads, listOfActions.ToArray());

            void GradientMagnitudeRow(int i)
            {
                int j;
                for (j = 0; j <= (Width - 1); j++)
                {
                    gradient[i, j] = (float)Math.Sqrt((derivativeX[i, j] * derivativeX[i, j]) + (derivativeY[i, j] * derivativeY[i, j]));
                }
            }
            return;
        }

        /// <summary>
        /// Non-Maximum Suppresses the grey image asynchronously
        /// </summary>
        private void NonMaxSuppressionAsync()
        {
            int Limit = 1;
            int i;

            listOfActions.Clear();
            for (i = Limit; i <= (Height - Limit) - 1; i++)
            {
                int y = i;
                listOfActions.Add(() => NonMaxSuppressionRow(y));
            }
            Parallel.Invoke(numberOfThreads, listOfActions.ToArray());

            void NonMaxSuppressionRow(int i)
            {
                int Limit = 1;
                int j;

                for (j = Limit; j <= (Width - Limit) - 1; j++)
                {
                    NonMaxSuppressionEdges(i, j);
                }
                return;
            }
            return;
        }

        /// <summary>
        /// Finds local maximum of the edge
        /// </summary>
        /// <param name="i"></param> Row of the image
        /// <param name="j"></param> Column of the image
        private void NonMaxSuppressionEdges(int i, int j)
        {
            float angle = (float)(Math.Atan2(derivativeY[i, j], derivativeX[i, j]) * 180 / Math.PI); //rad to degree

            //Vertical Edge
            if ((Math.Abs(angle) <= 22.5) || (Math.Abs(angle) >= 157.5))
            {
                if ((gradient[i, j] >= gradient[i, j + 1]) && (gradient[i, j] >= gradient[i, j - 1]))
                {
                    nonMax[i, j] = gradient[i, j];
                }
                else
                {
                    nonMax[i, j] = 0;
                }
            }

            //Horizontal Edge
            else if ((Math.Abs(angle) >= 67.5) && (Math.Abs(angle) <= 112.5))
            {
                if ((gradient[i, j] >= gradient[i + 1, j]) && (gradient[i, j] >= gradient[i - 1, j]))
                {
                    nonMax[i, j] = gradient[i, j];
                }
                else
                {
                    nonMax[i, j] = 0;
                }
            }

            //+45 Degree Edge
            else if (((angle > 112.5) && (angle < 157.5)) || ((angle < -22.5) && (angle > -67.5)))
            {
                if ((gradient[i, j] >= gradient[i + 1, j - 1]) && (gradient[i, j] >= gradient[i - 1, j + 1]))
                {
                    nonMax[i, j] = gradient[i, j];
                }
                else
                {
                    nonMax[i, j] = 0;
                }
            }

            //-45 Degree Edge
            else if (((angle > 22.5) && (angle < 67.5)) || ((angle < -112.5) && (angle > -157.5)))
            {
                if ((gradient[i, j] >= gradient[i + 1, j + 1]) && (gradient[i, j] >= gradient[i - 1, j - 1]))
                {
                    nonMax[i, j] = gradient[i, j];
                }
                else
                {
                    nonMax[i, j] = 0;
                }
            }
            return;
        }

        /// <summary>
        /// Applies double threshold to the grey image asynchronously
        /// </summary>
        private void DoubleThresholding()
        {
            int i;
            int Limit = 1;
            listOfActions.Clear();
            for (i = Limit; i <= (Height - Limit) - 1; i++)
            {
                int y = i;
                listOfActions.Add(() => DoubleThresholdingRow(y, Limit));
            }
            Parallel.Invoke(numberOfThreads, listOfActions.ToArray());

            void DoubleThresholdingRow(int i, int Limit)
            {
                int j;
                for (j = Limit; j <= (Width - Limit) - 1; j++)
                {
                    int value = (int)nonMax[i, j];

                    if (value >= highThreshold)
                    {
                        edgePoints[i, j] = 1;
                        strongEdges[i, j] = 255;
                    }
                    if ((value < highThreshold) && (value >= lowThreshold))
                    {

                        edgePoints[i, j] = 2;
                        weakEdges[i, j] = 255;

                    }
                }
            }
            return;
        }

        /// <summary>
        /// Applies hysterysis to grey image asynchronously
        /// </summary>
        private void Hysterisis()
        {
            int i;
            listOfActions.Clear();
            for (i = 0; i <= Height - 1; i++)
            {
                int y = i;
                listOfActions.Add(() => HysterisisRow(y));
            }
            Parallel.Invoke(numberOfThreads, listOfActions.ToArray());

            void HysterisisRow(int i)
            {
                int j;
                for (j = 0; j <= Width - 1; j++)
                {
                    if (edgePoints[i, j] == 1)
                    {
                        FindConnectedWeakEdges(i, j);
                    }
                }
            }
            return;
        }

        /// <summary>
        /// Recurrent method finding weak edges connected to strong edges
        /// </summary>
        /// <param name="row"></param> Row of the image
        /// <param name="col"></param> Column of the image
        private void FindConnectedWeakEdges(int row, int col)
        {
            if (ifVisited[row, col] == false)
            {
                ifVisited[row, col] = true;
                for (int i = -1; i <= 1; i++)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        if ((row + i > 0) && (col + j > 0) && (row + i < Height - 1) && (col + j < Width - 1) && edgePoints[row + i, col + j] == 2)
                        {
                            edgePoints[row + i, col + j] = 1;
                            FindConnectedWeakEdges(row + i, col + j);
                        }
                    }
                }              
            }
            return;
        }

        /// <summary>
        /// Normalises the edge map by removing unwanted values
        /// </summary>
        private void NormalizeEdgeMap()
        {
            int i;
            listOfActions.Clear();
            for (i = 0; i <= (Height - 1); i++)
            {
                int y = i;
                listOfActions.Add(() => NormalizeEdgeMapRow(y));
            }
            Parallel.Invoke(numberOfThreads, listOfActions.ToArray());

            void NormalizeEdgeMapRow(int i)
            {
                int j;
                for (j = 0; j <= (Width - 1); j++)
                {
                    if (edgePoints[i, j] == 1)
                    {
                        edgeMap[i, j] = 255;
                    }
                }
            }
            return;
        }

        /// <summary>
        /// Calculates optimal threshold Values
        /// </summary>
        private void CalculateThresholdValues()
        {
            var list = new List<int>();
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    list.Add(greyImage[i, j]);
                }
            }
            list.Sort();
            float median;
            int middle = list.Count / 2;
            if (list.Count % 2 == 1)
            {
                median = list[middle];
            }
            else
            {
                median = ((list[middle - 1] + list[middle]) / 2.0f);
            }

            lowThreshold = median * 0.66f;
            highThreshold = median * 1.33f;
        }

        // End of Canny Class
    }

}