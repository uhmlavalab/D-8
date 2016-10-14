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
            this.button1 = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Label();
            this.FileList = new System.Windows.Forms.Label();
            this.FileListBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.browsefolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(480, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sync";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Status
            // 
            this.Status.Location = new System.Drawing.Point(31, 99);
            this.Status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(350, 55);
            this.Status.TabIndex = 1;
            this.Status.Text = "Status: Ready to sync.";
            // 
            // FileList
            // 
            this.FileList.Location = new System.Drawing.Point(31, 154);
            this.FileList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FileList.Name = "FileList";
            this.FileList.Size = new System.Drawing.Size(168, 24);
            this.FileList.TabIndex = 2;
            this.FileList.Text = "Files found to sync:";
            this.FileList.Click += new System.EventHandler(this.FileList_Click);
            // 
            // FileListBox
            // 
            this.FileListBox.Location = new System.Drawing.Point(23, 180);
            this.FileListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FileListBox.Multiline = true;
            this.FileListBox.Name = "FileListBox";
            this.FileListBox.Size = new System.Drawing.Size(491, 232);
            this.FileListBox.TabIndex = 3;
            this.FileListBox.TextChanged += new System.EventHandler(this.FileListBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Instructions: Copy files/folders into DestinyDropbox and press Sync.";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // browsefolder
            // 
            this.browsefolder.Location = new System.Drawing.Point(677, 41);
            this.browsefolder.Name = "browsefolder";
            this.browsefolder.Size = new System.Drawing.Size(75, 23);
            this.browsefolder.TabIndex = 5;
            this.browsefolder.Text = "Browse";
            this.browsefolder.UseVisualStyleBackColor = true;
            this.browsefolder.Click += new System.EventHandler(this.browsefolder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 462);
            this.Controls.Add(this.browsefolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FileListBox);
            this.Controls.Add(this.FileList);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "FolderSync";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label FileList;
        private System.Windows.Forms.TextBox FileListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button browsefolder;
    }
}