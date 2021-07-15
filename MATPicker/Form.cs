namespace MATPicker
{
    using System;
    using System.IO;
    using System.Windows.Forms;

    public partial class Form : System.Windows.Forms.Form
    {
        private string pmdFilterString = "PMD Files (*.pmd)|*.pmd";

        public Form()
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
            if (validateFormFields())
            {
                Config.ModFolder = txtModFolder.Text;
                Config.SingleFile = rdoSinglePMD.Checked;
                Config.OpenedFile = txtOpenedFiles.Text;
                Config.BaseFolder = txtBaseFolder.Text;
                Config.ExportFolder = txtExportFolder.Text;
                Config.PickMatFiles = cklFileTypes.GetItemChecked(0);
                Config.PickTobjFiles = cklFileTypes.GetItemChecked(1);
                Config.PickDdsFiles = cklFileTypes.GetItemChecked(2);
                Config.PickModelFiles = cklFileTypes.GetItemChecked(3);
                Config.ExportEmptyFolders = chkExportEmptyFolders.Checked;
                Log.Box = rtxLog;
                Log.ShowErrorsOnly = rdoLogErrorsOnly.Checked;
                Log.Clear();
                Picker.Pick();
                Log.Show();
            }
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            rtxLog.Clear();
        }

        // Input validation

        private bool validateFormFields() 
        {
            if (!validateFileOrFolder(txtModFolder.Text, false)) 
            {
                lblModFolderStatus.Text = "Please select a valid mod folder that contains the selected PMD files!";
                return false;
            }
            if (!validateFileOrFolder(txtOpenedFiles.Text, rdoSinglePMD.Checked))
            {
                lblOpenedFileStatus.Text = "Please select a valid PMD file or a folder that contains any!";
                return false;
            }
            if (!validateFileOrFolder(txtBaseFolder.Text, false))
            {
                lblBaseFolderStatus.Text = "Please select a valid base folder in which the base.scs file is extracted!";
                return false;
            }
            if (!validateFileOrFolder(txtExportFolder.Text, false))
            {
                lblExportFolderStatus.Text = "Please select a valid export folder to export the picked files to!";
                return false;
            }
            return true;
        }

        private bool validateFileOrFolder(string path, bool file) 
        {
            return !String.IsNullOrEmpty(path) && (file && Path.GetExtension(path).Equals(".pmd") || !file && Directory.Exists(path));
        }

        // Drag and Drop Mode

        private void updateFilePathInTextBox(DragEventArgs e, TextBox txt, bool singleFile)
        {
            string[] droppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (validateFileOrFolder(droppedFiles[0], singleFile))
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
            txtOpenedFiles.Clear();
        }

        // Event handlers

        private void rdoLogErrorsOnly_CheckedChanged(object sender, EventArgs e)
        {
            Log.ShowErrorsOnly = rdoLogErrorsOnly.Checked;
            Log.Show();
        }

        private void txtModFolder_TextChanged(object sender, EventArgs e)
        {
            lblModFolderStatus.Text = "";
        }

        private void txtOpenedFiles_TextChanged(object sender, EventArgs e)
        {
            lblOpenedFileStatus.Text = "";
        }

        private void txtBaseFolder_TextChanged(object sender, EventArgs e)
        {
            lblBaseFolderStatus.Text = "";
        }

        private void txtExportFolder_TextChanged(object sender, EventArgs e)
        {
            lblExportFolderStatus.Text = "";
        }
    }
}
