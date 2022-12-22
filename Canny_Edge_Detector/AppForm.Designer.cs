namespace Canny_Edge_Detector
{
    partial class AppForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.inputPictureBox = new System.Windows.Forms.PictureBox();
            this.gaussianGroupBox = new System.Windows.Forms.GroupBox();
            this.gaussianPictureBox = new System.Windows.Forms.PictureBox();
            this.highThresholdGroupBox = new System.Windows.Forms.GroupBox();
            this.highThresholdPictureBox = new System.Windows.Forms.PictureBox();
            this.lowThresholdGroupBox = new System.Windows.Forms.GroupBox();
            this.lowThresholdPictureBox = new System.Windows.Forms.PictureBox();
            this.SelectImageButton = new System.Windows.Forms.Button();
            this.processImageButton = new System.Windows.Forms.Button();
            this.nonMaxGroupBox = new System.Windows.Forms.GroupBox();
            this.nonMaxPictureBox = new System.Windows.Forms.PictureBox();
            this.finalGroupBox = new System.Windows.Forms.GroupBox();
            this.finalPictureBox = new System.Windows.Forms.PictureBox();
            this.sobelGroupBox = new System.Windows.Forms.GroupBox();
            this.sobelPictureBox = new System.Windows.Forms.PictureBox();
            this.highThresholdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lowThresholdTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.threadsTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.completionTimeLabel = new System.Windows.Forms.Label();
            this.inputGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputPictureBox)).BeginInit();
            this.gaussianGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gaussianPictureBox)).BeginInit();
            this.highThresholdGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.highThresholdPictureBox)).BeginInit();
            this.lowThresholdGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lowThresholdPictureBox)).BeginInit();
            this.nonMaxGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nonMaxPictureBox)).BeginInit();
            this.finalGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finalPictureBox)).BeginInit();
            this.sobelGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sobelPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.Controls.Add(this.inputPictureBox);
            this.inputGroupBox.Location = new System.Drawing.Point(12, 12);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Size = new System.Drawing.Size(268, 284);
            this.inputGroupBox.TabIndex = 0;
            this.inputGroupBox.TabStop = false;
            this.inputGroupBox.Text = "Input Image";
            // 
            // inputPictureBox
            // 
            this.inputPictureBox.Location = new System.Drawing.Point(6, 22);
            this.inputPictureBox.Name = "inputPictureBox";
            this.inputPictureBox.Size = new System.Drawing.Size(256, 256);
            this.inputPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.inputPictureBox.TabIndex = 0;
            this.inputPictureBox.TabStop = false;
            // 
            // gaussianGroupBox
            // 
            this.gaussianGroupBox.Controls.Add(this.gaussianPictureBox);
            this.gaussianGroupBox.Location = new System.Drawing.Point(286, 12);
            this.gaussianGroupBox.Name = "gaussianGroupBox";
            this.gaussianGroupBox.Size = new System.Drawing.Size(268, 284);
            this.gaussianGroupBox.TabIndex = 1;
            this.gaussianGroupBox.TabStop = false;
            this.gaussianGroupBox.Text = "Gaussian Filtered Image";
            // 
            // gaussianPictureBox
            // 
            this.gaussianPictureBox.Location = new System.Drawing.Point(6, 22);
            this.gaussianPictureBox.Name = "gaussianPictureBox";
            this.gaussianPictureBox.Size = new System.Drawing.Size(256, 256);
            this.gaussianPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gaussianPictureBox.TabIndex = 0;
            this.gaussianPictureBox.TabStop = false;
            // 
            // highThresholdGroupBox
            // 
            this.highThresholdGroupBox.Controls.Add(this.highThresholdPictureBox);
            this.highThresholdGroupBox.Location = new System.Drawing.Point(286, 296);
            this.highThresholdGroupBox.Name = "highThresholdGroupBox";
            this.highThresholdGroupBox.Size = new System.Drawing.Size(268, 284);
            this.highThresholdGroupBox.TabIndex = 2;
            this.highThresholdGroupBox.TabStop = false;
            this.highThresholdGroupBox.Text = "Strong Edges";
            // 
            // highThresholdPictureBox
            // 
            this.highThresholdPictureBox.Location = new System.Drawing.Point(6, 22);
            this.highThresholdPictureBox.Name = "highThresholdPictureBox";
            this.highThresholdPictureBox.Size = new System.Drawing.Size(256, 256);
            this.highThresholdPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.highThresholdPictureBox.TabIndex = 0;
            this.highThresholdPictureBox.TabStop = false;
            // 
            // lowThresholdGroupBox
            // 
            this.lowThresholdGroupBox.Controls.Add(this.lowThresholdPictureBox);
            this.lowThresholdGroupBox.Location = new System.Drawing.Point(560, 296);
            this.lowThresholdGroupBox.Name = "lowThresholdGroupBox";
            this.lowThresholdGroupBox.Size = new System.Drawing.Size(268, 284);
            this.lowThresholdGroupBox.TabIndex = 2;
            this.lowThresholdGroupBox.TabStop = false;
            this.lowThresholdGroupBox.Text = "Weak Edges";
            // 
            // lowThresholdPictureBox
            // 
            this.lowThresholdPictureBox.Location = new System.Drawing.Point(6, 22);
            this.lowThresholdPictureBox.Name = "lowThresholdPictureBox";
            this.lowThresholdPictureBox.Size = new System.Drawing.Size(256, 256);
            this.lowThresholdPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lowThresholdPictureBox.TabIndex = 0;
            this.lowThresholdPictureBox.TabStop = false;
            // 
            // SelectImageButton
            // 
            this.SelectImageButton.Location = new System.Drawing.Point(252, 581);
            this.SelectImageButton.Name = "SelectImageButton";
            this.SelectImageButton.Size = new System.Drawing.Size(100, 25);
            this.SelectImageButton.TabIndex = 4;
            this.SelectImageButton.Text = "Select Image";
            this.SelectImageButton.UseVisualStyleBackColor = true;
            this.SelectImageButton.Click += new System.EventHandler(this.SelectImageButton_Click);
            // 
            // processImageButton
            // 
            this.processImageButton.Location = new System.Drawing.Point(358, 581);
            this.processImageButton.Name = "processImageButton";
            this.processImageButton.Size = new System.Drawing.Size(100, 25);
            this.processImageButton.TabIndex = 5;
            this.processImageButton.Text = "Process Image";
            this.processImageButton.UseVisualStyleBackColor = true;
            this.processImageButton.Click += new System.EventHandler(this.processImageButton_Click);
            // 
            // nonMaxGroupBox
            // 
            this.nonMaxGroupBox.Controls.Add(this.nonMaxPictureBox);
            this.nonMaxGroupBox.Location = new System.Drawing.Point(12, 296);
            this.nonMaxGroupBox.Name = "nonMaxGroupBox";
            this.nonMaxGroupBox.Size = new System.Drawing.Size(268, 284);
            this.nonMaxGroupBox.TabIndex = 3;
            this.nonMaxGroupBox.TabStop = false;
            this.nonMaxGroupBox.Text = "Non Max Suppressed Image";
            // 
            // nonMaxPictureBox
            // 
            this.nonMaxPictureBox.Location = new System.Drawing.Point(6, 22);
            this.nonMaxPictureBox.Name = "nonMaxPictureBox";
            this.nonMaxPictureBox.Size = new System.Drawing.Size(256, 256);
            this.nonMaxPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nonMaxPictureBox.TabIndex = 0;
            this.nonMaxPictureBox.TabStop = false;
            // 
            // finalGroupBox
            // 
            this.finalGroupBox.Controls.Add(this.finalPictureBox);
            this.finalGroupBox.Location = new System.Drawing.Point(834, 12);
            this.finalGroupBox.Name = "finalGroupBox";
            this.finalGroupBox.Size = new System.Drawing.Size(552, 568);
            this.finalGroupBox.TabIndex = 3;
            this.finalGroupBox.TabStop = false;
            this.finalGroupBox.Text = "Final Image";
            // 
            // finalPictureBox
            // 
            this.finalPictureBox.Location = new System.Drawing.Point(0, 22);
            this.finalPictureBox.Name = "finalPictureBox";
            this.finalPictureBox.Size = new System.Drawing.Size(546, 540);
            this.finalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.finalPictureBox.TabIndex = 0;
            this.finalPictureBox.TabStop = false;
            // 
            // sobelGroupBox
            // 
            this.sobelGroupBox.Controls.Add(this.sobelPictureBox);
            this.sobelGroupBox.Location = new System.Drawing.Point(560, 12);
            this.sobelGroupBox.Name = "sobelGroupBox";
            this.sobelGroupBox.Size = new System.Drawing.Size(268, 284);
            this.sobelGroupBox.TabIndex = 3;
            this.sobelGroupBox.TabStop = false;
            this.sobelGroupBox.Text = "Sobel Filtered Image";
            // 
            // sobelPictureBox
            // 
            this.sobelPictureBox.Location = new System.Drawing.Point(6, 22);
            this.sobelPictureBox.Name = "sobelPictureBox";
            this.sobelPictureBox.Size = new System.Drawing.Size(256, 256);
            this.sobelPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sobelPictureBox.TabIndex = 0;
            this.sobelPictureBox.TabStop = false;
            // 
            // highThresholdTextBox
            // 
            this.highThresholdTextBox.Location = new System.Drawing.Point(106, 583);
            this.highThresholdTextBox.Name = "highThresholdTextBox";
            this.highThresholdTextBox.Size = new System.Drawing.Size(40, 23);
            this.highThresholdTextBox.TabIndex = 7;
            this.highThresholdTextBox.Text = "25";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 586);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "High Threshold";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 615);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Low Threshold";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lowThresholdTextBox
            // 
            this.lowThresholdTextBox.Location = new System.Drawing.Point(106, 612);
            this.lowThresholdTextBox.Name = "lowThresholdTextBox";
            this.lowThresholdTextBox.Size = new System.Drawing.Size(40, 23);
            this.lowThresholdTextBox.TabIndex = 9;
            this.lowThresholdTextBox.Text = "15";
            this.lowThresholdTextBox.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 586);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Threads";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // threadsTextBox
            // 
            this.threadsTextBox.Location = new System.Drawing.Point(206, 583);
            this.threadsTextBox.Name = "threadsTextBox";
            this.threadsTextBox.Size = new System.Drawing.Size(40, 23);
            this.threadsTextBox.TabIndex = 11;
            this.threadsTextBox.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 615);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Completion Time";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // completionTimeLabel
            // 
            this.completionTimeLabel.AutoSize = true;
            this.completionTimeLabel.Location = new System.Drawing.Point(257, 615);
            this.completionTimeLabel.Name = "completionTimeLabel";
            this.completionTimeLabel.Size = new System.Drawing.Size(51, 15);
            this.completionTimeLabel.TabIndex = 14;
            this.completionTimeLabel.Text = "Seconds";
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 645);
            this.Controls.Add(this.completionTimeLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.threadsTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lowThresholdTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.highThresholdTextBox);
            this.Controls.Add(this.sobelGroupBox);
            this.Controls.Add(this.finalGroupBox);
            this.Controls.Add(this.nonMaxGroupBox);
            this.Controls.Add(this.processImageButton);
            this.Controls.Add(this.SelectImageButton);
            this.Controls.Add(this.lowThresholdGroupBox);
            this.Controls.Add(this.highThresholdGroupBox);
            this.Controls.Add(this.gaussianGroupBox);
            this.Controls.Add(this.inputGroupBox);
            this.Name = "AppForm";
            this.Text = "AppForm";
            this.inputGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputPictureBox)).EndInit();
            this.gaussianGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gaussianPictureBox)).EndInit();
            this.highThresholdGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.highThresholdPictureBox)).EndInit();
            this.lowThresholdGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lowThresholdPictureBox)).EndInit();
            this.nonMaxGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nonMaxPictureBox)).EndInit();
            this.finalGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.finalPictureBox)).EndInit();
            this.sobelGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sobelPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox inputGroupBox;
        private PictureBox inputPictureBox;
        private GroupBox gaussianGroupBox;
        private PictureBox gaussianPictureBox;
        private GroupBox highThresholdGroupBox;
        private PictureBox highThresholdPictureBox;
        private GroupBox lowThresholdGroupBox;
        private PictureBox lowThresholdPictureBox;
        private Button SelectImageButton;
        private Button processImageButton;
        private GroupBox nonMaxGroupBox;
        private PictureBox nonMaxPictureBox;
        private GroupBox finalGroupBox;
        private PictureBox finalPictureBox;
        private GroupBox sobelGroupBox;
        private PictureBox sobelPictureBox;
        private TextBox highThresholdTextBox;
        private Label label1;
        private Label label2;
        private TextBox lowThresholdTextBox;
        private Label label3;
        private TextBox threadsTextBox;
        private Label label4;
        private Label completionTimeLabel;
    }
}