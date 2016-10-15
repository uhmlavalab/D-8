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
            this.Upload = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Label();
            this.FileList = new System.Windows.Forms.Label();
            this.FileListBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.browsefolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Upload
            // 
            this.Upload.Location = new System.Drawing.Point(31, 257);
            this.Upload.Margin = new System.Windows.Forms.Padding(4);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(640, 57);
            this.Upload.TabIndex = 0;
            this.Upload.Text = "Upload";
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // Status
            // 
            this.Status.Location = new System.Drawing.Point(693, 105);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(298, 75);
            this.Status.TabIndex = 1;
            this.Status.Text = "Status: Ready to upload.";
            // 
            // FileList
            // 
            this.FileList.Location = new System.Drawing.Point(28, 118);
            this.FileList.Name = "FileList";
            this.FileList.Size = new System.Drawing.Size(224, 30);
            this.FileList.TabIndex = 2;
            this.FileList.Text = "Folder to Upload:";
            // 
            // FileListBox
            // 
            this.FileListBox.Location = new System.Drawing.Point(31, 161);
            this.FileListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FileListBox.Multiline = true;
            this.FileListBox.Name = "FileListBox";
            this.FileListBox.Size = new System.Drawing.Size(653, 74);
            this.FileListBox.TabIndex = 3;
            this.FileListBox.TextChanged += new System.EventHandler(this.FileListBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Instructions: Browse folder and press Upload.";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // browsefolder
            // 
            this.browsefolder.Location = new System.Drawing.Point(31, 30);
            this.browsefolder.Margin = new System.Windows.Forms.Padding(4);
            this.browsefolder.Name = "browsefolder";
            this.browsefolder.Size = new System.Drawing.Size(414, 74);
            this.browsefolder.TabIndex = 5;
            this.browsefolder.Text = "Browse";
            this.browsefolder.UseVisualStyleBackColor = true;
            this.browsefolder.Click += new System.EventHandler(this.browsefolder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 569);
            this.Controls.Add(this.browsefolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FileListBox);
            this.Controls.Add(this.FileList);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Upload);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "FolderSync";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Upload;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label FileList;
        private System.Windows.Forms.TextBox FileListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button browsefolder;
    }
}