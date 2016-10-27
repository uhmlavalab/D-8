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
            this.StatusFile = new System.Windows.Forms.Label();
            this.FileListBox = new System.Windows.Forms.TextBox();
            this.browseFolderUploadDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.browsefolderBtn = new System.Windows.Forms.Button();
            this.CleanDirBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.browseDeleteButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.FileDeleteBox = new System.Windows.Forms.TextBox();
            this.browseFolderDeleteDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.StatusDelete = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // UploadBtn
            // 
            this.UploadBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.UploadBtn.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadBtn.Location = new System.Drawing.Point(112, 299);
            this.UploadBtn.Margin = new System.Windows.Forms.Padding(4);
            this.UploadBtn.Name = "UploadBtn";
            this.UploadBtn.Size = new System.Drawing.Size(230, 75);
            this.UploadBtn.TabIndex = 1;
            this.UploadBtn.Text = "Upload";
            this.UploadBtn.UseVisualStyleBackColor = false;
            this.UploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // StatusFile
            // 
            this.StatusFile.Font = new System.Drawing.Font("Arial", 18F);
            this.StatusFile.Location = new System.Drawing.Point(10, 520);
            this.StatusFile.Name = "StatusFile";
            this.StatusFile.Size = new System.Drawing.Size(456, 47);
            this.StatusFile.TabIndex = 1;
            this.StatusFile.Text = "Ready to Upload";
            this.StatusFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FileListBox
            // 
            this.FileListBox.Font = new System.Drawing.Font("Arial", 8F);
            this.FileListBox.Location = new System.Drawing.Point(29, 232);
            this.FileListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FileListBox.Multiline = true;
            this.FileListBox.Name = "FileListBox";
            this.FileListBox.Size = new System.Drawing.Size(450, 60);
            this.FileListBox.TabIndex = 5;
            this.FileListBox.TextChanged += new System.EventHandler(this.FileListBox_TextChanged);
            // 
            // browseFolderUploadDialog
            // 
            this.browseFolderUploadDialog.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // browsefolderBtn
            // 
            this.browsefolderBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.browsefolderBtn.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browsefolderBtn.Location = new System.Drawing.Point(112, 152);
            this.browsefolderBtn.Margin = new System.Windows.Forms.Padding(4);
            this.browsefolderBtn.Name = "browsefolderBtn";
            this.browsefolderBtn.Size = new System.Drawing.Size(230, 75);
            this.browsefolderBtn.TabIndex = 0;
            this.browsefolderBtn.Text = "Select Folder";
            this.browsefolderBtn.UseVisualStyleBackColor = false;
            this.browsefolderBtn.Click += new System.EventHandler(this.browseFolderBtn_Click);
            // 
            // CleanDirBtn
            // 
            this.CleanDirBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.CleanDirBtn.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CleanDirBtn.Location = new System.Drawing.Point(626, 299);
            this.CleanDirBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CleanDirBtn.Name = "CleanDirBtn";
            this.CleanDirBtn.Size = new System.Drawing.Size(230, 75);
            this.CleanDirBtn.TabIndex = 3;
            this.CleanDirBtn.Text = "Delete";
            this.CleanDirBtn.UseVisualStyleBackColor = false;
            this.CleanDirBtn.Click += new System.EventHandler(this.CleanDirBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 24F);
            this.label3.Location = new System.Drawing.Point(162, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 45);
            this.label3.TabIndex = 9;
            this.label3.Text = "Upload";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 24F);
            this.label4.Location = new System.Drawing.Point(682, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 45);
            this.label4.TabIndex = 10;
            this.label4.Text = "Delete";
            // 
            // browseDeleteButton
            // 
            this.browseDeleteButton.BackColor = System.Drawing.Color.SkyBlue;
            this.browseDeleteButton.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseDeleteButton.Location = new System.Drawing.Point(626, 152);
            this.browseDeleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.browseDeleteButton.Name = "browseDeleteButton";
            this.browseDeleteButton.Size = new System.Drawing.Size(230, 75);
            this.browseDeleteButton.TabIndex = 2;
            this.browseDeleteButton.Text = "Select Folder from Z:\\Kanaloa1";
            this.browseDeleteButton.UseVisualStyleBackColor = false;
            this.browseDeleteButton.Click += new System.EventHandler(this.browseDeleteButton_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.SkyBlue;
            this.label5.Location = new System.Drawing.Point(500, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(5, 444);
            this.label5.TabIndex = 12;
            // 
            // FileDeleteBox
            // 
            this.FileDeleteBox.Font = new System.Drawing.Font("Arial", 8F);
            this.FileDeleteBox.Location = new System.Drawing.Point(530, 233);
            this.FileDeleteBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FileDeleteBox.Multiline = true;
            this.FileDeleteBox.Name = "FileDeleteBox";
            this.FileDeleteBox.Size = new System.Drawing.Size(450, 60);
            this.FileDeleteBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(278, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 63);
            this.label1.TabIndex = 14;
            this.label1.Text = "Destiny Uploader";
            // 
            // StatusDelete
            // 
            this.StatusDelete.Font = new System.Drawing.Font("Arial", 18F);
            this.StatusDelete.Location = new System.Drawing.Point(533, 525);
            this.StatusDelete.Name = "StatusDelete";
            this.StatusDelete.Size = new System.Drawing.Size(416, 47);
            this.StatusDelete.TabIndex = 15;
            this.StatusDelete.Text = "Ready to Delete";
            this.StatusDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::CCDestinyUploader.Properties.Resources.LAVAlogoreisze3;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(421, 583);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 126);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(85, 122);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(288, 408);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(592, 122);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(288, 408);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.StatusDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FileDeleteBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.browseDeleteButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CleanDirBtn);
            this.Controls.Add(this.browsefolderBtn);
            this.Controls.Add(this.FileListBox);
            this.Controls.Add(this.StatusFile);
            this.Controls.Add(this.UploadBtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "CCDestinyUploader";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UploadBtn;
        private System.Windows.Forms.Label StatusFile;
        private System.Windows.Forms.TextBox FileListBox;
        private System.Windows.Forms.FolderBrowserDialog browseFolderUploadDialog;
        private System.Windows.Forms.Button browsefolderBtn;
        private System.Windows.Forms.Button CleanDirBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button browseDeleteButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FileDeleteBox;
        private System.Windows.Forms.FolderBrowserDialog browseFolderDeleteDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StatusDelete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}