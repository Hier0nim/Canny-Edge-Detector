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
            inputGroupBox = new GroupBox();
            inputPictureBox = new PictureBox();
            gaussianGroupBox = new GroupBox();
            gaussianPictureBox = new PictureBox();
            highThresholdGroupBox = new GroupBox();
            highThresholdPictureBox = new PictureBox();
            lowThresholdGroupBox = new GroupBox();
            lowThresholdPictureBox = new PictureBox();
            SelectImageButton = new Button();
            processImageButton = new Button();
            nonMaxGroupBox = new GroupBox();
            nonMaxPictureBox = new PictureBox();
            finalGroupBox = new GroupBox();
            finalPictureBox = new PictureBox();
            sobelGroupBox = new GroupBox();
            gradientPictureBox = new PictureBox();
            highThresholdTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lowThresholdTextBox = new TextBox();
            label3 = new Label();
            threadsTextBox = new TextBox();
            label4 = new Label();
            completionTimeLabel = new Label();
            gaussianTimeLabel = new Label();
            label6 = new Label();
            filtersTimeLabel = new Label();
            label7 = new Label();
            gradientTimeLabel = new Label();
            label8 = new Label();
            nonMaxTimeLabel = new Label();
            label9 = new Label();
            doubleTTimeLabel = new Label();
            label10 = new Label();
            hysterisisTimeLabel = new Label();
            label11 = new Label();
            normalizeTimeLabel = new Label();
            label12 = new Label();
            saveButton = new Button();
            useAssembly = new CheckBox();
            autoThreshold = new CheckBox();
            multipleProcessButton = new Button();
            avgDllTimeLabel = new Label();
            label13 = new Label();
            timesExecutedLabel = new Label();
            label14 = new Label();
            inputGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inputPictureBox).BeginInit();
            gaussianGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gaussianPictureBox).BeginInit();
            highThresholdGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)highThresholdPictureBox).BeginInit();
            lowThresholdGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lowThresholdPictureBox).BeginInit();
            nonMaxGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nonMaxPictureBox).BeginInit();
            finalGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)finalPictureBox).BeginInit();
            sobelGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPictureBox).BeginInit();
            SuspendLayout();
            // 
            // inputGroupBox
            // 
            inputGroupBox.Controls.Add(inputPictureBox);
            inputGroupBox.Location = new Point(14, 16);
            inputGroupBox.Margin = new Padding(3, 4, 3, 4);
            inputGroupBox.Name = "inputGroupBox";
            inputGroupBox.Padding = new Padding(3, 4, 3, 4);
            inputGroupBox.Size = new Size(306, 379);
            inputGroupBox.TabIndex = 0;
            inputGroupBox.TabStop = false;
            inputGroupBox.Text = "Input Image";
            // 
            // inputPictureBox
            // 
            inputPictureBox.Location = new Point(7, 29);
            inputPictureBox.Margin = new Padding(3, 4, 3, 4);
            inputPictureBox.Name = "inputPictureBox";
            inputPictureBox.Size = new Size(293, 341);
            inputPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            inputPictureBox.TabIndex = 0;
            inputPictureBox.TabStop = false;
            // 
            // gaussianGroupBox
            // 
            gaussianGroupBox.Controls.Add(gaussianPictureBox);
            gaussianGroupBox.Location = new Point(327, 16);
            gaussianGroupBox.Margin = new Padding(3, 4, 3, 4);
            gaussianGroupBox.Name = "gaussianGroupBox";
            gaussianGroupBox.Padding = new Padding(3, 4, 3, 4);
            gaussianGroupBox.Size = new Size(306, 379);
            gaussianGroupBox.TabIndex = 1;
            gaussianGroupBox.TabStop = false;
            gaussianGroupBox.Text = "Gaussian Filtered Image";
            // 
            // gaussianPictureBox
            // 
            gaussianPictureBox.Location = new Point(7, 29);
            gaussianPictureBox.Margin = new Padding(3, 4, 3, 4);
            gaussianPictureBox.Name = "gaussianPictureBox";
            gaussianPictureBox.Size = new Size(293, 341);
            gaussianPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            gaussianPictureBox.TabIndex = 0;
            gaussianPictureBox.TabStop = false;
            // 
            // highThresholdGroupBox
            // 
            highThresholdGroupBox.Controls.Add(highThresholdPictureBox);
            highThresholdGroupBox.Location = new Point(327, 395);
            highThresholdGroupBox.Margin = new Padding(3, 4, 3, 4);
            highThresholdGroupBox.Name = "highThresholdGroupBox";
            highThresholdGroupBox.Padding = new Padding(3, 4, 3, 4);
            highThresholdGroupBox.Size = new Size(306, 379);
            highThresholdGroupBox.TabIndex = 2;
            highThresholdGroupBox.TabStop = false;
            highThresholdGroupBox.Text = "Strong Edges";
            // 
            // highThresholdPictureBox
            // 
            highThresholdPictureBox.Location = new Point(7, 29);
            highThresholdPictureBox.Margin = new Padding(3, 4, 3, 4);
            highThresholdPictureBox.Name = "highThresholdPictureBox";
            highThresholdPictureBox.Size = new Size(293, 341);
            highThresholdPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            highThresholdPictureBox.TabIndex = 0;
            highThresholdPictureBox.TabStop = false;
            // 
            // lowThresholdGroupBox
            // 
            lowThresholdGroupBox.Controls.Add(lowThresholdPictureBox);
            lowThresholdGroupBox.Location = new Point(640, 395);
            lowThresholdGroupBox.Margin = new Padding(3, 4, 3, 4);
            lowThresholdGroupBox.Name = "lowThresholdGroupBox";
            lowThresholdGroupBox.Padding = new Padding(3, 4, 3, 4);
            lowThresholdGroupBox.Size = new Size(306, 379);
            lowThresholdGroupBox.TabIndex = 2;
            lowThresholdGroupBox.TabStop = false;
            lowThresholdGroupBox.Text = "Weak Edges";
            // 
            // lowThresholdPictureBox
            // 
            lowThresholdPictureBox.Location = new Point(7, 29);
            lowThresholdPictureBox.Margin = new Padding(3, 4, 3, 4);
            lowThresholdPictureBox.Name = "lowThresholdPictureBox";
            lowThresholdPictureBox.Size = new Size(293, 341);
            lowThresholdPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            lowThresholdPictureBox.TabIndex = 0;
            lowThresholdPictureBox.TabStop = false;
            // 
            // SelectImageButton
            // 
            SelectImageButton.Location = new Point(288, 775);
            SelectImageButton.Margin = new Padding(3, 4, 3, 4);
            SelectImageButton.Name = "SelectImageButton";
            SelectImageButton.Size = new Size(114, 33);
            SelectImageButton.TabIndex = 4;
            SelectImageButton.Text = "Select Image";
            SelectImageButton.UseVisualStyleBackColor = true;
            SelectImageButton.Click += SelectImageButton_Click;
            // 
            // processImageButton
            // 
            processImageButton.Location = new Point(409, 775);
            processImageButton.Margin = new Padding(3, 4, 3, 4);
            processImageButton.Name = "processImageButton";
            processImageButton.Size = new Size(114, 33);
            processImageButton.TabIndex = 5;
            processImageButton.Text = "Process Image";
            processImageButton.UseVisualStyleBackColor = true;
            processImageButton.Click += ProcessImageButton_Click;
            // 
            // nonMaxGroupBox
            // 
            nonMaxGroupBox.Controls.Add(nonMaxPictureBox);
            nonMaxGroupBox.Location = new Point(14, 395);
            nonMaxGroupBox.Margin = new Padding(3, 4, 3, 4);
            nonMaxGroupBox.Name = "nonMaxGroupBox";
            nonMaxGroupBox.Padding = new Padding(3, 4, 3, 4);
            nonMaxGroupBox.Size = new Size(306, 379);
            nonMaxGroupBox.TabIndex = 3;
            nonMaxGroupBox.TabStop = false;
            nonMaxGroupBox.Text = "Non Max Suppressed Image";
            // 
            // nonMaxPictureBox
            // 
            nonMaxPictureBox.Location = new Point(7, 29);
            nonMaxPictureBox.Margin = new Padding(3, 4, 3, 4);
            nonMaxPictureBox.Name = "nonMaxPictureBox";
            nonMaxPictureBox.Size = new Size(293, 341);
            nonMaxPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            nonMaxPictureBox.TabIndex = 0;
            nonMaxPictureBox.TabStop = false;
            // 
            // finalGroupBox
            // 
            finalGroupBox.Controls.Add(finalPictureBox);
            finalGroupBox.Location = new Point(953, 16);
            finalGroupBox.Margin = new Padding(3, 4, 3, 4);
            finalGroupBox.Name = "finalGroupBox";
            finalGroupBox.Padding = new Padding(3, 4, 3, 4);
            finalGroupBox.Size = new Size(631, 757);
            finalGroupBox.TabIndex = 3;
            finalGroupBox.TabStop = false;
            finalGroupBox.Text = "Final Image";
            // 
            // finalPictureBox
            // 
            finalPictureBox.Location = new Point(0, 29);
            finalPictureBox.Margin = new Padding(3, 4, 3, 4);
            finalPictureBox.Name = "finalPictureBox";
            finalPictureBox.Size = new Size(624, 720);
            finalPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            finalPictureBox.TabIndex = 0;
            finalPictureBox.TabStop = false;
            // 
            // sobelGroupBox
            // 
            sobelGroupBox.Controls.Add(gradientPictureBox);
            sobelGroupBox.Location = new Point(640, 16);
            sobelGroupBox.Margin = new Padding(3, 4, 3, 4);
            sobelGroupBox.Name = "sobelGroupBox";
            sobelGroupBox.Padding = new Padding(3, 4, 3, 4);
            sobelGroupBox.Size = new Size(306, 379);
            sobelGroupBox.TabIndex = 3;
            sobelGroupBox.TabStop = false;
            sobelGroupBox.Text = "Gradient of the Image";
            // 
            // gradientPictureBox
            // 
            gradientPictureBox.Location = new Point(7, 29);
            gradientPictureBox.Margin = new Padding(3, 4, 3, 4);
            gradientPictureBox.Name = "gradientPictureBox";
            gradientPictureBox.Size = new Size(293, 341);
            gradientPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            gradientPictureBox.TabIndex = 0;
            gradientPictureBox.TabStop = false;
            // 
            // highThresholdTextBox
            // 
            highThresholdTextBox.Location = new Point(121, 777);
            highThresholdTextBox.Margin = new Padding(3, 4, 3, 4);
            highThresholdTextBox.Name = "highThresholdTextBox";
            highThresholdTextBox.Size = new Size(45, 27);
            highThresholdTextBox.TabIndex = 7;
            highThresholdTextBox.Text = "25";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 781);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 8;
            label1.Text = "High Threshold";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 820);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 10;
            label2.Text = "Low Threshold";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lowThresholdTextBox
            // 
            lowThresholdTextBox.Location = new Point(121, 816);
            lowThresholdTextBox.Margin = new Padding(3, 4, 3, 4);
            lowThresholdTextBox.Name = "lowThresholdTextBox";
            lowThresholdTextBox.Size = new Size(45, 27);
            lowThresholdTextBox.TabIndex = 9;
            lowThresholdTextBox.Text = "15";
            lowThresholdTextBox.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(174, 781);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 12;
            label3.Text = "Threads";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // threadsTextBox
            // 
            threadsTextBox.Location = new Point(235, 777);
            threadsTextBox.Margin = new Padding(3, 4, 3, 4);
            threadsTextBox.Name = "threadsTextBox";
            threadsTextBox.Size = new Size(45, 27);
            threadsTextBox.TabIndex = 11;
            threadsTextBox.Text = "1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1211, 820);
            label4.Name = "label4";
            label4.Size = new Size(124, 20);
            label4.TabIndex = 13;
            label4.Text = "Completion Time";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // completionTimeLabel
            // 
            completionTimeLabel.AutoSize = true;
            completionTimeLabel.Location = new Point(1344, 820);
            completionTimeLabel.Name = "completionTimeLabel";
            completionTimeLabel.Size = new Size(87, 20);
            completionTimeLabel.TabIndex = 14;
            completionTimeLabel.Text = "Miliseconds";
            // 
            // gaussianTimeLabel
            // 
            gaussianTimeLabel.AutoSize = true;
            gaussianTimeLabel.Location = new Point(882, 781);
            gaussianTimeLabel.Name = "gaussianTimeLabel";
            gaussianTimeLabel.Size = new Size(87, 20);
            gaussianTimeLabel.TabIndex = 16;
            gaussianTimeLabel.Text = "Miliseconds";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(778, 781);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 15;
            label6.Text = "Gaussian Time";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // filtersTimeLabel
            // 
            filtersTimeLabel.AutoSize = true;
            filtersTimeLabel.Location = new Point(882, 820);
            filtersTimeLabel.Name = "filtersTimeLabel";
            filtersTimeLabel.Size = new Size(87, 20);
            filtersTimeLabel.TabIndex = 18;
            filtersTimeLabel.Text = "Miliseconds";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(778, 820);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 17;
            label7.Text = "Filters Time";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gradientTimeLabel
            // 
            gradientTimeLabel.AutoSize = true;
            gradientTimeLabel.Location = new Point(882, 859);
            gradientTimeLabel.Name = "gradientTimeLabel";
            gradientTimeLabel.Size = new Size(87, 20);
            gradientTimeLabel.TabIndex = 20;
            gradientTimeLabel.Text = "Miliseconds";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(781, 860);
            label8.Name = "label8";
            label8.Size = new Size(103, 20);
            label8.TabIndex = 19;
            label8.Text = "Gradient Time";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nonMaxTimeLabel
            // 
            nonMaxTimeLabel.AutoSize = true;
            nonMaxTimeLabel.Location = new Point(1103, 781);
            nonMaxTimeLabel.Name = "nonMaxTimeLabel";
            nonMaxTimeLabel.Size = new Size(87, 20);
            nonMaxTimeLabel.TabIndex = 22;
            nonMaxTimeLabel.Text = "Miliseconds";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1002, 781);
            label9.Name = "label9";
            label9.Size = new Size(102, 20);
            label9.TabIndex = 21;
            label9.Text = "NonMax Time";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // doubleTTimeLabel
            // 
            doubleTTimeLabel.AutoSize = true;
            doubleTTimeLabel.Location = new Point(1103, 820);
            doubleTTimeLabel.Name = "doubleTTimeLabel";
            doubleTTimeLabel.Size = new Size(87, 20);
            doubleTTimeLabel.TabIndex = 24;
            doubleTTimeLabel.Text = "Miliseconds";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1002, 820);
            label10.Name = "label10";
            label10.Size = new Size(103, 20);
            label10.TabIndex = 23;
            label10.Text = "DoubleT Time";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hysterisisTimeLabel
            // 
            hysterisisTimeLabel.AutoSize = true;
            hysterisisTimeLabel.Location = new Point(1103, 860);
            hysterisisTimeLabel.Name = "hysterisisTimeLabel";
            hysterisisTimeLabel.Size = new Size(87, 20);
            hysterisisTimeLabel.TabIndex = 26;
            hysterisisTimeLabel.Text = "Miliseconds";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1002, 860);
            label11.Name = "label11";
            label11.Size = new Size(108, 20);
            label11.TabIndex = 25;
            label11.Text = "Hysterisis Time";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // normalizeTimeLabel
            // 
            normalizeTimeLabel.AutoSize = true;
            normalizeTimeLabel.Location = new Point(1344, 781);
            normalizeTimeLabel.Name = "normalizeTimeLabel";
            normalizeTimeLabel.Size = new Size(87, 20);
            normalizeTimeLabel.TabIndex = 28;
            normalizeTimeLabel.Text = "Miliseconds";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1211, 781);
            label12.Name = "label12";
            label12.Size = new Size(115, 20);
            label12.TabIndex = 27;
            label12.Text = "Normalize Time";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(651, 775);
            saveButton.Margin = new Padding(3, 4, 3, 4);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(114, 33);
            saveButton.TabIndex = 29;
            saveButton.Text = "Save Image";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += SaveButton_Click;
            // 
            // useAssembly
            // 
            useAssembly.AutoSize = true;
            useAssembly.Checked = true;
            useAssembly.CheckState = CheckState.Checked;
            useAssembly.Location = new Point(362, 818);
            useAssembly.Name = "useAssembly";
            useAssembly.Size = new Size(161, 24);
            useAssembly.TabIndex = 30;
            useAssembly.Text = "Use Assembly Code";
            useAssembly.UseVisualStyleBackColor = true;
            // 
            // autoThreshold
            // 
            autoThreshold.AutoSize = true;
            autoThreshold.Location = new Point(177, 819);
            autoThreshold.Name = "autoThreshold";
            autoThreshold.Size = new Size(178, 24);
            autoThreshold.TabIndex = 31;
            autoThreshold.Text = "Auto Threshold Values";
            autoThreshold.UseVisualStyleBackColor = true;
            // 
            // multipleProcessButton
            // 
            multipleProcessButton.Location = new Point(530, 775);
            multipleProcessButton.Margin = new Padding(3, 4, 3, 4);
            multipleProcessButton.Name = "multipleProcessButton";
            multipleProcessButton.Size = new Size(114, 33);
            multipleProcessButton.TabIndex = 32;
            multipleProcessButton.Text = "Process 10X";
            multipleProcessButton.UseVisualStyleBackColor = true;
            multipleProcessButton.Click += MultipleProcessButton_Click;
            // 
            // avgDllTimeLabel
            // 
            avgDllTimeLabel.AutoSize = true;
            avgDllTimeLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            avgDllTimeLabel.Location = new Point(245, 851);
            avgDllTimeLabel.Name = "avgDllTimeLabel";
            avgDllTimeLabel.Size = new Size(169, 37);
            avgDllTimeLabel.TabIndex = 34;
            avgDllTimeLabel.Text = "Miliseconds";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(14, 851);
            label13.Name = "label13";
            label13.Size = new Size(256, 37);
            label13.TabIndex = 33;
            label13.Text = "Average DLL Time:";
            label13.TextAlign = ContentAlignment.MiddleRight;
            // 
            // timesExecutedLabel
            // 
            timesExecutedLabel.AutoSize = true;
            timesExecutedLabel.Location = new Point(1344, 859);
            timesExecutedLabel.Name = "timesExecutedLabel";
            timesExecutedLabel.Size = new Size(17, 20);
            timesExecutedLabel.TabIndex = 36;
            timesExecutedLabel.Text = "0";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(1211, 859);
            label14.Name = "label14";
            label14.Size = new Size(112, 20);
            label14.TabIndex = 35;
            label14.Text = "Times Executed";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AppForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 903);
            Controls.Add(timesExecutedLabel);
            Controls.Add(label14);
            Controls.Add(avgDllTimeLabel);
            Controls.Add(label13);
            Controls.Add(multipleProcessButton);
            Controls.Add(autoThreshold);
            Controls.Add(useAssembly);
            Controls.Add(saveButton);
            Controls.Add(normalizeTimeLabel);
            Controls.Add(label12);
            Controls.Add(hysterisisTimeLabel);
            Controls.Add(label11);
            Controls.Add(doubleTTimeLabel);
            Controls.Add(label10);
            Controls.Add(nonMaxTimeLabel);
            Controls.Add(label9);
            Controls.Add(gradientTimeLabel);
            Controls.Add(label8);
            Controls.Add(filtersTimeLabel);
            Controls.Add(label7);
            Controls.Add(gaussianTimeLabel);
            Controls.Add(label6);
            Controls.Add(completionTimeLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(threadsTextBox);
            Controls.Add(label2);
            Controls.Add(lowThresholdTextBox);
            Controls.Add(label1);
            Controls.Add(highThresholdTextBox);
            Controls.Add(sobelGroupBox);
            Controls.Add(finalGroupBox);
            Controls.Add(nonMaxGroupBox);
            Controls.Add(processImageButton);
            Controls.Add(SelectImageButton);
            Controls.Add(lowThresholdGroupBox);
            Controls.Add(highThresholdGroupBox);
            Controls.Add(gaussianGroupBox);
            Controls.Add(inputGroupBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AppForm";
            Text = "AppForm";
            inputGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)inputPictureBox).EndInit();
            gaussianGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gaussianPictureBox).EndInit();
            highThresholdGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)highThresholdPictureBox).EndInit();
            lowThresholdGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)lowThresholdPictureBox).EndInit();
            nonMaxGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nonMaxPictureBox).EndInit();
            finalGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)finalPictureBox).EndInit();
            sobelGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gradientPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private PictureBox gradientPictureBox;
        private TextBox highThresholdTextBox;
        private Label label1;
        private Label label2;
        private TextBox lowThresholdTextBox;
        private Label label3;
        private TextBox threadsTextBox;
        private Label label4;
        private Label completionTimeLabel;
        private Label gaussianTimeLabel;
        private Label label6;
        private Label filtersTimeLabel;
        private Label label7;
        private Label gradientTimeLabel;
        private Label label8;
        private Label nonMaxTimeLabel;
        private Label label9;
        private Label doubleTTimeLabel;
        private Label label10;
        private Label hysterisisTimeLabel;
        private Label label11;
        private Label normalizeTimeLabel;
        private Label label12;
        private Button saveButton;
        private CheckBox useAssembly;
        private CheckBox autoThreshold;
        private Button multipleProcessButton;
        private Label avgDllTimeLabel;
        private Label label13;
        private Label timesExecutedLabel;
        private Label label14;
    }
}