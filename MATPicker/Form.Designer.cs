
namespace MATPicker
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpLog = new System.Windows.Forms.GroupBox();
            this.rtxLog = new System.Windows.Forms.RichTextBox();
            this.rdoLogErrorsOnly = new System.Windows.Forms.RadioButton();
            this.rdoLogAll = new System.Windows.Forms.RadioButton();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCredits = new System.Windows.Forms.Label();
            this.txtModFolder = new System.Windows.Forms.TextBox();
            this.lblModFolder = new System.Windows.Forms.Label();
            this.txtBaseFolder = new System.Windows.Forms.TextBox();
            this.lblBaseFolder = new System.Windows.Forms.Label();
            this.btnOpenBaseFolder = new System.Windows.Forms.Button();
            this.btnOpenModFolder = new System.Windows.Forms.Button();
            this.btnPickFiles = new System.Windows.Forms.Button();
            this.txtOpenedFiles = new System.Windows.Forms.TextBox();
            this.txtExportFolder = new System.Windows.Forms.TextBox();
            this.lblExportFolder = new System.Windows.Forms.Label();
            this.lblOpenedFile = new System.Windows.Forms.Label();
            this.lblModFolderStatus = new System.Windows.Forms.Label();
            this.cklFileTypes = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenExportFolder = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.grpLocation = new System.Windows.Forms.GroupBox();
            this.lblExportFolderStatus = new System.Windows.Forms.Label();
            this.lblBaseFolderStatus = new System.Windows.Forms.Label();
            this.lblOpenedFileStatus = new System.Windows.Forms.Label();
            this.rdoFolder = new System.Windows.Forms.RadioButton();
            this.rdoSinglePMD = new System.Windows.Forms.RadioButton();
            this.ofdPMDFile = new System.Windows.Forms.OpenFileDialog();
            this.fbdFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.fbdModFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.fbdBaseFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.fbdExportFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.grpLog.SuspendLayout();
            this.grpLocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLog
            // 
            this.grpLog.Controls.Add(this.rtxLog);
            this.grpLog.Controls.Add(this.rdoLogErrorsOnly);
            this.grpLog.Controls.Add(this.rdoLogAll);
            this.grpLog.Controls.Add(this.btnClearLog);
            this.grpLog.Controls.Add(this.label3);
            this.grpLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpLog.Location = new System.Drawing.Point(12, 559);
            this.grpLog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpLog.Name = "grpLog";
            this.grpLog.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpLog.Size = new System.Drawing.Size(776, 383);
            this.grpLog.TabIndex = 21;
            this.grpLog.TabStop = false;
            this.grpLog.Text = "Log";
            // 
            // rtxLog
            // 
            this.rtxLog.Location = new System.Drawing.Point(26, 40);
            this.rtxLog.Name = "rtxLog";
            this.rtxLog.ReadOnly = true;
            this.rtxLog.Size = new System.Drawing.Size(726, 264);
            this.rtxLog.TabIndex = 12;
            this.rtxLog.Text = "";
            // 
            // rdoLogErrorsOnly
            // 
            this.rdoLogErrorsOnly.AutoSize = true;
            this.rdoLogErrorsOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoLogErrorsOnly.Location = new System.Drawing.Point(130, 325);
            this.rdoLogErrorsOnly.Name = "rdoLogErrorsOnly";
            this.rdoLogErrorsOnly.Size = new System.Drawing.Size(147, 21);
            this.rdoLogErrorsOnly.TabIndex = 14;
            this.rdoLogErrorsOnly.Text = "Display errors only";
            this.rdoLogErrorsOnly.UseVisualStyleBackColor = true;
            this.rdoLogErrorsOnly.CheckedChanged += new System.EventHandler(this.rdoLogErrorsOnly_CheckedChanged);
            // 
            // rdoLogAll
            // 
            this.rdoLogAll.AutoSize = true;
            this.rdoLogAll.Checked = true;
            this.rdoLogAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoLogAll.Location = new System.Drawing.Point(26, 325);
            this.rdoLogAll.Name = "rdoLogAll";
            this.rdoLogAll.Size = new System.Drawing.Size(93, 21);
            this.rdoLogAll.TabIndex = 13;
            this.rdoLogAll.TabStop = true;
            this.rdoLogAll.Text = "Display all";
            this.rdoLogAll.UseVisualStyleBackColor = true;
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(677, 325);
            this.btnClearLog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(75, 36);
            this.btnClearLog.TabIndex = 15;
            this.btnClearLog.Text = "Clear";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(380, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 14;
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCredits.Location = new System.Drawing.Point(12, 954);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(245, 17);
            this.lblCredits.TabIndex = 22;
            this.lblCredits.Text = "Created by Nico and Elitesquad Modz";
            // 
            // txtModFolder
            // 
            this.txtModFolder.AllowDrop = true;
            this.txtModFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtModFolder.Location = new System.Drawing.Point(26, 65);
            this.txtModFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtModFolder.Name = "txtModFolder";
            this.txtModFolder.Size = new System.Drawing.Size(628, 26);
            this.txtModFolder.TabIndex = 0;
            this.txtModFolder.TextChanged += new System.EventHandler(this.txtModFolder_TextChanged);
            this.txtModFolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtModFolder_DragDrop);
            this.txtModFolder.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtModFolder_DragEnter);
            // 
            // lblModFolder
            // 
            this.lblModFolder.AutoSize = true;
            this.lblModFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblModFolder.Location = new System.Drawing.Point(26, 38);
            this.lblModFolder.Name = "lblModFolder";
            this.lblModFolder.Size = new System.Drawing.Size(79, 17);
            this.lblModFolder.TabIndex = 3;
            this.lblModFolder.Text = "Mod folder:";
            // 
            // txtBaseFolder
            // 
            this.txtBaseFolder.AllowDrop = true;
            this.txtBaseFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBaseFolder.Location = new System.Drawing.Point(26, 218);
            this.txtBaseFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBaseFolder.Name = "txtBaseFolder";
            this.txtBaseFolder.Size = new System.Drawing.Size(628, 26);
            this.txtBaseFolder.TabIndex = 6;
            this.txtBaseFolder.TextChanged += new System.EventHandler(this.txtBaseFolder_TextChanged);
            this.txtBaseFolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtBaseFolder_DragDrop);
            this.txtBaseFolder.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtBaseFolder_DragEnter);
            // 
            // lblBaseFolder
            // 
            this.lblBaseFolder.AutoSize = true;
            this.lblBaseFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBaseFolder.Location = new System.Drawing.Point(26, 190);
            this.lblBaseFolder.Name = "lblBaseFolder";
            this.lblBaseFolder.Size = new System.Drawing.Size(146, 17);
            this.lblBaseFolder.TabIndex = 16;
            this.lblBaseFolder.Text = "Extracted base folder:";
            // 
            // btnOpenBaseFolder
            // 
            this.btnOpenBaseFolder.Location = new System.Drawing.Point(677, 215);
            this.btnOpenBaseFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpenBaseFolder.Name = "btnOpenBaseFolder";
            this.btnOpenBaseFolder.Size = new System.Drawing.Size(75, 36);
            this.btnOpenBaseFolder.TabIndex = 7;
            this.btnOpenBaseFolder.Text = "Open";
            this.btnOpenBaseFolder.UseVisualStyleBackColor = true;
            this.btnOpenBaseFolder.Click += new System.EventHandler(this.btnOpenBaseFolder_Click);
            // 
            // btnOpenModFolder
            // 
            this.btnOpenModFolder.Location = new System.Drawing.Point(677, 58);
            this.btnOpenModFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpenModFolder.Name = "btnOpenModFolder";
            this.btnOpenModFolder.Size = new System.Drawing.Size(75, 36);
            this.btnOpenModFolder.TabIndex = 1;
            this.btnOpenModFolder.Text = "Open";
            this.btnOpenModFolder.UseVisualStyleBackColor = true;
            this.btnOpenModFolder.Click += new System.EventHandler(this.btnOpenModFolder_Click);
            // 
            // btnPickFiles
            // 
            this.btnPickFiles.Location = new System.Drawing.Point(26, 465);
            this.btnPickFiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPickFiles.Name = "btnPickFiles";
            this.btnPickFiles.Size = new System.Drawing.Size(726, 36);
            this.btnPickFiles.TabIndex = 11;
            this.btnPickFiles.Text = "Pick";
            this.btnPickFiles.UseVisualStyleBackColor = true;
            this.btnPickFiles.Click += new System.EventHandler(this.btnPickFiles_Click);
            // 
            // txtOpenedFiles
            // 
            this.txtOpenedFiles.AllowDrop = true;
            this.txtOpenedFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOpenedFiles.Location = new System.Drawing.Point(26, 130);
            this.txtOpenedFiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOpenedFiles.Name = "txtOpenedFiles";
            this.txtOpenedFiles.Size = new System.Drawing.Size(628, 26);
            this.txtOpenedFiles.TabIndex = 2;
            this.txtOpenedFiles.TextChanged += new System.EventHandler(this.txtOpenedFiles_TextChanged);
            this.txtOpenedFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtOpenedFiles_DragDrop);
            this.txtOpenedFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtOpenedFiles_DragEnter);
            // 
            // txtExportFolder
            // 
            this.txtExportFolder.AllowDrop = true;
            this.txtExportFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtExportFolder.Location = new System.Drawing.Point(26, 286);
            this.txtExportFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtExportFolder.Name = "txtExportFolder";
            this.txtExportFolder.Size = new System.Drawing.Size(628, 26);
            this.txtExportFolder.TabIndex = 8;
            this.txtExportFolder.TextChanged += new System.EventHandler(this.txtExportFolder_TextChanged);
            this.txtExportFolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtExportFolder_DragDrop);
            this.txtExportFolder.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtExportFolder_DragEnter);
            // 
            // lblExportFolder
            // 
            this.lblExportFolder.AutoSize = true;
            this.lblExportFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExportFolder.Location = new System.Drawing.Point(26, 258);
            this.lblExportFolder.Name = "lblExportFolder";
            this.lblExportFolder.Size = new System.Drawing.Size(92, 17);
            this.lblExportFolder.TabIndex = 18;
            this.lblExportFolder.Text = "Export folder:";
            // 
            // lblOpenedFile
            // 
            this.lblOpenedFile.AutoSize = true;
            this.lblOpenedFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOpenedFile.Location = new System.Drawing.Point(26, 103);
            this.lblOpenedFile.Name = "lblOpenedFile";
            this.lblOpenedFile.Size = new System.Drawing.Size(154, 17);
            this.lblOpenedFile.TabIndex = 3;
            this.lblOpenedFile.Text = "PMD (folder) to pick for";
            // 
            // lblModFolderStatus
            // 
            this.lblModFolderStatus.AutoSize = true;
            this.lblModFolderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblModFolderStatus.ForeColor = System.Drawing.Color.Red;
            this.lblModFolderStatus.Location = new System.Drawing.Point(200, 38);
            this.lblModFolderStatus.Name = "lblModFolderStatus";
            this.lblModFolderStatus.Size = new System.Drawing.Size(0, 17);
            this.lblModFolderStatus.TabIndex = 14;
            // 
            // cklFileTypes
            // 
            this.cklFileTypes.CheckOnClick = true;
            this.cklFileTypes.FormattingEnabled = true;
            this.cklFileTypes.Items.AddRange(new object[] {
            "MAT files",
            "TOBJ files",
            "DDS files",
            "PMD/PMG/PMC files"});
            this.cklFileTypes.Location = new System.Drawing.Point(26, 358);
            this.cklFileTypes.Name = "cklFileTypes";
            this.cklFileTypes.Size = new System.Drawing.Size(726, 88);
            this.cklFileTypes.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Pick filetypes:";
            // 
            // btnOpenExportFolder
            // 
            this.btnOpenExportFolder.Location = new System.Drawing.Point(677, 281);
            this.btnOpenExportFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpenExportFolder.Name = "btnOpenExportFolder";
            this.btnOpenExportFolder.Size = new System.Drawing.Size(75, 36);
            this.btnOpenExportFolder.TabIndex = 9;
            this.btnOpenExportFolder.Text = "Open";
            this.btnOpenExportFolder.UseVisualStyleBackColor = true;
            this.btnOpenExportFolder.Click += new System.EventHandler(this.btnOpenExportFolder_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(677, 125);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 36);
            this.btnOpenFile.TabIndex = 5;
            this.btnOpenFile.Text = "Open";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // grpLocation
            // 
            this.grpLocation.Controls.Add(this.lblExportFolderStatus);
            this.grpLocation.Controls.Add(this.lblBaseFolderStatus);
            this.grpLocation.Controls.Add(this.lblOpenedFileStatus);
            this.grpLocation.Controls.Add(this.rdoFolder);
            this.grpLocation.Controls.Add(this.rdoSinglePMD);
            this.grpLocation.Controls.Add(this.btnOpenModFolder);
            this.grpLocation.Controls.Add(this.btnOpenFile);
            this.grpLocation.Controls.Add(this.btnOpenExportFolder);
            this.grpLocation.Controls.Add(this.btnOpenBaseFolder);
            this.grpLocation.Controls.Add(this.label2);
            this.grpLocation.Controls.Add(this.lblModFolder);
            this.grpLocation.Controls.Add(this.cklFileTypes);
            this.grpLocation.Controls.Add(this.txtModFolder);
            this.grpLocation.Controls.Add(this.lblBaseFolder);
            this.grpLocation.Controls.Add(this.lblModFolderStatus);
            this.grpLocation.Controls.Add(this.txtBaseFolder);
            this.grpLocation.Controls.Add(this.lblOpenedFile);
            this.grpLocation.Controls.Add(this.lblExportFolder);
            this.grpLocation.Controls.Add(this.txtExportFolder);
            this.grpLocation.Controls.Add(this.txtOpenedFiles);
            this.grpLocation.Controls.Add(this.btnPickFiles);
            this.grpLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpLocation.Location = new System.Drawing.Point(12, 13);
            this.grpLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpLocation.Name = "grpLocation";
            this.grpLocation.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpLocation.Size = new System.Drawing.Size(776, 527);
            this.grpLocation.TabIndex = 4;
            this.grpLocation.TabStop = false;
            this.grpLocation.Text = "Pick Files";
            // 
            // lblExportFolderStatus
            // 
            this.lblExportFolderStatus.AutoSize = true;
            this.lblExportFolderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExportFolderStatus.ForeColor = System.Drawing.Color.Red;
            this.lblExportFolderStatus.Location = new System.Drawing.Point(200, 258);
            this.lblExportFolderStatus.Name = "lblExportFolderStatus";
            this.lblExportFolderStatus.Size = new System.Drawing.Size(0, 17);
            this.lblExportFolderStatus.TabIndex = 23;
            // 
            // lblBaseFolderStatus
            // 
            this.lblBaseFolderStatus.AutoSize = true;
            this.lblBaseFolderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBaseFolderStatus.ForeColor = System.Drawing.Color.Red;
            this.lblBaseFolderStatus.Location = new System.Drawing.Point(200, 190);
            this.lblBaseFolderStatus.Name = "lblBaseFolderStatus";
            this.lblBaseFolderStatus.Size = new System.Drawing.Size(0, 17);
            this.lblBaseFolderStatus.TabIndex = 22;
            // 
            // lblOpenedFileStatus
            // 
            this.lblOpenedFileStatus.AutoSize = true;
            this.lblOpenedFileStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOpenedFileStatus.ForeColor = System.Drawing.Color.Red;
            this.lblOpenedFileStatus.Location = new System.Drawing.Point(200, 103);
            this.lblOpenedFileStatus.Name = "lblOpenedFileStatus";
            this.lblOpenedFileStatus.Size = new System.Drawing.Size(0, 17);
            this.lblOpenedFileStatus.TabIndex = 21;
            // 
            // rdoFolder
            // 
            this.rdoFolder.AutoSize = true;
            this.rdoFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoFolder.Location = new System.Drawing.Point(585, 168);
            this.rdoFolder.Name = "rdoFolder";
            this.rdoFolder.Size = new System.Drawing.Size(69, 21);
            this.rdoFolder.TabIndex = 4;
            this.rdoFolder.Text = "Folder";
            this.rdoFolder.UseVisualStyleBackColor = true;
            this.rdoFolder.CheckedChanged += new System.EventHandler(this.rdoFolder_CheckedChanged);
            // 
            // rdoSinglePMD
            // 
            this.rdoSinglePMD.AutoSize = true;
            this.rdoSinglePMD.Checked = true;
            this.rdoSinglePMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoSinglePMD.Location = new System.Drawing.Point(454, 168);
            this.rdoSinglePMD.Name = "rdoSinglePMD";
            this.rdoSinglePMD.Size = new System.Drawing.Size(102, 21);
            this.rdoSinglePMD.TabIndex = 3;
            this.rdoSinglePMD.TabStop = true;
            this.rdoSinglePMD.Text = "Single PMD";
            this.rdoSinglePMD.UseVisualStyleBackColor = true;
            // 
            // ofdPMDFile
            // 
            this.ofdPMDFile.FileName = "ofdFileFolder";
            // 
            // fbdFolder
            // 
            this.fbdFolder.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // fbdModFolder
            // 
            this.fbdModFolder.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // fbdBaseFolder
            // 
            this.fbdBaseFolder.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // fbdExportFolder
            // 
            this.fbdExportFolder.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 981);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.grpLog);
            this.Controls.Add(this.grpLocation);
            this.MinimumSize = new System.Drawing.Size(818, 1028);
            this.Name = "Form";
            this.Text = "MATPicker";
            this.grpLog.ResumeLayout(false);
            this.grpLog.PerformLayout();
            this.grpLocation.ResumeLayout(false);
            this.grpLocation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLocation;
        private System.Windows.Forms.Label lblModFolderStatus;
        private System.Windows.Forms.Label lblOpenedFile;
        private System.Windows.Forms.TextBox txtOpenedFiles;
        private System.Windows.Forms.Button btnPickFiles;
        private System.Windows.Forms.Label lblExportFolder;
        private System.Windows.Forms.TextBox txtExportFolder;
        private System.Windows.Forms.Label lblBaseFolder;
        private System.Windows.Forms.TextBox txtBaseFolder;
        private System.Windows.Forms.Label lblModFolder;
        private System.Windows.Forms.TextBox txtModFolder;
        private System.Windows.Forms.GroupBox grpLog;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox cklFileTypes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnOpenExportFolder;
        private System.Windows.Forms.Button btnOpenModFolder;
        private System.Windows.Forms.Button btnOpenBaseFolder;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.OpenFileDialog ofdPMDFile;
        private System.Windows.Forms.RadioButton rdoFolder;
        private System.Windows.Forms.RadioButton rdoSinglePMD;
        private System.Windows.Forms.FolderBrowserDialog fbdFolder;
        private System.Windows.Forms.FolderBrowserDialog fbdModFolder;
        private System.Windows.Forms.FolderBrowserDialog fbdBaseFolder;
        private System.Windows.Forms.FolderBrowserDialog fbdExportFolder;
        private System.Windows.Forms.RichTextBox rtxLog;
        private System.Windows.Forms.RadioButton rdoLogErrorsOnly;
        private System.Windows.Forms.RadioButton rdoLogAll;
        private System.Windows.Forms.Label lblBaseFolderStatus;
        private System.Windows.Forms.Label lblOpenedFileStatus;
        private System.Windows.Forms.Label lblExportFolderStatus;
    }
}

