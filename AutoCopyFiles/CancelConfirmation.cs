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
    public partial class CancelConfirmation : Form
    {
        public CancelConfirmation()
        {
            InitializeComponent();
        }

        /// <summary>
        /// closes application
        /// if delete files is checked it will delete all files already copied then closes application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYes_Click(object sender, EventArgs e)
        {
            if (cbxDelete.Checked)
            {
                Directory.Delete(Files.GetNewLocation(), true);
                Application.Exit();
            }
            else
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// closes window and continues copying
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
