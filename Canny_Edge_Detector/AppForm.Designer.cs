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
            this.gradientPictureBox = new System.Windows.Forms.PictureBox();
            this.highThresholdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lowThresholdTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.threadsTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.completionTimeLabel = new System.Windows.Forms.Label();
            this.gaussianTimeLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.filtersTimeLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gradientTimeLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nonMaxTimeLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.doubleTTimeLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.hysterisisTimeLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.normalizeTimeLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.useAssembly = new System.Windows.Forms.CheckBox();
            this.autoThreshold = new System.Windows.Forms.CheckBox();
            this.multipleProcessButton = new System.Windows.Forms.Button();
            this.avgDllTimeLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.timesExecutedLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.gradientPictureBox)).BeginInit();
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
            this.processImageButton.Click += new System.EventHandler(this.ProcessImageButton_Click);
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
            this.sobelGroupBox.Controls.Add(this.gradientPictureBox);
            this.sobelGroupBox.Location = new System.Drawing.Point(560, 12);
            this.sobelGroupBox.Name = "sobelGroupBox";
            this.sobelGroupBox.Size = new System.Drawing.Size(268, 284);
            this.sobelGroupBox.TabIndex = 3;
            this.sobelGroupBox.TabStop = false;
            this.sobelGroupBox.Text = "Gradient of the Image";
            // 
            // gradientPictureBox
            // 
            this.gradientPictureBox.Location = new System.Drawing.Point(6, 22);
            this.gradientPictureBox.Name = "gradientPictureBox";
            this.gradientPictureBox.Size = new System.Drawing.Size(256, 256);
            this.gradientPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gradientPictureBox.TabIndex = 0;
            this.gradientPictureBox.TabStop = false;
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
            this.label4.Location = new System.Drawing.Point(1060, 615);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Completion Time";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // completionTimeLabel
            // 
            this.completionTimeLabel.AutoSize = true;
            this.completionTimeLabel.Location = new System.Drawing.Point(1176, 615);
            this.completionTimeLabel.Name = "completionTimeLabel";
            this.completionTimeLabel.Size = new System.Drawing.Size(70, 15);
            this.completionTimeLabel.TabIndex = 14;
            this.completionTimeLabel.Text = "Miliseconds";
            // 
            // gaussianTimeLabel
            // 
            this.gaussianTimeLabel.AutoSize = true;
            this.gaussianTimeLabel.Location = new System.Drawing.Point(772, 586);
            this.gaussianTimeLabel.Name = "gaussianTimeLabel";
            this.gaussianTimeLabel.Size = new System.Drawing.Size(70, 15);
            this.gaussianTimeLabel.TabIndex = 16;
            this.gaussianTimeLabel.Text = "Miliseconds";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(681, 586);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Gaussian Time";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // filtersTimeLabel
            // 
            this.filtersTimeLabel.AutoSize = true;
            this.filtersTimeLabel.Location = new System.Drawing.Point(772, 615);
            this.filtersTimeLabel.Name = "filtersTimeLabel";
            this.filtersTimeLabel.Size = new System.Drawing.Size(70, 15);
            this.filtersTimeLabel.TabIndex = 18;
            this.filtersTimeLabel.Text = "Miliseconds";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(681, 615);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Filters Time";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradientTimeLabel
            // 
            this.gradientTimeLabel.AutoSize = true;
            this.gradientTimeLabel.Location = new System.Drawing.Point(772, 644);
            this.gradientTimeLabel.Name = "gradientTimeLabel";
            this.gradientTimeLabel.Size = new System.Drawing.Size(70, 15);
            this.gradientTimeLabel.TabIndex = 20;
            this.gradientTimeLabel.Text = "Miliseconds";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(683, 645);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Gradient Time";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nonMaxTimeLabel
            // 
            this.nonMaxTimeLabel.AutoSize = true;
            this.nonMaxTimeLabel.Location = new System.Drawing.Point(965, 586);
            this.nonMaxTimeLabel.Name = "nonMaxTimeLabel";
            this.nonMaxTimeLabel.Size = new System.Drawing.Size(70, 15);
            this.nonMaxTimeLabel.TabIndex = 22;
            this.nonMaxTimeLabel.Text = "Miliseconds";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(877, 586);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "NonMax Time";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // doubleTTimeLabel
            // 
            this.doubleTTimeLabel.AutoSize = true;
            this.doubleTTimeLabel.Location = new System.Drawing.Point(965, 615);
            this.doubleTTimeLabel.Name = "doubleTTimeLabel";
            this.doubleTTimeLabel.Size = new System.Drawing.Size(70, 15);
            this.doubleTTimeLabel.TabIndex = 24;
            this.doubleTTimeLabel.Text = "Miliseconds";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(877, 615);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "DoubleT Time";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hysterisisTimeLabel
            // 
            this.hysterisisTimeLabel.AutoSize = true;
            this.hysterisisTimeLabel.Location = new System.Drawing.Point(965, 645);
            this.hysterisisTimeLabel.Name = "hysterisisTimeLabel";
            this.hysterisisTimeLabel.Size = new System.Drawing.Size(70, 15);
            this.hysterisisTimeLabel.TabIndex = 26;
            this.hysterisisTimeLabel.Text = "Miliseconds";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(877, 645);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 15);
            this.label11.TabIndex = 25;
            this.label11.Text = "Hysterisis Time";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // normalizeTimeLabel
            // 
            this.normalizeTimeLabel.AutoSize = true;
            this.normalizeTimeLabel.Location = new System.Drawing.Point(1176, 586);
            this.normalizeTimeLabel.Name = "normalizeTimeLabel";
            this.normalizeTimeLabel.Size = new System.Drawing.Size(70, 15);
            this.normalizeTimeLabel.TabIndex = 28;
            this.normalizeTimeLabel.Text = "Miliseconds";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1060, 586);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 15);
            this.label12.TabIndex = 27;
            this.label12.Text = "Normalize Time";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(570, 581);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 25);
            this.saveButton.TabIndex = 29;
            this.saveButton.Text = "Save Image";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // useAssembly
            // 
            this.useAssembly.AutoSize = true;
            this.useAssembly.Checked = true;
            this.useAssembly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useAssembly.Location = new System.Drawing.Point(304, 614);
            this.useAssembly.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.useAssembly.Name = "useAssembly";
            this.useAssembly.Size = new System.Drawing.Size(130, 19);
            this.useAssembly.TabIndex = 30;
            this.useAssembly.Text = "Use Assembly Code";
            this.useAssembly.UseVisualStyleBackColor = true;
            // 
            // autoThreshold
            // 
            this.autoThreshold.AutoSize = true;
            this.autoThreshold.Location = new System.Drawing.Point(155, 614);
            this.autoThreshold.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autoThreshold.Name = "autoThreshold";
            this.autoThreshold.Size = new System.Drawing.Size(143, 19);
            this.autoThreshold.TabIndex = 31;
            this.autoThreshold.Text = "Auto Threshold Values";
            this.autoThreshold.UseVisualStyleBackColor = true;
            // 
            // multipleProcessButton
            // 
            this.multipleProcessButton.Location = new System.Drawing.Point(464, 581);
            this.multipleProcessButton.Name = "multipleProcessButton";
            this.multipleProcessButton.Size = new System.Drawing.Size(100, 25);
            this.multipleProcessButton.TabIndex = 32;
            this.multipleProcessButton.Text = "Process 100X";
            this.multipleProcessButton.UseVisualStyleBackColor = true;
            this.multipleProcessButton.Click += new System.EventHandler(this.MultipleProcessButton_Click);
            // 
            // avgDllTimeLabel
            // 
            this.avgDllTimeLabel.AutoSize = true;
            this.avgDllTimeLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.avgDllTimeLabel.Location = new System.Drawing.Point(214, 638);
            this.avgDllTimeLabel.Name = "avgDllTimeLabel";
            this.avgDllTimeLabel.Size = new System.Drawing.Size(129, 30);
            this.avgDllTimeLabel.TabIndex = 34;
            this.avgDllTimeLabel.Text = "Miliseconds";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(12, 638);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(196, 30);
            this.label13.TabIndex = 33;
            this.label13.Text = "Average DLL Time:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timesExecutedLabel
            // 
            this.timesExecutedLabel.AutoSize = true;
            this.timesExecutedLabel.Location = new System.Drawing.Point(1176, 644);
            this.timesExecutedLabel.Name = "timesExecutedLabel";
            this.timesExecutedLabel.Size = new System.Drawing.Size(13, 15);
            this.timesExecutedLabel.TabIndex = 36;
            this.timesExecutedLabel.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1060, 644);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 15);
            this.label14.TabIndex = 35;
            this.label14.Text = "Times Executed";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 677);
            this.Controls.Add(this.timesExecutedLabel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.avgDllTimeLabel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.multipleProcessButton);
            this.Controls.Add(this.autoThreshold);
            this.Controls.Add(this.useAssembly);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.normalizeTimeLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.hysterisisTimeLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.doubleTTimeLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nonMaxTimeLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gradientTimeLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.filtersTimeLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gaussianTimeLabel);
            this.Controls.Add(this.label6);
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
            ((System.ComponentModel.ISupportInitialize)(this.gradientPictureBox)).EndInit();
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