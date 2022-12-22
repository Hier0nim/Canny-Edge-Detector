using System.Runtime.InteropServices;

namespace Canny_Edge_Detector
{
    public partial class AppForm : Form
    {
        internal Canny CannyData { get; private set; }

        public AppForm()
        {
            InitializeComponent();
        }

        private void SelectImageButton_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters   
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                inputPictureBox.Image = new Bitmap(open.FileName);
            }
        }

        private void processImageButton_Click(object sender, EventArgs e)
        {
            int threads = getNumberOfThreads();
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

            DateTime dateTime1 = new DateTime();
            DateTime dateTime2 = new DateTime();
            TimeSpan timeSpan = new TimeSpan();

            dateTime1 = DateTime.Now;

            CannyData = new Canny((Bitmap)inputPictureBox.Image, TH, TL, threads);

            dateTime2 = DateTime.Now;
            timeSpan = dateTime2 - dateTime1;

            gaussianPictureBox.Image = CannyData.DisplayImage(CannyData.GaussianFilteredImage);

            sobelPictureBox.Image = CannyData.DisplayImage(CannyData.Gradient);

            nonMaxPictureBox.Image = CannyData.DisplayImage(CannyData.NonMax);

            lowThresholdPictureBox.Image = CannyData.DisplayImage(CannyData.WeakEdges);

            highThresholdPictureBox.Image = CannyData.DisplayImage(CannyData.StrongEdges);

            finalPictureBox.Image = CannyData.DisplayImage(CannyData.EdgeMap);

            
            completionTimeLabel.Text = timeSpan.TotalSeconds.ToString();
            gaussianTimeLabel.Text = (CannyData.dateTime2 - CannyData.dateTime1).TotalMilliseconds.ToString();
            filtersTimeLabel.Text = (CannyData.dateTime3 - CannyData.dateTime2).TotalMilliseconds.ToString();
            gradientTimeLabel.Text = (CannyData.dateTime4 - CannyData.dateTime3).TotalMilliseconds.ToString();
            nonMaxTimeLabel.Text = (CannyData.dateTime5 - CannyData.dateTime4).TotalMilliseconds.ToString();
            doubleTTimeLabel.Text = (CannyData.dateTime6 - CannyData.dateTime5).TotalMilliseconds.ToString();
            hysterisisTimeLabel.Text = (CannyData.dateTime7 - CannyData.dateTime6).TotalMilliseconds.ToString();
            normalizeTimeLabel.Text = (CannyData.dateTime8 - CannyData.dateTime7).TotalMilliseconds.ToString();

            GC.Collect();
        }

        private int getNumberOfThreads()
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }
    }
}
