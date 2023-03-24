using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Win32.TaskScheduler;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AutoCopyFiles
{
    public partial class NewTask : Form
    {
        public NewTask()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string start_time;
            if (nudMinute.Value < 10)
            {
                start_time = nudHour.Value.ToString()+":0"+nudMinute.Value.ToString()+":00";
            }
            else
            {
                start_time = nudHour.Value.ToString() + ":" + nudMinute.Value.ToString() + ":00";
            }


            string start_date = Calander.SelectionStart.ToShortDateString()+" "+start_time;
            using (TaskService ts = new TaskService())
            { 
                if(cbxInterval.SelectedItem != null)
                {
                    // Create a new task definition and assign properties
                    TaskDefinition td = ts.NewTask();
                    if (ts.RootFolder.AllTasks.Any(t => t.Name == "AutoCopy-Run"))
                    {
                        ts.RootFolder.DeleteTask("AutoCopy-Run");
                    }
                    td.RegistrationInfo.Description = "Runs the Autocopy Program";
                    if (cbxInterval.SelectedItem == "Day")
                    {
                        // Create a trigger that will fire the task at this time every day
                        td.Triggers.Add(new DailyTrigger() { StartBoundary = Convert.ToDateTime(start_date)});
                    }
                    else if(cbxInterval.SelectedItem == "Week")
                    {
                        td.Triggers.Add(new WeeklyTrigger() { StartBoundary = Convert.ToDateTime(start_date) });
                    }
                    else
                    {
                        td.Triggers.Add(new MonthlyTrigger() { StartBoundary = Convert.ToDateTime(start_date) });
                    }

                    string workingDirectory = Environment.CurrentDirectory;

                    // Create an action that will launch Notepad whenever the trigger fires
                    td.Actions.Add(new ExecAction(Directory.GetParent(workingDirectory).Parent.Parent.FullName + @"\bin\Release\net6.0-windows\AutoCopyFiles.exe"));
                    td.RegistrationInfo.Author = "AutoCopy";
                    // Register the task in the root folder
                    ts.RootFolder.RegisterTaskDefinition(@"AutoCopy-Run", td);

                    this.Close();

                }
            }
        }
    }
}
