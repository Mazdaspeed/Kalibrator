namespace Kalibrator
{
    partial class MainForm
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
            this.gbCurrentMAFCalibration = new System.Windows.Forms.GroupBox();
            this.tbCurrentMAFCalibration = new System.Windows.Forms.TextBox();
            this.gbAFRTargets = new System.Windows.Forms.GroupBox();
            this.tbAFRTargets = new System.Windows.Forms.TextBox();
            this.gbOpenLoopTransition = new System.Windows.Forms.GroupBox();
            this.gbLoad = new System.Windows.Forms.GroupBox();
            this.tbLoad = new System.Windows.Forms.TextBox();
            this.gbAcceleratorPosition = new System.Windows.Forms.GroupBox();
            this.tbAcceleratorPosition = new System.Windows.Forms.TextBox();
            this.gbLogFile = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lbLogFiles = new System.Windows.Forms.ListBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.tbLogFilePath = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.gbProcessingOutput = new System.Windows.Forms.GroupBox();
            this.tbProcessingOutput = new System.Windows.Forms.TextBox();
            this.gbCurrentMAFCalibration.SuspendLayout();
            this.gbAFRTargets.SuspendLayout();
            this.gbOpenLoopTransition.SuspendLayout();
            this.gbLoad.SuspendLayout();
            this.gbAcceleratorPosition.SuspendLayout();
            this.gbLogFile.SuspendLayout();
            this.gbProcessingOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCurrentMAFCalibration
            // 
            this.gbCurrentMAFCalibration.Controls.Add(this.tbCurrentMAFCalibration);
            this.gbCurrentMAFCalibration.Location = new System.Drawing.Point(12, 12);
            this.gbCurrentMAFCalibration.Name = "gbCurrentMAFCalibration";
            this.gbCurrentMAFCalibration.Size = new System.Drawing.Size(299, 51);
            this.gbCurrentMAFCalibration.TabIndex = 0;
            this.gbCurrentMAFCalibration.TabStop = false;
            this.gbCurrentMAFCalibration.Text = "Current MAF Calibration";
            // 
            // tbCurrentMAFCalibration
            // 
            this.tbCurrentMAFCalibration.Location = new System.Drawing.Point(7, 20);
            this.tbCurrentMAFCalibration.Name = "tbCurrentMAFCalibration";
            this.tbCurrentMAFCalibration.Size = new System.Drawing.Size(286, 20);
            this.tbCurrentMAFCalibration.TabIndex = 0;
            this.tbCurrentMAFCalibration.Text = "Paste Current MAF Calibration Here";
            // 
            // gbAFRTargets
            // 
            this.gbAFRTargets.Controls.Add(this.tbAFRTargets);
            this.gbAFRTargets.Location = new System.Drawing.Point(12, 69);
            this.gbAFRTargets.Name = "gbAFRTargets";
            this.gbAFRTargets.Size = new System.Drawing.Size(299, 51);
            this.gbAFRTargets.TabIndex = 1;
            this.gbAFRTargets.TabStop = false;
            this.gbAFRTargets.Text = "WOT AFR Targets";
            // 
            // tbAFRTargets
            // 
            this.tbAFRTargets.Location = new System.Drawing.Point(7, 20);
            this.tbAFRTargets.Name = "tbAFRTargets";
            this.tbAFRTargets.Size = new System.Drawing.Size(286, 20);
            this.tbAFRTargets.TabIndex = 0;
            this.tbAFRTargets.Text = "Paste Current WOT AFR Targets Here";
            // 
            // gbOpenLoopTransition
            // 
            this.gbOpenLoopTransition.Controls.Add(this.gbLoad);
            this.gbOpenLoopTransition.Controls.Add(this.gbAcceleratorPosition);
            this.gbOpenLoopTransition.Location = new System.Drawing.Point(12, 126);
            this.gbOpenLoopTransition.Name = "gbOpenLoopTransition";
            this.gbOpenLoopTransition.Size = new System.Drawing.Size(299, 72);
            this.gbOpenLoopTransition.TabIndex = 2;
            this.gbOpenLoopTransition.TabStop = false;
            this.gbOpenLoopTransition.Text = "Open Loop Transition";
            // 
            // gbLoad
            // 
            this.gbLoad.Controls.Add(this.tbLoad);
            this.gbLoad.Location = new System.Drawing.Point(131, 19);
            this.gbLoad.Name = "gbLoad";
            this.gbLoad.Size = new System.Drawing.Size(118, 47);
            this.gbLoad.TabIndex = 2;
            this.gbLoad.TabStop = false;
            this.gbLoad.Text = "Load";
            // 
            // tbLoad
            // 
            this.tbLoad.Location = new System.Drawing.Point(9, 19);
            this.tbLoad.Name = "tbLoad";
            this.tbLoad.Size = new System.Drawing.Size(103, 20);
            this.tbLoad.TabIndex = 0;
            this.tbLoad.Text = "1.0";
            // 
            // gbAcceleratorPosition
            // 
            this.gbAcceleratorPosition.Controls.Add(this.tbAcceleratorPosition);
            this.gbAcceleratorPosition.Location = new System.Drawing.Point(7, 19);
            this.gbAcceleratorPosition.Name = "gbAcceleratorPosition";
            this.gbAcceleratorPosition.Size = new System.Drawing.Size(118, 47);
            this.gbAcceleratorPosition.TabIndex = 1;
            this.gbAcceleratorPosition.TabStop = false;
            this.gbAcceleratorPosition.Text = "Accelerator Position";
            // 
            // tbAcceleratorPosition
            // 
            this.tbAcceleratorPosition.Location = new System.Drawing.Point(9, 19);
            this.tbAcceleratorPosition.Name = "tbAcceleratorPosition";
            this.tbAcceleratorPosition.Size = new System.Drawing.Size(103, 20);
            this.tbAcceleratorPosition.TabIndex = 0;
            this.tbAcceleratorPosition.Text = "100";
            // 
            // gbLogFile
            // 
            this.gbLogFile.Controls.Add(this.btnBrowse);
            this.gbLogFile.Controls.Add(this.lbLogFiles);
            this.gbLogFile.Controls.Add(this.btnLoad);
            this.gbLogFile.Controls.Add(this.tbLogFilePath);
            this.gbLogFile.Location = new System.Drawing.Point(12, 204);
            this.gbLogFile.Name = "gbLogFile";
            this.gbLogFile.Size = new System.Drawing.Size(299, 113);
            this.gbLogFile.TabIndex = 2;
            this.gbLogFile.TabStop = false;
            this.gbLogFile.Text = "Log Files";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(191, 19);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(25, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lbLogFiles
            // 
            this.lbLogFiles.FormattingEnabled = true;
            this.lbLogFiles.Location = new System.Drawing.Point(7, 46);
            this.lbLogFiles.Name = "lbLogFiles";
            this.lbLogFiles.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbLogFiles.Size = new System.Drawing.Size(286, 56);
            this.lbLogFiles.TabIndex = 3;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(218, 19);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // tbLogFilePath
            // 
            this.tbLogFilePath.Location = new System.Drawing.Point(7, 20);
            this.tbLogFilePath.Name = "tbLogFilePath";
            this.tbLogFilePath.Size = new System.Drawing.Size(185, 20);
            this.tbLogFilePath.TabIndex = 0;
            this.tbLogFilePath.Text = "Enter log file path here";
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(12, 323);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(299, 36);
            this.btnProcess.TabIndex = 2;
            this.btnProcess.Text = "Begin Processing";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // gbProcessingOutput
            // 
            this.gbProcessingOutput.Controls.Add(this.tbProcessingOutput);
            this.gbProcessingOutput.Location = new System.Drawing.Point(12, 365);
            this.gbProcessingOutput.Name = "gbProcessingOutput";
            this.gbProcessingOutput.Size = new System.Drawing.Size(299, 51);
            this.gbProcessingOutput.TabIndex = 3;
            this.gbProcessingOutput.TabStop = false;
            this.gbProcessingOutput.Text = "Processing Output";
            // 
            // tbProcessingOutput
            // 
            this.tbProcessingOutput.Location = new System.Drawing.Point(7, 20);
            this.tbProcessingOutput.Name = "tbProcessingOutput";
            this.tbProcessingOutput.Size = new System.Drawing.Size(286, 20);
            this.tbProcessingOutput.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 425);
            this.Controls.Add(this.gbProcessingOutput);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.gbLogFile);
            this.Controls.Add(this.gbOpenLoopTransition);
            this.Controls.Add(this.gbAFRTargets);
            this.Controls.Add(this.gbCurrentMAFCalibration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Kalibrator";
            this.gbCurrentMAFCalibration.ResumeLayout(false);
            this.gbCurrentMAFCalibration.PerformLayout();
            this.gbAFRTargets.ResumeLayout(false);
            this.gbAFRTargets.PerformLayout();
            this.gbOpenLoopTransition.ResumeLayout(false);
            this.gbLoad.ResumeLayout(false);
            this.gbLoad.PerformLayout();
            this.gbAcceleratorPosition.ResumeLayout(false);
            this.gbAcceleratorPosition.PerformLayout();
            this.gbLogFile.ResumeLayout(false);
            this.gbLogFile.PerformLayout();
            this.gbProcessingOutput.ResumeLayout(false);
            this.gbProcessingOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCurrentMAFCalibration;
        private System.Windows.Forms.TextBox tbCurrentMAFCalibration;
        private System.Windows.Forms.GroupBox gbAFRTargets;
        private System.Windows.Forms.TextBox tbAFRTargets;
        private System.Windows.Forms.GroupBox gbOpenLoopTransition;
        private System.Windows.Forms.GroupBox gbLoad;
        private System.Windows.Forms.TextBox tbLoad;
        private System.Windows.Forms.GroupBox gbAcceleratorPosition;
        private System.Windows.Forms.TextBox tbAcceleratorPosition;
        private System.Windows.Forms.GroupBox gbLogFile;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox tbLogFilePath;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.ListBox lbLogFiles;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.GroupBox gbProcessingOutput;
        private System.Windows.Forms.TextBox tbProcessingOutput;
    }
}

