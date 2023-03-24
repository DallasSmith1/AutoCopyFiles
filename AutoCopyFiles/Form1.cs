namespace AutoCopyFiles
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            string path = GetDirectoriesPath();
            if (!File.Exists(path))
            {
                Editor editor = new Editor();
                editor.ShowDialog();
                GetDirectories();
            }
            else
            {
                GetDirectories();
            }
            timer1.Enabled = true;

            if (tbxCopyFrom.Text == "" && tbxSaveTo.Text == "")
            {
                lblStarting.Text = "No directories saved, exiting in:";
            }
        }

        /// <summary>
        /// Cancels the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Edits the directories and opens edit window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            GetDirectories();
            string path = GetDirectoriesPath();
            string[] directories = System.IO.File.ReadAllLines(path);
            Editor editor = new Editor(tbxCopyFrom.Text, tbxSaveTo.Text, Int32.Parse(directories[2]));
            editor.ShowDialog();
            GetDirectories();
            timer1.Enabled = true;
        }

        /// <summary>
        /// Gets the directories from the SavedDirectories.txt file and inputs them into the corresponding text boxes
        /// </summary>
        public void GetDirectories()
        {
            string path = GetDirectoriesPath();
            string[] directories = System.IO.File.ReadAllLines(path);
            if (directories[0] != "")
            {
                if (!Directory.Exists(directories[0]) || !Directory.Exists(directories[1]))
                {
                    Editor editor = new Editor(tbxCopyFrom.Text, tbxSaveTo.Text);
                    editor.ShowDialog();
                    GetDirectories();
                }
                else
                {
                    tbxCopyFrom.Text = directories[0];
                    tbxSaveTo.Text = directories[1];
                    lblStarting.Text = "AutoCopy Starting in:";
                }
            }
            else
            {
                tbxCopyFrom.Text = directories[0];
                tbxSaveTo.Text = directories[1];
                lblStarting.Text = "No directories saved, exiting in:";
            }
        }

        /// <summary>
        /// Timer for the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Time_Tick(object sender, EventArgs e)
        {
            int time = Int32.Parse(lblTimer.Text);
            time--;
            lblTimer.Text = time.ToString();

            if (time == 0 && lblStarting.Text == "No directories saved, exiting in:")
            {
                Application.Exit();
            }
            else if (time == 0)
            {
                Copy copy = new Copy();
                timer1.Enabled = false;
                copy.Show();
                this.Hide();
            }
        }

        /// <summary>
        /// starts the copying bypassing the timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            Copy copy = new Copy();
            timer1.Enabled = false;
            copy.Show();
            this.Hide();
        }

        /// <summary>
        /// gets the rootpath to the saved directories file
        /// </summary>
        /// <returns></returns>
        private string GetDirectoriesPath()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string retval = Directory.GetParent(workingDirectory).Parent.Parent.FullName + "/SavedDirectories.txt";
            return retval;
        }
    }
}