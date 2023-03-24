namespace AutoCopyFiles
{
    partial class NewTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewTask));
            this.cbxInterval = new System.Windows.Forms.ComboBox();
            this.lblInterval = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.nudHour = new System.Windows.Forms.NumericUpDown();
            this.lblGap = new System.Windows.Forms.Label();
            this.nudMinute = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.Calander = new System.Windows.Forms.MonthCalendar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxInterval
            // 
            this.cbxInterval.FormattingEnabled = true;
            this.cbxInterval.Items.AddRange(new object[] {
            "Day",
            "Week",
            "Month"});
            this.cbxInterval.Location = new System.Drawing.Point(220, 9);
            this.cbxInterval.Name = "cbxInterval";
            this.cbxInterval.Size = new System.Drawing.Size(161, 40);
            this.cbxInterval.TabIndex = 1;
            this.toolTip1.SetToolTip(this.cbxInterval, "How often to run the program");
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(50, 12);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(138, 32);
            this.lblInterval.TabIndex = 0;
            this.lblInterval.Text = "Copy Every:";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(176, 52);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(101, 32);
            this.lblDay.TabIndex = 2;
            this.lblDay.Text = "Starting:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(94, 419);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(42, 32);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "At:";
            // 
            // nudHour
            // 
            this.nudHour.Location = new System.Drawing.Point(142, 417);
            this.nudHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudHour.Name = "nudHour";
            this.nudHour.ReadOnly = true;
            this.nudHour.Size = new System.Drawing.Size(63, 39);
            this.nudHour.TabIndex = 3;
            this.toolTip1.SetToolTip(this.nudHour, "Specific Hour to start the program");
            this.nudHour.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // lblGap
            // 
            this.lblGap.AutoSize = true;
            this.lblGap.Location = new System.Drawing.Point(211, 419);
            this.lblGap.Name = "lblGap";
            this.lblGap.Size = new System.Drawing.Size(19, 32);
            this.lblGap.TabIndex = 6;
            this.lblGap.Text = ":";
            // 
            // nudMinute
            // 
            this.nudMinute.Location = new System.Drawing.Point(236, 417);
            this.nudMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMinute.Name = "nudMinute";
            this.nudMinute.ReadOnly = true;
            this.nudMinute.Size = new System.Drawing.Size(72, 39);
            this.nudMinute.TabIndex = 4;
            this.toolTip1.SetToolTip(this.nudMinute, "Specific minute to start the program");
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(38, 472);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 46);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.toolTip1.SetToolTip(this.btnCancel, "Cancels adding a task and goes back to editor");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(247, 472);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(150, 46);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Crea&te";
            this.toolTip1.SetToolTip(this.btnCreate, "Creates the task and goes back to editor");
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // Calander
            // 
            this.Calander.Location = new System.Drawing.Point(18, 93);
            this.Calander.Name = "Calander";
            this.Calander.TabIndex = 2;
            this.toolTip1.SetToolTip(this.Calander, "Select the day you would like to start the Auto Copy Process");
            // 
            // NewTask
            // 
            this.AcceptButton = this.btnCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(438, 526);
            this.ControlBox = false;
            this.Controls.Add(this.Calander);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.nudMinute);
            this.Controls.Add(this.lblGap);
            this.Controls.Add(this.nudHour);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblInterval);
            this.Controls.Add(this.cbxInterval);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewTask";
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbxInterval;
        private Label lblInterval;
        private Label lblDay;
        private Label lblTime;
        private NumericUpDown nudHour;
        private Label lblGap;
        private NumericUpDown nudMinute;
        private Button btnCancel;
        private Button btnCreate;
        private MonthCalendar Calander;
        private ToolTip toolTip1;
    }
}