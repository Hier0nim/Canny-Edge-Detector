using System.Runtime.InteropServices;

namespace Canny_Edge_Detector
{
    /// <summary>
    /// Class for app service
    /// </summary>
    public partial class AppForm : Form
    {
        // Canny class object
        internal Canny CannyData { get; private set; } = null!;

        // Average DLL timespan
        TimeSpan avgDllTime = new TimeSpan();

        /// <summary>
        /// Constructor of the AooForm class
        /// </summary>
        public AppForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Selects image from folder when corresponding button is pressed.
        /// Formats of image can vary
        /// </summary>
        private void SelectImageButton_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new()
            {
                // image filters   

                Filter = "Bitmap files (*.bmp)|*.bmp|PNG files (*.png)|*.png|TIFF files (*.tif)|*tif|JPEG files (*.jpg)|*.jpg",
                FilterIndex = 4,
                RestoreDirectory = true
            };
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                inputPictureBox.Image = new Bitmap(open.FileName);
            }
        }

        /// <summary>
        /// Processes image when corresponding button is pressed.
        /// </summary>
        private void ProcessImageButton_Click(object sender, EventArgs e)
        {
            bool useAssemblyCode = useAssembly.Checked;
            bool autoThresholdValues = autoThreshold.Checked;

            int threads = GetNumberOfThreads();
            if(threads <= 0 || threads > 64)
            {
                return;
            }
            if (inputPictureBox == null || inputPictureBox.Image == null)
            {
                return;
            }
            if (float.TryParse(highThresholdTextBox.Text, out float TH) == false)
            {
                TH = 25;
            }
            if (float.TryParse(lowThresholdTextBox.Text, out float TL) == false)
            {
                TL = 15;
            }

            TimeSpan timeSpan;
            DateTime dateTime1 = DateTime.Now;

            CannyData = new Canny((Bitmap)inputPictureBox.Image, TH, TL, threads, useAssemblyCode, autoThresholdValues);

            DateTime dateTime2 = DateTime.Now;
            timeSpan = dateTime2 - dateTime1;

            gaussianPictureBox.Image = CannyData.DisplayImage(CannyData.GaussianFilteredImage);

            gradientPictureBox.Image = CannyData.ConvertGreyImageToBitmap(CannyData.Gradient);

            nonMaxPictureBox.Image = CannyData.ConvertGreyImageToBitmap(CannyData.NonMax);

            lowThresholdPictureBox.Image = CannyData.DisplayImage(CannyData.WeakEdges);

            highThresholdPictureBox.Image = CannyData.DisplayImage(CannyData.StrongEdges);

            finalPictureBox.Image = CannyData.DisplayImage(CannyData.EdgeMap);
            
            timesExecutedLabel.Text = 1.ToString();
            
            completionTimeLabel.Text = timeSpan.TotalSeconds.ToString();
            gaussianTimeLabel.Text = (CannyData.dateTime2 - CannyData.dateTime1).TotalMilliseconds.ToString();
            filtersTimeLabel.Text = (CannyData.dateTime3 - CannyData.dateTime2).TotalMilliseconds.ToString();
            gradientTimeLabel.Text = (CannyData.dateTime4 - CannyData.dateTime3).TotalMilliseconds.ToString();
            nonMaxTimeLabel.Text = (CannyData.dateTime5 - CannyData.dateTime4).TotalMilliseconds.ToString();
            doubleTTimeLabel.Text = (CannyData.dateTime6 - CannyData.dateTime5).TotalMilliseconds.ToString();
            hysterisisTimeLabel.Text = (CannyData.dateTime7 - CannyData.dateTime6).TotalMilliseconds.ToString();
            normalizeTimeLabel.Text = (CannyData.dateTime8 - CannyData.dateTime7).TotalMilliseconds.ToString();

            avgDllTimeLabel.Text = (CannyData.dateTime3 - CannyData.dateTime2).TotalMilliseconds.ToString();
            GC.Collect();
        }

        /// <summary>
        /// Tries to parse numer of threads from string into integer
        /// </summary>
        private int GetNumberOfThreads()
        {
            try
            {
                return int.Parse(threadsTextBox.Text);
            }
            catch (Exception)
            {
                return -1;
            }
        }

        /// <summary>
        /// Saves image to selected folder when corresponding button is pressed.
        /// </summary>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new()
            {
                // image filters   

                Filter = "Bitmap files (*.bmp)|*.bmp|PNG files (*.png)|*.png|TIFF files (*.tif)|*tif|JPEG files (*.jpg)|*.jpg",
                FilterIndex = 4,
                RestoreDirectory = true,
                AddExtension = true
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {

                CannyData.DisplayImage(CannyData.EdgeMap).Save(dialog.FileName);
            }
        }

        /// <summary>
        /// Processes image 100 times when corresponding button is pressed.
        /// </summary>
        private void MultipleProcessButton_Click(object sender, EventArgs e)
        {
            bool useAssemblyCode = useAssembly.Checked;
            bool autoThresholdValues = autoThreshold.Checked;

            int threads = GetNumberOfThreads();
            if (threads <= 0 || threads > 64)
            {
                return;
            }
            if (inputPictureBox == null || inputPictureBox.Image == null)
            {
                return;
            }
            if (float.TryParse(highThresholdTextBox.Text, out float TH) == false)
            {
                TH = 25;
            }
            if (float.TryParse(lowThresholdTextBox.Text, out float TL) == false)
            {
                TL = 15;
            }
            TimeSpan timeSpan;
            TimeSpan timeSpan1 = new();
            TimeSpan timeSpan2 = new();
            TimeSpan timeSpan3 = new();
            TimeSpan timeSpan4 = new();
            TimeSpan timeSpan5 = new();
            TimeSpan timeSpan6 = new();
            TimeSpan timeSpan7 = new();

            DateTime dateTime1 = DateTime.Now;
            for (int i = 0; i < 10; i++)
            {
                CannyData = new Canny((Bitmap)inputPictureBox.Image, TH, TL, threads, useAssemblyCode, autoThresholdValues);
                GC.Collect();
                if (i == 0)
                {
                    timeSpan1 = (CannyData.dateTime2 - CannyData.dateTime1);
                    timeSpan2 = (CannyData.dateTime3 - CannyData.dateTime2);
                    timeSpan3 = (CannyData.dateTime4 - CannyData.dateTime3);
                    timeSpan4 = (CannyData.dateTime5 - CannyData.dateTime4);
                    timeSpan5 = (CannyData.dateTime6 - CannyData.dateTime5);
                    timeSpan6 = (CannyData.dateTime7 - CannyData.dateTime6);
                    timeSpan7 = (CannyData.dateTime8 - CannyData.dateTime7);
                }
                else
                {
                    timeSpan1 += (CannyData.dateTime2 - CannyData.dateTime1);
                    timeSpan2 += (CannyData.dateTime3 - CannyData.dateTime2);
                    timeSpan3 += (CannyData.dateTime4 - CannyData.dateTime3);
                    timeSpan4 += (CannyData.dateTime5 - CannyData.dateTime4);
                    timeSpan5 += (CannyData.dateTime6 - CannyData.dateTime5);
                    timeSpan6 += (CannyData.dateTime7 - CannyData.dateTime6);
                    timeSpan7 += (CannyData.dateTime8 - CannyData.dateTime7);
                    
                }
                timesExecutedLabel.Text = (i+1).ToString() + " / 10";
                timesExecutedLabel.Refresh();
            }
            avgDllTime = timeSpan2 / 10;
            DateTime dateTime2 = DateTime.Now;
            timeSpan = dateTime2 - dateTime1;

            gaussianPictureBox.Image = CannyData.DisplayImage(CannyData.GaussianFilteredImage);

            gradientPictureBox.Image = CannyData.ConvertGreyImageToBitmap(CannyData.Gradient);

            nonMaxPictureBox.Image = CannyData.ConvertGreyImageToBitmap(CannyData.NonMax);

            lowThresholdPictureBox.Image = CannyData.DisplayImage(CannyData.WeakEdges);

            highThresholdPictureBox.Image = CannyData.DisplayImage(CannyData.StrongEdges);

            finalPictureBox.Image = CannyData.DisplayImage(CannyData.EdgeMap);

            completionTimeLabel.Text = timeSpan.TotalSeconds.ToString();

            gaussianTimeLabel.Text = timeSpan1.TotalMilliseconds.ToString();
            filtersTimeLabel.Text = timeSpan2.TotalMilliseconds.ToString();
            gradientTimeLabel.Text = timeSpan3.TotalMilliseconds.ToString();
            nonMaxTimeLabel.Text = timeSpan4.TotalMilliseconds.ToString();
            doubleTTimeLabel.Text = timeSpan5.TotalMilliseconds.ToString();
            hysterisisTimeLabel.Text = timeSpan6.TotalMilliseconds.ToString();
            normalizeTimeLabel.Text = timeSpan7.TotalMilliseconds.ToString();

            avgDllTimeLabel.Text = avgDllTime.TotalMilliseconds.ToString();
            GC.Collect();
        }
    }
}
