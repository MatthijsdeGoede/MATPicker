namespace MATPicker
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using System.Windows.Forms;

    public partial class Form : System.Windows.Forms.Form
    {
        private string pmdFilterString = "PMD Files (*.pmd)|*.pmd";
        private HashSet<string> baseFolders = new HashSet<string>();

        public Form()
        {
            InitializeComponent();
            Log.Box = rtxLog;
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
                addMultipleBaseFolders(new HashSet<string>() { fbdBaseFolder.SelectedPath });
            }
        }

        private void btnResetBaseFolders_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("All the currently opened base folders will be closed.", "Are you sure you want to reset?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                baseFolders.Clear();
                txtBaseFolder.Text = "";
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
                Config.BaseFolders = baseFolders;
                Config.ExportFolder = txtExportFolder.Text;
                Config.PickMatFiles = cklFileTypes.GetItemChecked(0);
                Config.PickTobjFiles = cklFileTypes.GetItemChecked(1);
                Config.PickDdsFiles = cklFileTypes.GetItemChecked(2);
                Config.PickModelFiles = cklFileTypes.GetItemChecked(3);
                Config.ExportEmptyFolders = chkExportEmptyFolders.Checked;
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

        // Business Logic

        private void addMultipleBaseFolders(HashSet<String> folders)
        {
            StringBuilder openedFoldersBuilder = new StringBuilder(txtBaseFolder.Text);
            lblBaseFolderStatus.Text = "";

            foreach (string folder in folders)
            {
                if (baseFolders.Add(folder))
                {
                    openedFoldersBuilder.AppendLine(folder);
                }
            }
            txtBaseFolder.Text = openedFoldersBuilder.ToString();
        }

        private void updateFilePathInTextBox(DragEventArgs e, TextBox txt, bool singleFile)
        {
            string[] droppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (validateFileOrFolder(droppedFiles[0], singleFile))
            {
                txt.Text = droppedFiles[0];
            }
        }

        // Drag and Drop Mode

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
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void txtBaseFolder_DragDrop(object sender, DragEventArgs e)
        {
            string[] droppedFolders = (string[])e.Data.GetData(DataFormats.FileDrop);
            HashSet<string> folders = new HashSet<string>();

            foreach (string file in droppedFolders)
            {
                if (Directory.Exists(file))
                {
                    folders.Add(file);
                }
            }
            if (folders.Count > 0)
            {
                addMultipleBaseFolders(folders);
            }
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
