namespace FolderMonitor {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.UploadBtn = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Label();
            this.FileList = new System.Windows.Forms.Label();
            this.FileListBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.browsefolderBtn = new System.Windows.Forms.Button();
            this.CleanDirBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UploadBtn
            // 
            this.UploadBtn.Location = new System.Drawing.Point(23, 209);
            this.UploadBtn.Name = "UploadBtn";
            this.UploadBtn.Size = new System.Drawing.Size(480, 46);
            this.UploadBtn.TabIndex = 0;
            this.UploadBtn.Text = "Upload";
            this.UploadBtn.UseVisualStyleBackColor = true;
            this.UploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // Status
            // 
            this.Status.Location = new System.Drawing.Point(520, 85);
            this.Status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(224, 61);
            this.Status.TabIndex = 1;
            this.Status.Text = "Status: Ready to upload.";
            // 
            // FileList
            // 
            this.FileList.Location = new System.Drawing.Point(21, 96);
            this.FileList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FileList.Name = "FileList";
            this.FileList.Size = new System.Drawing.Size(168, 24);
            this.FileList.TabIndex = 2;
            this.FileList.Text = "Folder to Upload:";
            // 
            // FileListBox
            // 
            this.FileListBox.Location = new System.Drawing.Point(23, 131);
            this.FileListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FileListBox.Multiline = true;
            this.FileListBox.Name = "FileListBox";
            this.FileListBox.Size = new System.Drawing.Size(491, 61);
            this.FileListBox.TabIndex = 3;
            this.FileListBox.TextChanged += new System.EventHandler(this.FileListBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Instructions: Browse folder and press Upload.";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // browsefolderBtn
            // 
            this.browsefolderBtn.Location = new System.Drawing.Point(23, 24);
            this.browsefolderBtn.Name = "browsefolderBtn";
            this.browsefolderBtn.Size = new System.Drawing.Size(310, 60);
            this.browsefolderBtn.TabIndex = 5;
            this.browsefolderBtn.Text = "Browse";
            this.browsefolderBtn.UseVisualStyleBackColor = true;
            this.browsefolderBtn.Click += new System.EventHandler(this.browseFolderBtn_Click);
            // 
            // CleanDirBtn
            // 
            this.CleanDirBtn.Location = new System.Drawing.Point(629, 394);
            this.CleanDirBtn.Name = "CleanDirBtn";
            this.CleanDirBtn.Size = new System.Drawing.Size(139, 23);
            this.CleanDirBtn.TabIndex = 6;
            this.CleanDirBtn.Text = "Clean Folders";
            this.CleanDirBtn.UseVisualStyleBackColor = true;
            this.CleanDirBtn.Click += new System.EventHandler(this.CleanDirBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 462);
            this.Controls.Add(this.CleanDirBtn);
            this.Controls.Add(this.browsefolderBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FileListBox);
            this.Controls.Add(this.FileList);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.UploadBtn);
            this.Name = "Form1";
            this.Text = "FolderSync";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UploadBtn;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label FileList;
        private System.Windows.Forms.TextBox FileListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button browsefolderBtn;
        private System.Windows.Forms.Button CleanDirBtn;
    }
}