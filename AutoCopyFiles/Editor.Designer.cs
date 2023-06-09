﻿namespace AutoCopyFiles
{
    partial class Editor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.tbxCopy = new System.Windows.Forms.TextBox();
            this.tbxSaveto = new System.Windows.Forms.TextBox();
            this.lblCopy = new System.Windows.Forms.Label();
            this.lblSaveTo = new System.Windows.Forms.Label();
            this.btnOpenCopy = new System.Windows.Forms.Button();
            this.btnOpenSaveto = new System.Windows.Forms.Button();
            this.btnSaveandCopy = new System.Windows.Forms.Button();
            this.btnSaveandExit = new System.Windows.Forms.Button();
            this.lblRetryTimer = new System.Windows.Forms.Label();
            this.nudRetryTimer = new System.Windows.Forms.NumericUpDown();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnHelp = new System.Windows.Forms.Button();
            this.cbxEnabled = new System.Windows.Forms.ComboBox();
            this.btnSetTask = new System.Windows.Forms.Button();
            this.lblEnabled = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudRetryTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxCopy
            // 
            this.tbxCopy.Location = new System.Drawing.Point(73, 6);
            this.tbxCopy.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbxCopy.Name = "tbxCopy";
            this.tbxCopy.Size = new System.Drawing.Size(390, 23);
            this.tbxCopy.TabIndex = 1;
            this.toolTip1.SetToolTip(this.tbxCopy, "The directory to the folder that you would like to copy");
            this.tbxCopy.TextChanged += new System.EventHandler(this.tbxCopy_TextChange);
            // 
            // tbxSaveto
            // 
            this.tbxSaveto.Location = new System.Drawing.Point(73, 36);
            this.tbxSaveto.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbxSaveto.Name = "tbxSaveto";
            this.tbxSaveto.Size = new System.Drawing.Size(390, 23);
            this.tbxSaveto.TabIndex = 3;
            this.toolTip1.SetToolTip(this.tbxSaveto, "Directory to a folder where you want to save the files to");
            this.tbxSaveto.TextChanged += new System.EventHandler(this.tbxSaveto_TextChange);
            // 
            // lblCopy
            // 
            this.lblCopy.AutoSize = true;
            this.lblCopy.Location = new System.Drawing.Point(27, 7);
            this.lblCopy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCopy.Name = "lblCopy";
            this.lblCopy.Size = new System.Drawing.Size(38, 15);
            this.lblCopy.TabIndex = 0;
            this.lblCopy.Text = "Copy:";
            // 
            // lblSaveTo
            // 
            this.lblSaveTo.AutoSize = true;
            this.lblSaveTo.Location = new System.Drawing.Point(15, 38);
            this.lblSaveTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaveTo.Name = "lblSaveTo";
            this.lblSaveTo.Size = new System.Drawing.Size(48, 15);
            this.lblSaveTo.TabIndex = 0;
            this.lblSaveTo.Text = "Save to:";
            // 
            // btnOpenCopy
            // 
            this.btnOpenCopy.Location = new System.Drawing.Point(464, 6);
            this.btnOpenCopy.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnOpenCopy.Name = "btnOpenCopy";
            this.btnOpenCopy.Size = new System.Drawing.Size(47, 23);
            this.btnOpenCopy.TabIndex = 2;
            this.btnOpenCopy.Text = "&Open";
            this.toolTip1.SetToolTip(this.btnOpenCopy, "Opens File explorer to choose a directory to copy from");
            this.btnOpenCopy.UseVisualStyleBackColor = true;
            this.btnOpenCopy.Click += new System.EventHandler(this.btnOpenCopy_Click);
            // 
            // btnOpenSaveto
            // 
            this.btnOpenSaveto.Location = new System.Drawing.Point(464, 36);
            this.btnOpenSaveto.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnOpenSaveto.Name = "btnOpenSaveto";
            this.btnOpenSaveto.Size = new System.Drawing.Size(47, 23);
            this.btnOpenSaveto.TabIndex = 4;
            this.btnOpenSaveto.Text = "O&pen";
            this.toolTip1.SetToolTip(this.btnOpenSaveto, "Opens file explorere to allow you to choose a folder to save to");
            this.btnOpenSaveto.UseVisualStyleBackColor = true;
            this.btnOpenSaveto.Click += new System.EventHandler(this.btnOpenSaveto_Click);
            // 
            // btnSaveandCopy
            // 
            this.btnSaveandCopy.Location = new System.Drawing.Point(390, 153);
            this.btnSaveandCopy.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnSaveandCopy.Name = "btnSaveandCopy";
            this.btnSaveandCopy.Size = new System.Drawing.Size(114, 22);
            this.btnSaveandCopy.TabIndex = 10;
            this.btnSaveandCopy.Text = "Save and &Copy";
            this.toolTip1.SetToolTip(this.btnSaveandCopy, "save directories and continue with file copy");
            this.btnSaveandCopy.UseVisualStyleBackColor = true;
            this.btnSaveandCopy.Click += new System.EventHandler(this.btnSaveandCopy_Click);
            // 
            // btnSaveandExit
            // 
            this.btnSaveandExit.Location = new System.Drawing.Point(229, 153);
            this.btnSaveandExit.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnSaveandExit.Name = "btnSaveandExit";
            this.btnSaveandExit.Size = new System.Drawing.Size(114, 22);
            this.btnSaveandExit.TabIndex = 9;
            this.btnSaveandExit.Text = "Save and E&xit";
            this.toolTip1.SetToolTip(this.btnSaveandExit, "Save directories and exit program");
            this.btnSaveandExit.UseVisualStyleBackColor = true;
            this.btnSaveandExit.Click += new System.EventHandler(this.btnSaveandExit_Click);
            // 
            // lblRetryTimer
            // 
            this.lblRetryTimer.AutoSize = true;
            this.lblRetryTimer.Location = new System.Drawing.Point(347, 83);
            this.lblRetryTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRetryTimer.Name = "lblRetryTimer";
            this.lblRetryTimer.Size = new System.Drawing.Size(67, 15);
            this.lblRetryTimer.TabIndex = 0;
            this.lblRetryTimer.Text = "Retry Timer";
            // 
            // nudRetryTimer
            // 
            this.nudRetryTimer.Location = new System.Drawing.Point(341, 106);
            this.nudRetryTimer.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.nudRetryTimer.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudRetryTimer.Name = "nudRetryTimer";
            this.nudRetryTimer.ReadOnly = true;
            this.nudRetryTimer.Size = new System.Drawing.Size(39, 23);
            this.nudRetryTimer.TabIndex = 8;
            this.toolTip1.SetToolTip(this.nudRetryTimer, "The number of minutes the program will take to attempt to copy a file that previo" +
        "usly failed");
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(383, 108);
            this.lblMinutes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(50, 15);
            this.lblMinutes.TabIndex = 0;
            this.lblMinutes.Text = "Minutes";
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(247, 103);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(54, 22);
            this.btnHelp.TabIndex = 7;
            this.btnHelp.Text = "&Help";
            this.toolTip1.SetToolTip(this.btnHelp, "Displays info about all features on this page as well as helpful tips");
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // cbxEnabled
            // 
            this.cbxEnabled.FormattingEnabled = true;
            this.cbxEnabled.Items.AddRange(new object[] {
            "Disabled",
            "Enabled"});
            this.cbxEnabled.Location = new System.Drawing.Point(73, 106);
            this.cbxEnabled.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cbxEnabled.Name = "cbxEnabled";
            this.cbxEnabled.Size = new System.Drawing.Size(132, 23);
            this.cbxEnabled.TabIndex = 5;
            this.toolTip1.SetToolTip(this.cbxEnabled, "Enables or Disables the Autosave feature");
            this.cbxEnabled.SelectedIndexChanged += new System.EventHandler(this.cbxEnabled_SelectedIndexChanged);
            // 
            // btnSetTask
            // 
            this.btnSetTask.Location = new System.Drawing.Point(96, 138);
            this.btnSetTask.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnSetTask.Name = "btnSetTask";
            this.btnSetTask.Size = new System.Drawing.Size(86, 42);
            this.btnSetTask.TabIndex = 6;
            this.btnSetTask.Text = "Create Task Schedule";
            this.toolTip1.SetToolTip(this.btnSetTask, "Takes you to a form to create a scheduled time to run the program.");
            this.btnSetTask.UseVisualStyleBackColor = true;
            this.btnSetTask.Click += new System.EventHandler(this.btnSetTask_Click);
            // 
            // lblEnabled
            // 
            this.lblEnabled.AutoSize = true;
            this.lblEnabled.Location = new System.Drawing.Point(85, 83);
            this.lblEnabled.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnabled.Name = "lblEnabled";
            this.lblEnabled.Size = new System.Drawing.Size(98, 15);
            this.lblEnabled.TabIndex = 10;
            this.lblEnabled.Text = "Autosave Feature";
            // 
            // Editor
            // 
            this.AcceptButton = this.btnSaveandCopy;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSaveandExit;
            this.ClientSize = new System.Drawing.Size(517, 190);
            this.ControlBox = false;
            this.Controls.Add(this.btnSetTask);
            this.Controls.Add(this.lblEnabled);
            this.Controls.Add(this.cbxEnabled);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.nudRetryTimer);
            this.Controls.Add(this.lblRetryTimer);
            this.Controls.Add(this.btnSaveandCopy);
            this.Controls.Add(this.btnSaveandExit);
            this.Controls.Add(this.btnOpenSaveto);
            this.Controls.Add(this.btnOpenCopy);
            this.Controls.Add(this.lblSaveTo);
            this.Controls.Add(this.lblCopy);
            this.Controls.Add(this.tbxSaveto);
            this.Controls.Add(this.tbxCopy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor";
            ((System.ComponentModel.ISupportInitialize)(this.nudRetryTimer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbxCopy;
        private TextBox tbxSaveto;
        private Label lblCopy;
        private Label lblSaveTo;
        private Button btnOpenCopy;
        private Button btnOpenSaveto;
        private Button btnSaveandCopy;
        private Button btnSaveandExit;
        private Label lblRetryTimer;
        private NumericUpDown nudRetryTimer;
        private Label lblMinutes;
        private ToolTip toolTip1;
        private Button btnHelp;
        private ComboBox cbxEnabled;
        private Label lblEnabled;
        private Button btnSetTask;
    }
}