using Microsoft.Win32.TaskScheduler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCopyFiles
{
    public partial class Editor : Form
    {
        public Editor()
        {
            InitializeComponent();
        }
        public Editor(string copy, string save, int timer)
        {
            InitializeComponent();

            tbxCopy.Text = copy;
            tbxSaveto.Text = save;
            nudRetryTimer.Value = timer;
        }

        public Editor(string copy, string save)
        {
            InitializeComponent();

            tbxCopy.Text = copy;
            tbxSaveto.Text = save;
        }

        /// <summary>
        /// opens file explorer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenCopy_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                tbxCopy.Text = dialog.SelectedPath;

            }
            if (Directory.Exists(tbxCopy.Text) || tbxCopy.Text == "")
            {
                if (Directory.Exists(tbxSaveto.Text) || tbxSaveto.Text == "" && tbxCopy.Text == "")
                {
                    if (tbxSaveto.Text == "" && tbxCopy.Text == "" || tbxCopy.Text != tbxSaveto.Text)
                    {
                        btnSaveandExit.Enabled = true;
                        btnSaveandCopy.Enabled = true;
                    }
                    else
                    {
                        btnSaveandExit.Enabled = false;
                        btnSaveandCopy.Enabled = false;
                    }
                }
                else
                {
                    btnSaveandExit.Enabled = false;
                    btnSaveandCopy.Enabled = false;
                }
            }
            else
            {
                btnSaveandExit.Enabled = false;
                btnSaveandCopy.Enabled = false;
            }
        }

        /// <summary>
        /// opens file explorer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenSaveto_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                tbxSaveto.Text = dialog.SelectedPath;
            }
            if (Directory.Exists(tbxCopy.Text) || tbxCopy.Text == "")
            {
                if (Directory.Exists(tbxSaveto.Text) || tbxSaveto.Text == "" && tbxCopy.Text == "")
                {
                    if (tbxSaveto.Text == "" && tbxCopy.Text == "" || tbxCopy.Text != tbxSaveto.Text)
                    {
                        btnSaveandExit.Enabled = true;
                        btnSaveandCopy.Enabled = true;
                    }
                    else
                    {
                        btnSaveandExit.Enabled = false;
                        btnSaveandCopy.Enabled = false;
                    }
                }
                else
                {
                    btnSaveandExit.Enabled = false;
                    btnSaveandCopy.Enabled = false;
                }
            }
            else
            {
                btnSaveandExit.Enabled = false;
                btnSaveandCopy.Enabled = false;
            }
        }

        /// <summary>
        /// saes the directoris to SavedDirectories.txt then exits the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveandExit_Click(object sender, EventArgs e)
        {
            if (cbxEnabled.SelectedItem != null || cbxEnabled.SelectedItem == "Disabled")
            {
                using (TaskService ts = new TaskService())
                {
                    if (ts.RootFolder.AllTasks.Any(t => t.Name == "AutoCopy-Run"))
                    {
                        ts.RootFolder.DeleteTask("AutoCopy-Run");
                    }
                }
            }
            string path = GetDirectoriesPath();
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            using (StreamWriter sr = File.CreateText(path))
            {
                sr.WriteLine(tbxCopy.Text);
                sr.WriteLine(tbxSaveto.Text);
                sr.WriteLine(nudRetryTimer.Value);
            }

            Application.Exit();
        }

        /// <summary>
        /// WHen the text is altered it validates the directories
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxCopy_TextChange(object sender, EventArgs e)
        {
            if (Directory.Exists(tbxCopy.Text) || tbxCopy.Text == "")
            {
                if (Directory.Exists(tbxSaveto.Text) || tbxSaveto.Text == "" && tbxCopy.Text == "")
                {
                    if (tbxSaveto.Text == "" && tbxCopy.Text == "" || tbxCopy.Text != tbxSaveto.Text)
                    {
                        btnSaveandExit.Enabled = true;
                        btnSaveandCopy.Enabled = true;
                    }
                    else
                    {
                        btnSaveandExit.Enabled = false;
                        btnSaveandCopy.Enabled = false;
                    }
                }
                else
                {
                    btnSaveandExit.Enabled = false;
                    btnSaveandCopy.Enabled = false;
                }
            }
            else
            {
                btnSaveandExit.Enabled = false;
                btnSaveandCopy.Enabled = false;
            }
        }

        /// <summary>
        /// when the text is altered it validtaes the directories
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxSaveto_TextChange(object sender, EventArgs e)
        {
            if (Directory.Exists(tbxCopy.Text) || tbxCopy.Text == "")
            {
                if (Directory.Exists(tbxSaveto.Text) || tbxSaveto.Text == "" && tbxCopy.Text == "")
                {
                    if (tbxSaveto.Text == "" && tbxCopy.Text == "" || tbxCopy.Text != tbxSaveto.Text)
                    {
                        btnSaveandExit.Enabled = true;
                        btnSaveandCopy.Enabled = true;
                    }
                    else
                    {
                        btnSaveandExit.Enabled = false;
                        btnSaveandCopy.Enabled = false;
                    }
                }
                else
                {
                    btnSaveandExit.Enabled = false;
                    btnSaveandCopy.Enabled = false;
                }
            }
            else
            {
                btnSaveandExit.Enabled = false;
                btnSaveandCopy.Enabled = false;
            }
        }

        /// <summary>
        /// Saves the directories to the SavedDirectories.txt file and contknues the save timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveandCopy_Click(object sender, EventArgs e)
        {
            if (cbxEnabled.SelectedItem != null || cbxEnabled.SelectedItem == "Disabled")
            {
                using (TaskService ts = new TaskService())
                {
                    if (ts.RootFolder.AllTasks.Any(t => t.Name == "AutoCopy-Run"))
                    {
                        ts.RootFolder.DeleteTask("AutoCopy-Run");
                    }
                }
            }
            string path = GetDirectoriesPath();
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            using (StreamWriter sr = File.CreateText(path))
            {
                sr.WriteLine(tbxCopy.Text);
                sr.WriteLine(tbxSaveto.Text);
                sr.WriteLine(nudRetryTimer.Value);
            }
            this.Close();
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

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.ShowDialog();
        }

        private void cbxEnabled_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxEnabled.SelectedItem == "Disabled")
            {
                btnSetTask.Enabled = false;
            }
            else
            {
                btnSetTask.Enabled = true;
            }
        }

        private void btnSetTask_Click(object sender, EventArgs e)
        {
            NewTask newtask = new NewTask();
            newtask.ShowDialog();
        }
    }
}
