using System;
using System.IO;
using System.Windows.Forms;

namespace MATPicker
{
    public partial class Main : Form
    {
        private string pmdFilterString = "PMD Files (*.pmd)|*.pmd";


        public Main()
        {
            InitializeComponent();
        }

        //Button click events

        private void btnOpenModFolder_Click(object sender, EventArgs e)
        {
            if (fbdModFolder.ShowDialog() == DialogResult.OK)
            {
                txtModFolder.Text = fbdModFolder.SelectedPath;
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (rdoSinglePMD.Checked)
            {
                ofdPMDFile.Filter = pmdFilterString;
                if (ofdPMDFile.ShowDialog() == DialogResult.OK)
                {
                    txtOpenedFiles.Text = ofdPMDFile.FileName;
                }
            }
            else if (fbdFolder.ShowDialog() == DialogResult.OK)
            {
                txtOpenedFiles.Text = fbdFolder.SelectedPath;
            }
        }

        private void btnOpenBaseFolder_Click(object sender, EventArgs e)
        {
            if (fbdBaseFolder.ShowDialog() == DialogResult.OK)
            {
                txtBaseFolder.Text = fbdBaseFolder.SelectedPath;
            }
        }

        private void btnOpenExportFolder_Click(object sender, EventArgs e)
        {
            if (fbdExportFolder.ShowDialog() == DialogResult.OK)
            {
                txtExportFolder.Text = fbdExportFolder.SelectedPath;
            }
        }

        private void btnPickFiles_Click(object sender, EventArgs e)
        {

        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            txtLog.Clear();
        }

        // Drag and Drop Mode

        private void updateFilePathInTextBox(DragEventArgs e, TextBox txt, bool singleFile)
        {
            string[] droppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (singleFile && Path.GetExtension(droppedFiles[0]).Equals(".pmd") || !singleFile && Directory.Exists(droppedFiles[0]))
            {
                txt.Text = droppedFiles[0];
            }
        }

        private void txtModFolder_DragEnter(object sender, DragEventArgs e)
        {
            txtModFolder_DragDrop(sender, e);
        }

        private void txtModFolder_DragDrop(object sender, DragEventArgs e)
        {
            updateFilePathInTextBox(e, txtModFolder, false);
        }

        private void txtOpenedFiles_DragEnter(object sender, DragEventArgs e)
        {
            txtOpenedFiles_DragDrop(sender, e);
        }

        private void txtOpenedFiles_DragDrop(object sender, DragEventArgs e)
        {
          updateFilePathInTextBox(e, txtOpenedFiles, rdoSinglePMD.Checked);  
        }

        private void txtBaseFolder_DragEnter(object sender, DragEventArgs e)
        {
            txtBaseFolder_DragDrop(sender, e);
        }

        private void txtBaseFolder_DragDrop(object sender, DragEventArgs e)
        {
            updateFilePathInTextBox(e, txtBaseFolder, false);
        }

        private void txtExportFolder_DragEnter(object sender, DragEventArgs e)
        {
            txtExportFolder_DragDrop(sender, e);
        }

        private void txtExportFolder_DragDrop(object sender, DragEventArgs e)
        {
            updateFilePathInTextBox(e, txtExportFolder, false);
        }

        private void rdoFolder_CheckedChanged(object sender, EventArgs e)
        {
            txtOpenedFiles.Text = "";
        }
    }
}
