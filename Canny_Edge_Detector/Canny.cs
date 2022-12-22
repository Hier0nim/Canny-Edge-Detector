using Microsoft.AspNetCore.Mvc;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Canny_Edge_Detector
{

    class Canny
    {
        private readonly Bitmap inputImage;

        private readonly int Height;
        private readonly int Width;
        private readonly int threads;

        private int[,] greyImage;
        private int[,] gaussianFilteredImage;
        private int[,] postHysteresis;
        private int[,] edgePoints;
        private int[,] edgeMap;
        private int[,] derivativeX;
        private int[,] derivativeY;
        private int[,] strongEdges;
        private int[,] weakEdges;

        private Boolean[,] ifVisited;


        private float[,] gradient;
        private float[,] nonMax;

        //Gaussian Kernel Data
        private int[,] gaussianKernel =
        {
            {1,4,7,4,1},
            {4,16,26,16,4},
            {7,26,41,26,7},
            {4,16,26,16,4},
            {1,4,7,4,1}
        };
        private int kernelWeight = 271;
        private int kernelSize = 5;

        //Threshold Data
        private float highThreshold;
        private float lowThreshold;

        public int[,] GaussianFilteredImage { get => gaussianFilteredImage;}
        public int[,] EdgeMap { get => edgeMap;}
        public float[,] Gradient { get => gradient;}
        public float[,] NonMax { get => nonMax;}
        public int[,] StrongEdges { get => strongEdges;}
        public int[,] WeakEdges { get => weakEdges;}

        public Canny(Bitmap Input, float Th, float Tl, int threads)
        {

            // Gaussian and Canny Parameters

            highThreshold = Th;
            lowThreshold = Tl;
            this.threads = threads;

            inputImage = Input;
            Height = inputImage.Height;
            Width = inputImage.Width;

            edgeMap = new int[Height, Width];
            ifVisited = new Boolean[Height, Width];

            ReadImage();
            DetectCannyEdges();
            return;
        }

        public Bitmap DisplayImage(float[,] GreyImage)
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

        private void ReadImage()
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

        private void DetectCannyEdges()
        {
            gradient = new float[Height, Width];
            nonMax = new float[Height, Width];

            derivativeX = new int[Height, Width];
            derivativeY = new int[Height, Width];
            strongEdges = new int[Height, Width];
            weakEdges = new int[Height, Width];

            postHysteresis = new int[Height, Width];  
            edgePoints = new int[Height, Width]; 
            gaussianFilteredImage = new int[Height, Width];

            //Sobel Masks
            int[,] Dx = {
                {1,0,-1},
                {2,0,-2},
                {1,0,-1}
            };

            int[,] Dy = {
                {1,2,1},
                {0,0,0},
                {-1,-2,-1}
            };

            

            //Apply gaussian blur: 4007
            GaussianFilterAsync();
            //Count derivative X and Y of the gaussian filtered image:2800
            ApplyFilterAsync(Dx, Dy);
            //Find the magnitude of the gradient 347
            GradientMagnitudeAsync();
            //Perform non max suppression based on gradient: 1659
            NonMaxSuppressionAsync();
            //Perform double thresholding based on highThreshold and lowThreshold : 522
            DoubleThresholding();
            //Perform edge tracking by hysteresis: 1034
            HysterisisThresholding();
            //Normalize edge map to max values:
            NormalizeEdgeMap();
            
            return;

        }

        private void GaussianFilterAsync()
        {
            int i;
            gaussianFilteredImage = greyImage;
            int Limit = kernelSize / 2;
            List<Action> listOfActions = new List<Action>();
            for (i = Limit; i <= ((Height - 1) - Limit); i++)
            {

                int y = i;
                listOfActions.Add(() => GaussianRow(y));
            }

            ParallelOptions options = new ParallelOptions { MaxDegreeOfParallelism = threads};
            Parallel.Invoke(options,listOfActions.ToArray());          
        }

        private void GaussianRow(int i)
        {
            int j;
            int Limit = kernelSize / 2;
            for (j = Limit; j <= ((Width - 1) - Limit); j++)
            {
                gaussianFilteredImage[i, j] = CountSum(i, j, kernelSize, greyImage, gaussianKernel) / kernelWeight;
            }

        }

        private void ApplyFilterAsync(int[,] FilterX, int[,] FilterY)
        {
            int i;
            int size = FilterX.GetLength(0);

            List<Action> listOfActions = new List<Action>();
            for (i = size / 2; i <= (Height - size / 2) - 1; i++)
            {
                int y = i;
                listOfActions.Add(() => FilterRow(y, size, FilterX, FilterY));
            }
            ParallelOptions options = new ParallelOptions { MaxDegreeOfParallelism = threads};
            Parallel.Invoke(options, listOfActions.ToArray());
        }

        private void FilterRow(int i, int size, int[,] FilterX, int[,] FilterY)
        {
            int j;
            for (j = size / 2; j <= (Width - size / 2) - 1; j++)
            {
                derivativeX[i, j] = CountSum(i, j, size, gaussianFilteredImage, FilterX);
                derivativeY[i, j] = CountSum(i, j, size, gaussianFilteredImage, FilterY);
            }

        }

        private void GaussianFilter()
        {

            int i;
            int j;
            gaussianFilteredImage = greyImage;
            int Limit = kernelSize / 2;
            //for (i = Limit; i <= ((Height - 1) - Limit); i++)
            Parallel.For(Limit, ((Height - 1) - Limit), new ParallelOptions { MaxDegreeOfParallelism = threads }, i =>
            {
                //for (j = Limit; j <= ((Width - 1) - Limit); j++)
                Parallel.For(Limit, ((Width - 1) - Limit), new ParallelOptions { MaxDegreeOfParallelism = threads }, j =>
                {
                    gaussianFilteredImage[i, j] = CountSum(i, j, kernelSize, greyImage, gaussianKernel) / kernelWeight;
                });
            });
            return;
        }

        private void NormalizeEdgeMap()
        {
            int i;
            int j;
            for (i = 0; i <= (Height - 1); i++)
            {
                for (j = 0; j <= (Width - 1); j++)
                {
                    edgeMap[i, j] = edgeMap[i, j] * 255;
                }
            }
            return;
        }

        private void ApplyFilter(int[,] FilterX, int[,] FilterY)
        {
            int i;
            int j;
            int size = FilterX.GetLength(0);




            for (i = size / 2; i <= (Height - size / 2) - 1; i++)
            {
                for (j = size / 2; j <= (Width - size / 2) - 1; j++)
                {
                    derivativeX[i, j] = CountSum(i, j, size, gaussianFilteredImage, FilterX);
                    derivativeY[i, j] = CountSum(i, j, size, gaussianFilteredImage, FilterY);
                }
            }

        }



        private int CountSum(int i, int j, int size, int[,] Data, int[,] Filter)
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

        private void GradientMagnitudeAsync()
        {
            int i;

            List<Action> listOfActions = new List<Action>();
            for (i = 0; i <= (Height - 1); i++)
            {
                int y = i;
                listOfActions.Add(() => GradientMagnitudeRow(y));
            }
            ParallelOptions options = new ParallelOptions { MaxDegreeOfParallelism = threads };
            Parallel.Invoke(options, listOfActions.ToArray());
            return;
        }

        private void GradientMagnitudeRow(int i)
        {
            int j;
            for (j = 0; j <= (Width - 1); j++)
            {
                gradient[i, j] = (float)Math.Sqrt((derivativeX[i, j] * derivativeX[i, j]) + (derivativeY[i, j] * derivativeY[i, j]));
            }
        }

        private void GradientMagnitude()
        {
            int i;
            int j;
            for (i = 0; i <= (Height - 1); i++)
            {
                for (j = 0; j <= (Width - 1); j++)
                {
                    gradient[i, j] = (float)Math.Sqrt((derivativeX[i, j] * derivativeX[i, j]) + (derivativeY[i, j] * derivativeY[i, j]));
                }
            }
            return;
        }




        private void HysterisisThresholding()
        {
            int i;
            int j;

            for (i = 0; i <= Height - 1; i++)
            {
                for (j = 0; j <= Width - 1; j++)
                {
                    if (edgePoints[i, j] == 1)
                    {
                        FindConnectedWeakEdges(i, j);
                    }
                }
            }

            for (i = 0; i <= Height - 1; i++)
            {
                for (j = 0; j <= (Width - 1); j++)
                {
                    if (edgePoints[i, j] == 1)
                    {
                        edgeMap[i, j] = 1;
                    }
                }
            }
            return;
        }

        private void FindConnectedWeakEdges(int row, int col)
        {
            if (ifVisited[row, col] == false)
            {
                for (int i = -2; i <= 2; i++)
                {
                    for (int j = -2; j <= 2; j++)
                    {
                        if ((row + i > 0) && (col + j > 0) && (row + i < Width - 1) && (col + j < Height - 1) && edgePoints[row + i, col + j] == 2)
                        {
                            edgePoints[row + i, col + j] = 1;
                            FindConnectedWeakEdges(row + i, col + j);
                        }
                    }
                }
                ifVisited[row, col] = true;
            }
            return;
        }

        private void NonMaxSuppressionAsync()
        {
            int Limit = kernelSize / 2;
            int i;
            int j;

            List<Action> listOfActions = new List<Action>();
            for (i = Limit; i <= (Height - Limit) - 1; i++)
            {
                int y = i;
                listOfActions.Add(() => NonMaxSuppressionRow(y));
            }
            ParallelOptions options = new ParallelOptions { MaxDegreeOfParallelism = threads };
            Parallel.Invoke(options, listOfActions.ToArray());
        }

        //
        private void NonMaxSuppressionRow(int i)
        {
            int Limit = kernelSize / 2;
            int j;

            for (j = Limit; j <= (Width - Limit) - 1; j++)
            {
                NonMaxSuppressionEdges(i, j);
            }
            return;
        }

        private void NonMaxSuppression()
        {
            int Limit = kernelSize / 2;
            int i;
            int j;

            for (i = Limit; i <= (Height - Limit) - 1; i++)
            {
                for (j = Limit; j <= (Width - Limit) - 1; j++)
                {
                    NonMaxSuppressionEdges(i, j);
                }
            }
            return;
        }

        private void NonMaxSuppressionEdges(int i, int j)
        {
            float angle = (float)(Math.Atan2(derivativeY[i, j], derivativeX[i, j]) * 180 / Math.PI); //rad to degree

            //Horizontal Edge
            if (((angle >= -22.5) && (angle <= 22.5)) || ((angle < -157.5) && (angle >= -180)))
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

            //Vertical Edge
            else if (((angle >= 67.5) && (angle <= 112.5)) || ((angle < -67.5) && (angle >= -112.5)))
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
            else if (((angle >= 112.5) && (angle <= 157.5)) || ((angle < -22.5) && (angle >= -67.5)))
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
            else if (((angle >= 22.5) && (angle <= 67.5)) || ((angle < -112.5) && (angle >= -157.5)))
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

        private void DoubleThresholding()
        {
            int Limit = kernelSize / 2;
            int i;
            int j;
            //PostHysteresis = NonMax;
            for (i = Limit; i <= (Height - Limit) - 1; i++)
            {
                for (j = Limit; j <= (Width - Limit) - 1; j++)
                {
                    postHysteresis[i, j] = (int)nonMax[i, j];
                }

            }

            for (i = Limit; i <= (Height - Limit) - 1; i++)
            {
                for (j = Limit; j <= (Width - Limit) - 1; j++)
                {
                    if (postHysteresis[i, j] >= highThreshold)
                    {
                        edgePoints[i, j] = 1;
                        strongEdges[i, j] = 255;
                    }
                    if ((postHysteresis[i, j] < highThreshold) && (postHysteresis[i, j] >= lowThreshold))
                    {

                        edgePoints[i, j] = 2;
                        weakEdges[i, j] = 255;

                    }
                }
            }
        }
        //
    }

}