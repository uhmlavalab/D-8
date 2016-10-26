namespace CCDestinyUploader {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.UploadBtn = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Label();
            this.FileList = new System.Windows.Forms.Label();
            this.FileListBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.browseFolderUploadDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.browsefolderBtn = new System.Windows.Forms.Button();
            this.CleanDirBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.browseDeleteButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FileDeleteBox = new System.Windows.Forms.TextBox();
            this.browseFolderDeleteDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UploadBtn
            // 
            this.UploadBtn.Location = new System.Drawing.Point(268, 227);
            this.UploadBtn.Margin = new System.Windows.Forms.Padding(4);
            this.UploadBtn.Name = "UploadBtn";
            this.UploadBtn.Size = new System.Drawing.Size(216, 74);
            this.UploadBtn.TabIndex = 1;
            this.UploadBtn.Text = "Upload";
            this.UploadBtn.UseVisualStyleBackColor = true;
            this.UploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // Status
            // 
            this.Status.Location = new System.Drawing.Point(28, 197);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(456, 26);
            this.Status.TabIndex = 1;
            this.Status.Text = "Status: Ready to upload.";
            // 
            // FileList
            // 
            this.FileList.Location = new System.Drawing.Point(28, 109);
            this.FileList.Name = "FileList";
            this.FileList.Size = new System.Drawing.Size(224, 18);
            this.FileList.TabIndex = 2;
            this.FileList.Text = "Folder to Upload:";
            // 
            // FileListBox
            // 
            this.FileListBox.Location = new System.Drawing.Point(31, 144);
            this.FileListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FileListBox.Multiline = true;
            this.FileListBox.Name = "FileListBox";
            this.FileListBox.Size = new System.Drawing.Size(453, 51);
            this.FileListBox.TabIndex = 5;
            this.FileListBox.TextChanged += new System.EventHandler(this.FileListBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Instructions: Browse folder and press Upload.";
            // 
            // browseFolderUploadDialog
            // 
            this.browseFolderUploadDialog.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // browsefolderBtn
            // 
            this.browsefolderBtn.Location = new System.Drawing.Point(31, 227);
            this.browsefolderBtn.Margin = new System.Windows.Forms.Padding(4);
            this.browsefolderBtn.Name = "browsefolderBtn";
            this.browsefolderBtn.Size = new System.Drawing.Size(229, 74);
            this.browsefolderBtn.TabIndex = 0;
            this.browsefolderBtn.Text = "Browse";
            this.browsefolderBtn.UseVisualStyleBackColor = true;
            this.browsefolderBtn.Click += new System.EventHandler(this.browseFolderBtn_Click);
            // 
            // CleanDirBtn
            // 
            this.CleanDirBtn.Location = new System.Drawing.Point(765, 227);
            this.CleanDirBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CleanDirBtn.Name = "CleanDirBtn";
            this.CleanDirBtn.Size = new System.Drawing.Size(195, 74);
            this.CleanDirBtn.TabIndex = 3;
            this.CleanDirBtn.Text = "Delete Folders";
            this.CleanDirBtn.UseVisualStyleBackColor = true;
            this.CleanDirBtn.Click += new System.EventHandler(this.CleanDirBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.ImageLocation = "C:\\Users\\Jack\\Documents\\GitHub\\D-8\\LAVAlogoresize2.png";
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(316, 379);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 150);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(425, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Instructions: Browse folder on Kanaloa 1 and press Delete Folders";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label3.Location = new System.Drawing.Point(151, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 46);
            this.label3.TabIndex = 9;
            this.label3.Text = "Upload";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label4.Location = new System.Drawing.Point(671, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 46);
            this.label4.TabIndex = 10;
            this.label4.Text = "Delete";
            // 
            // browseDeleteButton
            // 
            this.browseDeleteButton.Location = new System.Drawing.Point(528, 227);
            this.browseDeleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.browseDeleteButton.Name = "browseDeleteButton";
            this.browseDeleteButton.Size = new System.Drawing.Size(229, 74);
            this.browseDeleteButton.TabIndex = 2;
            this.browseDeleteButton.Text = "Browse";
            this.browseDeleteButton.UseVisualStyleBackColor = true;
            this.browseDeleteButton.Click += new System.EventHandler(this.browseDeleteButton_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(500, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(5, 350);
            this.label5.TabIndex = 12;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(525, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "Folder to Delete:";
            // 
            // FileDeleteBox
            // 
            this.FileDeleteBox.Location = new System.Drawing.Point(528, 144);
            this.FileDeleteBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FileDeleteBox.Multiline = true;
            this.FileDeleteBox.Name = "FileDeleteBox";
            this.FileDeleteBox.Size = new System.Drawing.Size(432, 51);
            this.FileDeleteBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 569);
            this.Controls.Add(this.FileDeleteBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.browseDeleteButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CleanDirBtn);
            this.Controls.Add(this.browsefolderBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FileListBox);
            this.Controls.Add(this.FileList);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.UploadBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "CCDestinyUploader";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UploadBtn;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label FileList;
        private System.Windows.Forms.TextBox FileListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog browseFolderUploadDialog;
        private System.Windows.Forms.Button browsefolderBtn;
        private System.Windows.Forms.Button CleanDirBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button browseDeleteButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FileDeleteBox;
        private System.Windows.Forms.FolderBrowserDialog browseFolderDeleteDialog;
    }
}