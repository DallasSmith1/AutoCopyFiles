namespace AutoCopyFiles
{
    partial class Copy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Copy));
            this.pbxFinding = new System.Windows.Forms.PictureBox();
            this.pbxSaving = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.progressbar = new System.Windows.Forms.ProgressBar();
            this.lblCopiedFiles = new System.Windows.Forms.Label();
            this.pbxComplete = new System.Windows.Forms.PictureBox();
            this.pbxWarning = new System.Windows.Forms.PictureBox();
            this.lblFailedFiles = new System.Windows.Forms.Label();
            this.lbxFailedFiles = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblRetry = new System.Windows.Forms.Label();
            this.lblRetryTimer = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSaving)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxComplete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWarning)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxFinding
            // 
            this.pbxFinding.Image = global::AutoCopyFiles.Properties.Resources.finding;
            this.pbxFinding.Location = new System.Drawing.Point(12, 12);
            this.pbxFinding.Name = "pbxFinding";
            this.pbxFinding.Size = new System.Drawing.Size(217, 145);
            this.pbxFinding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFinding.TabIndex = 0;
            this.pbxFinding.TabStop = false;
            this.pbxFinding.Visible = false;
            // 
            // pbxSaving
            // 
            this.pbxSaving.Image = global::AutoCopyFiles.Properties.Resources.saving;
            this.pbxSaving.Location = new System.Drawing.Point(12, 12);
            this.pbxSaving.Name = "pbxSaving";
            this.pbxSaving.Size = new System.Drawing.Size(217, 145);
            this.pbxSaving.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSaving.TabIndex = 2;
            this.pbxSaving.TabStop = false;
            this.pbxSaving.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 25.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(235, 12);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(242, 207);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Reading Files";
            // 
            // progressbar
            // 
            this.progressbar.Location = new System.Drawing.Point(24, 238);
            this.progressbar.Name = "progressbar";
            this.progressbar.Size = new System.Drawing.Size(440, 27);
            this.progressbar.Step = 1;
            this.progressbar.TabIndex = 4;
            this.progressbar.Visible = false;
            // 
            // lblCopiedFiles
            // 
            this.lblCopiedFiles.AutoSize = true;
            this.lblCopiedFiles.Location = new System.Drawing.Point(24, 220);
            this.lblCopiedFiles.Name = "lblCopiedFiles";
            this.lblCopiedFiles.Size = new System.Drawing.Size(13, 15);
            this.lblCopiedFiles.TabIndex = 7;
            this.lblCopiedFiles.Text = "0";
            this.lblCopiedFiles.Visible = false;
            // 
            // pbxComplete
            // 
            this.pbxComplete.Image = global::AutoCopyFiles.Properties.Resources.green_tick_png_green_tick_icon_image_4113251;
            this.pbxComplete.Location = new System.Drawing.Point(69, 12);
            this.pbxComplete.Name = "pbxComplete";
            this.pbxComplete.Size = new System.Drawing.Size(160, 145);
            this.pbxComplete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxComplete.TabIndex = 9;
            this.pbxComplete.TabStop = false;
            this.pbxComplete.Visible = false;
            // 
            // pbxWarning
            // 
            this.pbxWarning.Image = global::AutoCopyFiles.Properties.Resources.warning;
            this.pbxWarning.Location = new System.Drawing.Point(69, 12);
            this.pbxWarning.Name = "pbxWarning";
            this.pbxWarning.Size = new System.Drawing.Size(160, 145);
            this.pbxWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxWarning.TabIndex = 11;
            this.pbxWarning.TabStop = false;
            this.pbxWarning.Visible = false;
            // 
            // lblFailedFiles
            // 
            this.lblFailedFiles.AutoSize = true;
            this.lblFailedFiles.Location = new System.Drawing.Point(178, 178);
            this.lblFailedFiles.Name = "lblFailedFiles";
            this.lblFailedFiles.Size = new System.Drawing.Size(109, 15);
            this.lblFailedFiles.TabIndex = 12;
            this.lblFailedFiles.Text = "Files Failed to Copy";
            this.lblFailedFiles.Visible = false;
            // 
            // lbxFailedFiles
            // 
            this.lbxFailedFiles.FormattingEnabled = true;
            this.lbxFailedFiles.ItemHeight = 15;
            this.lbxFailedFiles.Location = new System.Drawing.Point(52, 196);
            this.lbxFailedFiles.Name = "lbxFailedFiles";
            this.lbxFailedFiles.Size = new System.Drawing.Size(398, 124);
            this.lbxFailedFiles.TabIndex = 14;
            this.toolTip1.SetToolTip(this.lbxFailedFiles, "Lists all directories to files that failed to be copied");
            this.lbxFailedFiles.Visible = false;
            this.lbxFailedFiles.SelectedIndexChanged += new System.EventHandler(this.lbxFailedFiles_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(164, 351);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 46);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "&Cancel";
            this.toolTip1.SetToolTip(this.btnClose, "Exits program");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // lblRetry
            // 
            this.lblRetry.AutoSize = true;
            this.lblRetry.Location = new System.Drawing.Point(212, 291);
            this.lblRetry.Name = "lblRetry";
            this.lblRetry.Size = new System.Drawing.Size(60, 15);
            this.lblRetry.TabIndex = 16;
            this.lblRetry.Text = "Retrying...";
            this.lblRetry.Visible = false;
            // 
            // lblRetryTimer
            // 
            this.lblRetryTimer.AutoSize = true;
            this.lblRetryTimer.Location = new System.Drawing.Point(178, 323);
            this.lblRetryTimer.Name = "lblRetryTimer";
            this.lblRetryTimer.Size = new System.Drawing.Size(136, 15);
            this.lblRetryTimer.TabIndex = 17;
            this.lblRetryTimer.Text = "Moving on in 0 minutes.";
            this.lblRetryTimer.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Copy
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(489, 408);
            this.ControlBox = false;
            this.Controls.Add(this.lblRetryTimer);
            this.Controls.Add(this.lblRetry);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbxFailedFiles);
            this.Controls.Add(this.lblFailedFiles);
            this.Controls.Add(this.pbxWarning);
            this.Controls.Add(this.pbxComplete);
            this.Controls.Add(this.lblCopiedFiles);
            this.Controls.Add(this.progressbar);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pbxSaving);
            this.Controls.Add(this.pbxFinding);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1007, 789);
            this.Name = "Copy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Copy";
            ((System.ComponentModel.ISupportInitialize)(this.pbxFinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSaving)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxComplete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWarning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbxFinding;
        private PictureBox pbxSaving;
        private Label lblStatus;
        private ProgressBar progressbar;
        private Label lblCopiedFiles;
        private PictureBox pbxComplete;
        private PictureBox pbxWarning;
        private Label lblFailedFiles;
        private ListBox lbxFailedFiles;
        private Button btnClose;
        private System.Windows.Forms.Timer timer1;
        private Label lblRetry;
        private Label lblRetryTimer;
        private ToolTip toolTip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}