using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCopyFiles
{
    public partial class Copy : Form
    {
        public Copy()
        {
            InitializeComponent();
            pbxFinding.Visible = true;
            timer1.Enabled = true;
        }

        int start_timer = 1;
        int saved_timer = 0;
        bool first_step = true;
        bool complete = false;

        /// <summary>
        /// Ticks every 1 second and delays the start
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Tick(object sender, EventArgs e)
        {
           if(start_timer == 0)
           {
                timer1.Enabled = false;
                backgroundWorker1.RunWorkerAsync();
           }
           else
           {
                lblCopiedFiles.Text = Files.GetNumberOfFiles().ToString();
                start_timer--;
           }
        }

        /// <summary>
        /// gets the rootpath to the saved directory file (SavedDirectories.txt)
        /// </summary>
        /// <returns></returns>
        private string GetDirectoriesPath()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string retval = Directory.GetParent(workingDirectory).Parent.Parent.FullName + "/SavedDirectories.txt";
            return retval;
        }

        /// <summary>
        /// updates the reading file and total number of files on the reading screen
        /// </summary>
        /// <param name="file"></param>
        private void UpdateReadingScreen()
        {
            if (first_step)
            {
                lblCopiedFiles.Visible = true;
                pbxFinding.Visible = false;
                pbxFinding.Refresh();
                pbxSaving.Visible = true;
                pbxSaving.Refresh();
                lblStatus.Text = "Saving Files";
                lblStatus.Refresh();
                progressbar.Visible = true;
                progressbar.Maximum = Files.GetNumberOfFiles();
                progressbar.Refresh();
                lblCopiedFiles.Text = "0/" + Files.GetNumberOfFiles().ToString();
                lblCopiedFiles.Refresh();
                first_step = false;
            }
            string[] change = lblCopiedFiles.Text.Split("/");
            lblCopiedFiles.Text = ((Int32.Parse(change[0]) + 1) + "/" + change[1]);
            lblCopiedFiles.Refresh();
            progressbar.PerformStep();
        }

        /// <summary>
        /// Closes application at te end of program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (complete)
            {
                Application.Exit();
            }
            else
            {
                CancelConfirmation cancel = new CancelConfirmation();
                cancel.ShowDialog();
            }
        }

        /// <summary>
        /// when user selects failed file directory, it opens filedialogue to show user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbxFailedFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Failed File";
            dialog.RestoreDirectory = false;
            dialog.InitialDirectory = lbxFailedFiles.SelectedItem.ToString();
            dialog.ReadOnlyChecked = true;
            string[] selected = lbxFailedFiles.SelectedItem.ToString().Split(@"\");
            dialog.FileName = selected[(selected.Length - 1)];
            dialog.ShowDialog();
        }

        /// <summary>
        /// reads the files and saves all files and directories into a list
        /// </summary>
        private void FileReader()
        {
            // gets the root path of current files
            string path = GetDirectoriesPath();
            string[] saved_directories = System.IO.File.ReadAllLines(path);
            Files.SetCurrentLocation(saved_directories[0]);
            //creates the new saved folder
            Files.SetNewLocation(saved_directories[1] + @"\" + DateTime.UtcNow.ToString(@"dd-MM-yyyy"));
            if (!Directory.Exists(Files.GetNewLocation()))
            {
                Directory.CreateDirectory(Files.GetNewLocation());
            }
            else
            {
                bool created = false;
                int iter = 2;
                while (!created)
                {
                    if (!Directory.Exists(Files.GetNewLocation()+" ("+iter.ToString()+")"))
                    {
                        Files.SetNewLocation(Files.GetNewLocation()+ " (" + iter.ToString() + ")");
                        Directory.CreateDirectory(Files.GetNewLocation());
                        created = true;
                    }
                    else
                    {
                        iter++;
                    }
                }
            }
            saved_timer = Int32.Parse(saved_directories[2]);
            //create a list to hold all the directories in the current folder
            List<Files> copy_folders = new List<Files>();
            Files.AddFile(new Files(Files.GetCurrentLocation()));
            // add all folder directories into the list of directories and list of files
            foreach (string directory in Directory.GetDirectories(Files.GetCurrentLocation(), "*", SearchOption.AllDirectories))
            {
                Files file = new Files(directory);
                copy_folders.Add(file);
                Files.AddFile(file);
            }
            
            // updates screen
            foreach (Files file in Files.GetFiles().ToList())
            {
                // finds all files within the directories and saves them into the files list
                string[] directory_files = Directory.GetFiles(file.GetCurrentDirectory());
                foreach (string directory_file in directory_files)
                {
                    Files.AddFile(new Files(directory_file));
                }
            }

            // SAVING ============================================================

            foreach (Files file in Files.GetFiles().ToList())
            {

                bool first_attempt = true;
                bool over_ride = false;
                int retry_finish_time = 0;
                while (!file.IsCopied() && !over_ride)
                {
                    file.CopyFile();
                    if (!file.IsCopied())
                    {
                        if (first_attempt)
                        {
                            retry_finish_time = Int32.Parse(DateTime.Now.ToString("mm")) + saved_timer;
                            if (retry_finish_time > 59)
                            {
                                retry_finish_time -= 60;
                            }
                            first_attempt = false;
                        }     
                        if (retry_finish_time == Int32.Parse(DateTime.Now.ToString("mm")))
                        {
                            over_ride = true;
                        }
                    }
                }
                backgroundWorker1.ReportProgress(0);
                if (file.IsCopied() || over_ride)
                Files.RemoveFile(file);
            }
        }

        /// <summary>
        /// perfroms the entire copy process on different thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            FileReader();
        }

        /// <summary>
        /// Displays the 'complete' page with a check mark or displays all the files that failed if there are any
        /// </summary>
        private void DisplayFinish()
        {
            //COMPLETE==================================================================
            pbxSaving.Visible = false;
            pbxSaving.Refresh();
            lblCopiedFiles.Visible = false;
            lblCopiedFiles.Refresh();
            btnClose.Text = "&Close";
            btnClose.Refresh();
            complete = true;

            if (Files.GetFailedFiles().Count > 0)
            {
                progressbar.Visible = false;
                progressbar.Refresh();
                pbxWarning.Visible = true;
                pbxWarning.Refresh();
                lblStatus.Text = "Some files were not copied!";
                lblStatus.Refresh();
                lbxFailedFiles.Visible = true;
                foreach (Files file in Files.GetFailedFiles())
                {
                    lbxFailedFiles.Items.Add(file.GetCurrentDirectory());
                }
                lbxFailedFiles.Refresh();
                lblFailedFiles.Visible = true;
                lblFailedFiles.Refresh();

                string error = Files.GetNewLocation() + @"\%WARNING-FilesNotSaved%.txt";
                if (System.IO.File.Exists(error))
                {
                    System.IO.File.Delete(error);
                }
                using (StreamWriter sr = System.IO.File.CreateText(error))
                {
                    sr.WriteLine("Not all files were saved! These are the files that were not saved:");
                    sr.WriteLine("==================================================================");
                    foreach (Files file in Files.GetFailedFiles())
                    {
                        sr.WriteLine(file.GetCurrentDirectory());
                    }
                }
            }
            else
            {
                pbxComplete.Visible = true;
                pbxComplete.Refresh();
                lblStatus.Text = "Complete!";
                lblStatus.Refresh();
            }
        }

        /// <summary>
        /// progesses the progress bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            UpdateReadingScreen();
        }

        /// <summary>
        /// displays the completed page, also displays all failed files if there are any
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DisplayFinish();
        }
    }
}
