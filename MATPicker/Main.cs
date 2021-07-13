using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MATPicker
{
    public partial class Main : Form
    {
        private string openedFile;
        private string exportFolder;
        private string modFolder;
        private string baseFolder;

        public Main()
        {
            InitializeComponent();
        }

        //Button click events

        private void btnOpenModFolder_Click(object sender, EventArgs e)
        {

        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {

        }

        private void btnOpenBaseFolder_Click(object sender, EventArgs e)
        {

        }

        private void btnOpenExportFolder_Click(object sender, EventArgs e)
        {

        }

        private void btnPickFiles_Click(object sender, EventArgs e)
        {

        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            txtLog.Clear();
        } 
    }
}
