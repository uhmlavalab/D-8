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

namespace FolderMonitor {
    public partial class Form1 : Form {

        FolderMonitor monitor;
        BackgroundWorker statusBW;
        ArrayList fileListHistory;
        DialogResult dialogResult;

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

            monitor = new FolderMonitor();
            //monitor.Run();

            FileListBox.BackColor = Color.White;
            folderBrowserDialog1.ShowNewFolderButton = false;

        }

        private void upload_Click(object sender, EventArgs e) {
            if (!statusBW.IsBusy) {
                Upload.Enabled = false;
                statusBW.RunWorkerAsync();
            }
            Upload.Enabled = true;
        }

        private void statusBW_DoWork(object sender, DoWorkEventArgs e) {
            this.UseWaitCursor = true;
            BackgroundWorker worker = sender as BackgroundWorker;
            worker.ReportProgress(0);
            monitor.PerformSync(folderBrowserDialog1.SelectedPath);
            this.UseWaitCursor = false;
            FileListBoxSetText("");
        }

        private void statusBW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            if ((e.Cancelled == true)) {
                this.Status.Text = "Canceled!";
            }

            else if (!(e.Error == null)) {
                this.Status.Text = ("Error: " + e.Error.Message);
            }

            else {
                this.Status.Text = "Status: Done. Ready for next folder upload.";
            }
        }
        private void statusBW_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            this.Status.Text = ("Uploading. Please wait.");
        }

        delegate void FileListBoxSetTextCallback(string text);
        private void FileListBoxSetText(string text) {
            if (this.FileList.InvokeRequired) {
                FileListBoxSetTextCallback d = new FileListBoxSetTextCallback(FileListBoxSetText);
                this.Invoke(d, new object[] { text });
            }
            else {
                this.FileListBox.Text = text;
            }
        }

        private void FileListBox_TextChanged(object sender, EventArgs e) {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e) {

        }

        private void browsefolder_Click(object sender, EventArgs e) {
            dialogResult = folderBrowserDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK) {
                ArrayList temp = new ArrayList();
                string foldername = folderBrowserDialog1.SelectedPath;
                FileListBoxSetText(foldername);
            }    
        }
    }

}
