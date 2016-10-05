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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 32);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sync";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Status
            // 
            this.Status.Location = new System.Drawing.Point(41, 122);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(284, 68);
            this.Status.TabIndex = 1;
            this.Status.Text = "Ready to sync.";
            this.Status.Click += new System.EventHandler(this.status_Click);
            // 
            // FileList
            // 
            this.FileList.Location = new System.Drawing.Point(41, 190);
            this.FileList.Name = "FileList";
            this.FileList.Size = new System.Drawing.Size(306, 110);
            this.FileList.TabIndex = 2;
            this.FileList.Text = "File List";
            this.FileList.Click += new System.EventHandler(this.FileList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.FileList);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "FolderSync";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label FileList;
    }
}