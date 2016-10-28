using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCDestinyUploader {
    public partial class Form1 : Form {

        FolderMonitor monitor;
        BackgroundWorker statusBW;
        ArrayList fileListHistory;
        DialogResult dialogResult;
        private String folderDeletePath = null;

        public Form1() {
            InitializeComponent();
            statusBW = new BackgroundWorker();
            statusBW.WorkerReportsProgress = true;
            statusBW.WorkerSupportsCancellation = true;
            statusBW.DoWork += new DoWorkEventHandler(statusBW_DoWork);
            statusBW.ProgressChanged += new ProgressChangedEventHandler(statusBW_ProgressChanged);
            statusBW.RunWorkerCompleted += new RunWorkerCompletedEventHandler(statusBW_RunWorkerCompleted);        

            FileListBox.ReadOnly = true;
            fileListHistory = new ArrayList();
            FileDeleteBox.ReadOnly = true;

            monitor = new FolderMonitor();
            monitor.WriteDirectoriesToFile();

            FileListBox.BackColor = Color.White;
            FileDeleteBox.BackColor = Color.White;
            browseFolderUploadDialog.ShowNewFolderButton = false;
            browseFolderDeleteDialog.ShowNewFolderButton = false;
            browseFolderDeleteDialog.SelectedPath = "Z:\\";

            pictureBox2.Image = Properties.Resources.arrow;
        }

        private void statusBW_DoWork(object sender, DoWorkEventArgs e) {
            this.UseWaitCursor = true;
            BackgroundWorker worker = sender as BackgroundWorker;
            worker.ReportProgress(0);
            monitor.PerformSync(browseFolderUploadDialog.SelectedPath);
            monitor.WriteDirectoriesToFile();
            this.UseWaitCursor = false;
        }

        private void statusBW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            if ((e.Cancelled == true)) {
                this.StatusFile.Text = "Canceled!";
            }
            else if (!(e.Error == null)) {
                this.StatusFile.Text = ("Error: " + e.Error.Message);
            }
            else {
                this.StatusFile.Text = "Upload Successful";
            }
        }
        private void statusBW_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            this.StatusFile.Text = ("Uploading. Please wait.");
        }

        delegate void FileListBoxSetTextCallback(string text);
        private void FileListBoxSetText(string text) {
            if (this.FileListBox.InvokeRequired) {
                FileListBoxSetTextCallback d = new FileListBoxSetTextCallback(FileListBoxSetText);
                this.Invoke(d, new object[] { text });
            }
            else {
                this.FileListBox.Text = text;
            }
        }

        delegate void FileDeleteBoxSetTextCallback(string text);
        private void FileDeleteBoxSetText(string text) {
            if (this.FileDeleteBox.InvokeRequired) {
                FileDeleteBoxSetTextCallback d = new FileDeleteBoxSetTextCallback(FileDeleteBoxSetText);
                this.Invoke(d, new object[] { text });
            }
            else {
                this.FileDeleteBox.Text = text;
            }
        }

        private void FileListBox_TextChanged(object sender, EventArgs e) {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e) {

        }

        private void browseFolderBtn_Click(object sender, EventArgs e) {
            dialogResult = browseFolderUploadDialog.ShowDialog();
            if (dialogResult == DialogResult.OK) {
                ArrayList temp = new ArrayList();
                string foldername = browseFolderUploadDialog.SelectedPath;
                FileListBoxSetText(foldername);
            }    
        }

        private void uploadBtn_Click(object sender, EventArgs e) {
            if (!statusBW.IsBusy && !String.IsNullOrWhiteSpace(browseFolderUploadDialog.SelectedPath)) {
                UploadBtn.Enabled = false;
                statusBW.RunWorkerAsync();
            }
            UploadBtn.Enabled = true;
        }

        private void CleanDirBtn_Click(object sender, EventArgs e) {
            if (folderDeletePath == null) {
                return;
            }
            if (String.Compare(folderDeletePath.Substring(0, 3), "Z:\\") != 0) {
                return;
            }

            CleanDirBtn.Enabled = false;
            this.StatusDelete.Text = "Deleting.";
            UseWaitCursor = true;
            monitor.DirectoryDelete(folderDeletePath);
            monitor.CleanFolders();
            CleanDirBtn.Enabled = true;
            UseWaitCursor = false;
            this.StatusDelete.Text = "Delete Successful";        }

        private void browseDeleteButton_Click(object sender, EventArgs e) {
            dialogResult = browseFolderDeleteDialog.ShowDialog();
            if (dialogResult == DialogResult.OK) {
                ArrayList temp = new ArrayList();
                string foldername = browseFolderDeleteDialog.SelectedPath;
                FileDeleteBoxSetText(foldername);
                folderDeletePath = foldername;
            }    
        }

        private void label4_Click(object sender, EventArgs e) {

        }
    }
}
