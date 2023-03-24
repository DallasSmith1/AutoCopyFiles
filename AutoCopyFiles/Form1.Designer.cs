namespace AutoCopyFiles
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblStarting = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.tbxCopyFrom = new System.Windows.Forms.TextBox();
            this.lblCopyFrom = new System.Windows.Forms.Label();
            this.lblSave = new System.Windows.Forms.Label();
            this.tbxSaveTo = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(271, 241);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 22);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "&Cancel";
            this.toolTip1.SetToolTip(this.btnCancel, "Cancel copy process");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblStarting
            // 
            this.lblStarting.AutoSize = true;
            this.lblStarting.Location = new System.Drawing.Point(199, 126);
            this.lblStarting.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStarting.Name = "lblStarting";
            this.lblStarting.Size = new System.Drawing.Size(120, 15);
            this.lblStarting.TabIndex = 0;
            this.lblStarting.Text = "AutoCopy starting in:";
            // 
            // lblTimer
            // 
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimer.Location = new System.Drawing.Point(204, 150);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(115, 74);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "60";
            // 
            // tbxCopyFrom
            // 
            this.tbxCopyFrom.Enabled = false;
            this.tbxCopyFrom.Location = new System.Drawing.Point(73, 23);
            this.tbxCopyFrom.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbxCopyFrom.Name = "tbxCopyFrom";
            this.tbxCopyFrom.Size = new System.Drawing.Size(432, 23);
            this.tbxCopyFrom.TabIndex = 0;
            this.toolTip1.SetToolTip(this.tbxCopyFrom, "Directory where the program is copying from");
            // 
            // lblCopyFrom
            // 
            this.lblCopyFrom.AutoSize = true;
            this.lblCopyFrom.Location = new System.Drawing.Point(30, 25);
            this.lblCopyFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCopyFrom.Name = "lblCopyFrom";
            this.lblCopyFrom.Size = new System.Drawing.Size(38, 15);
            this.lblCopyFrom.TabIndex = 0;
            this.lblCopyFrom.Text = "Copy:";
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.Location = new System.Drawing.Point(18, 58);
            this.lblSave.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(48, 15);
            this.lblSave.TabIndex = 0;
            this.lblSave.Text = "Save to:";
            // 
            // tbxSaveTo
            // 
            this.tbxSaveTo.Enabled = false;
            this.tbxSaveTo.Location = new System.Drawing.Point(73, 56);
            this.tbxSaveTo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbxSaveTo.Name = "tbxSaveTo";
            this.tbxSaveTo.Size = new System.Drawing.Size(432, 23);
            this.tbxSaveTo.TabIndex = 0;
            this.toolTip1.SetToolTip(this.tbxSaveTo, "Directory to the folder the program is saving the files too");
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(219, 94);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(81, 22);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "&Edit";
            this.toolTip1.SetToolTip(this.btnEdit, "Edit directories and other settings");
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Time_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(171, 241);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(81, 22);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "&Start Now";
            this.toolTip1.SetToolTip(this.btnStart, "Skip timer and start copying");
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(526, 275);
            this.ControlBox = false;
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblSave);
            this.Controls.Add(this.tbxSaveTo);
            this.Controls.Add(this.lblCopyFrom);
            this.Controls.Add(this.tbxCopyFrom);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblStarting);
            this.Controls.Add(this.btnCancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximumSize = new System.Drawing.Size(542, 314);
            this.MinimumSize = new System.Drawing.Size(542, 314);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoCopy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCancel;
        private Label lblStarting;
        private Label lblTimer;
        private TextBox tbxCopyFrom;
        private Label lblCopyFrom;
        private Label lblSave;
        private TextBox tbxSaveTo;
        private Button btnEdit;
        private System.Windows.Forms.Timer timer1;
        private Button btnStart;
        private ToolTip toolTip1;
    }
}