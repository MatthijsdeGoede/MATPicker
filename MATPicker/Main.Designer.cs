
namespace MATPicker
{
    partial class Main
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
            this.txtLog = new System.Windows.Forms.TextBox();
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
            this.txtOpenedSingleTobj = new System.Windows.Forms.TextBox();
            this.txtExportFolder = new System.Windows.Forms.TextBox();
            this.lblExportFolder = new System.Windows.Forms.Label();
            this.lblOpenedFile = new System.Windows.Forms.Label();
            this.lblFilePickStatus = new System.Windows.Forms.Label();
            this.cklFileTypes = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenExportFolder = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.grpLocation = new System.Windows.Forms.GroupBox();
            this.ofdModFolder = new System.Windows.Forms.OpenFileDialog();
            this.ofdFileFolder = new System.Windows.Forms.OpenFileDialog();
            this.ofdBaseFolder = new System.Windows.Forms.OpenFileDialog();
            this.ofdExportFolder = new System.Windows.Forms.OpenFileDialog();
            this.grpLog.SuspendLayout();
            this.grpLocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLog
            // 
            this.grpLog.Controls.Add(this.txtLog);
            this.grpLog.Controls.Add(this.btnClearLog);
            this.grpLog.Controls.Add(this.label3);
            this.grpLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpLog.Location = new System.Drawing.Point(12, 545);
            this.grpLog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpLog.Name = "grpLog";
            this.grpLog.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpLog.Size = new System.Drawing.Size(776, 397);
            this.grpLog.TabIndex = 21;
            this.grpLog.TabStop = false;
            this.grpLog.Text = "Log";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(26, 40);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(726, 281);
            this.txtLog.TabIndex = 10;
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(677, 340);
            this.btnClearLog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(75, 36);
            this.btnClearLog.TabIndex = 11;
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
            this.txtBaseFolder.Location = new System.Drawing.Point(26, 197);
            this.txtBaseFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBaseFolder.Name = "txtBaseFolder";
            this.txtBaseFolder.Size = new System.Drawing.Size(628, 26);
            this.txtBaseFolder.TabIndex = 4;
            // 
            // lblBaseFolder
            // 
            this.lblBaseFolder.AutoSize = true;
            this.lblBaseFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBaseFolder.Location = new System.Drawing.Point(26, 169);
            this.lblBaseFolder.Name = "lblBaseFolder";
            this.lblBaseFolder.Size = new System.Drawing.Size(146, 17);
            this.lblBaseFolder.TabIndex = 16;
            this.lblBaseFolder.Text = "Extracted base folder:";
            // 
            // btnOpenBaseFolder
            // 
            this.btnOpenBaseFolder.Location = new System.Drawing.Point(677, 194);
            this.btnOpenBaseFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpenBaseFolder.Name = "btnOpenBaseFolder";
            this.btnOpenBaseFolder.Size = new System.Drawing.Size(75, 36);
            this.btnOpenBaseFolder.TabIndex = 5;
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
            this.btnPickFiles.Location = new System.Drawing.Point(26, 444);
            this.btnPickFiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPickFiles.Name = "btnPickFiles";
            this.btnPickFiles.Size = new System.Drawing.Size(726, 36);
            this.btnPickFiles.TabIndex = 9;
            this.btnPickFiles.Text = "Pick";
            this.btnPickFiles.UseVisualStyleBackColor = true;
            this.btnPickFiles.Click += new System.EventHandler(this.btnPickFiles_Click);
            // 
            // txtOpenedSingleTobj
            // 
            this.txtOpenedSingleTobj.AllowDrop = true;
            this.txtOpenedSingleTobj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOpenedSingleTobj.Location = new System.Drawing.Point(26, 130);
            this.txtOpenedSingleTobj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOpenedSingleTobj.Name = "txtOpenedSingleTobj";
            this.txtOpenedSingleTobj.Size = new System.Drawing.Size(628, 26);
            this.txtOpenedSingleTobj.TabIndex = 2;
            // 
            // txtExportFolder
            // 
            this.txtExportFolder.AllowDrop = true;
            this.txtExportFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtExportFolder.Location = new System.Drawing.Point(26, 265);
            this.txtExportFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtExportFolder.Name = "txtExportFolder";
            this.txtExportFolder.Size = new System.Drawing.Size(628, 26);
            this.txtExportFolder.TabIndex = 6;
            // 
            // lblExportFolder
            // 
            this.lblExportFolder.AutoSize = true;
            this.lblExportFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExportFolder.Location = new System.Drawing.Point(26, 237);
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
            // lblFilePickStatus
            // 
            this.lblFilePickStatus.AutoSize = true;
            this.lblFilePickStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFilePickStatus.Location = new System.Drawing.Point(380, 18);
            this.lblFilePickStatus.Name = "lblFilePickStatus";
            this.lblFilePickStatus.Size = new System.Drawing.Size(0, 17);
            this.lblFilePickStatus.TabIndex = 14;
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
            this.cklFileTypes.Location = new System.Drawing.Point(26, 337);
            this.cklFileTypes.Name = "cklFileTypes";
            this.cklFileTypes.Size = new System.Drawing.Size(726, 88);
            this.cklFileTypes.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Pick filetypes:";
            // 
            // btnOpenExportFolder
            // 
            this.btnOpenExportFolder.Location = new System.Drawing.Point(677, 260);
            this.btnOpenExportFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpenExportFolder.Name = "btnOpenExportFolder";
            this.btnOpenExportFolder.Size = new System.Drawing.Size(75, 36);
            this.btnOpenExportFolder.TabIndex = 7;
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
            this.btnOpenFile.TabIndex = 3;
            this.btnOpenFile.Text = "Open";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // grpLocation
            // 
            this.grpLocation.Controls.Add(this.btnOpenModFolder);
            this.grpLocation.Controls.Add(this.btnOpenFile);
            this.grpLocation.Controls.Add(this.btnOpenExportFolder);
            this.grpLocation.Controls.Add(this.btnOpenBaseFolder);
            this.grpLocation.Controls.Add(this.label2);
            this.grpLocation.Controls.Add(this.lblModFolder);
            this.grpLocation.Controls.Add(this.cklFileTypes);
            this.grpLocation.Controls.Add(this.txtModFolder);
            this.grpLocation.Controls.Add(this.lblBaseFolder);
            this.grpLocation.Controls.Add(this.lblFilePickStatus);
            this.grpLocation.Controls.Add(this.txtBaseFolder);
            this.grpLocation.Controls.Add(this.lblOpenedFile);
            this.grpLocation.Controls.Add(this.lblExportFolder);
            this.grpLocation.Controls.Add(this.txtExportFolder);
            this.grpLocation.Controls.Add(this.txtOpenedSingleTobj);
            this.grpLocation.Controls.Add(this.btnPickFiles);
            this.grpLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpLocation.Location = new System.Drawing.Point(12, 13);
            this.grpLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpLocation.Name = "grpLocation";
            this.grpLocation.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpLocation.Size = new System.Drawing.Size(776, 513);
            this.grpLocation.TabIndex = 4;
            this.grpLocation.TabStop = false;
            this.grpLocation.Text = "Pick Files";
            // 
            // ofdModFolder
            // 
            this.ofdModFolder.FileName = "ofdModFolder";
            // 
            // ofdFileFolder
            // 
            this.ofdFileFolder.FileName = "ofdFileFolder";
            // 
            // ofdBaseFolder
            // 
            this.ofdBaseFolder.FileName = "ofdBaseFolder";
            // 
            // ofdExportFolder
            // 
            this.ofdExportFolder.FileName = "ofdExportFolder";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 981);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.grpLog);
            this.Controls.Add(this.grpLocation);
            this.MinimumSize = new System.Drawing.Size(818, 1028);
            this.Name = "Main";
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
        private System.Windows.Forms.Label lblFilePickStatus;
        private System.Windows.Forms.Label lblOpenedFile;
        private System.Windows.Forms.TextBox txtOpenedSingleTobj;
        private System.Windows.Forms.Button btnPickFiles;
        private System.Windows.Forms.Label lblExportFolder;
        private System.Windows.Forms.TextBox txtExportFolder;
        private System.Windows.Forms.Label lblBaseFolder;
        private System.Windows.Forms.TextBox txtBaseFolder;
        private System.Windows.Forms.Label lblModFolder;
        private System.Windows.Forms.TextBox txtModFolder;
        private System.Windows.Forms.GroupBox grpLog;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox cklFileTypes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnOpenExportFolder;
        private System.Windows.Forms.Button btnOpenModFolder;
        private System.Windows.Forms.Button btnOpenBaseFolder;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.OpenFileDialog ofdModFolder;
        private System.Windows.Forms.OpenFileDialog ofdFileFolder;
        private System.Windows.Forms.OpenFileDialog ofdBaseFolder;
        private System.Windows.Forms.OpenFileDialog ofdExportFolder;
    }
}

