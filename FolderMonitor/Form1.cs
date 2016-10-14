using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderMonitor {
    public partial class Form1 : Form {

        FolderMonitor monitor;
        BackgroundWorker statusBW;
        BackgroundWorker fileBW;
        ArrayList fileListHistory;

        public Form1() {
            InitializeComponent();
            statusBW = new BackgroundWorker();
            statusBW.WorkerReportsProgress = true;
            statusBW.WorkerSupportsCancellation = true;
            statusBW.DoWork += new DoWorkEventHandler(statusBW_DoWork);
            statusBW.ProgressChanged += new ProgressChangedEventHandler(statusBW_ProgressChanged);
            statusBW.RunWorkerCompleted += new RunWorkerCompletedEventHandler(statusBW_RunWorkerCompleted);

            fileBW = new BackgroundWorker();
            fileBW.WorkerReportsProgress = true;
            fileBW.DoWork += new DoWorkEventHandler(fileBW_DoWork);

            FileListBox.ReadOnly = true;
            fileListHistory = new ArrayList();

            monitor = new FolderMonitor();
            monitor.Run();

            FileListBox.BackColor = Color.White;
           
            fileBW.RunWorkerAsync();
            
        }

        private void button1_Click(object sender, EventArgs e) {
            if (!statusBW.IsBusy) {
                button1.Enabled = false;
                statusBW.RunWorkerAsync();

            }
            button1.Enabled = true;

        }

        private void status_Click(object sender, EventArgs e) {

        }

        private void statusBW_DoWork(object sender, DoWorkEventArgs e) {
            this.UseWaitCursor = true;
            BackgroundWorker worker = sender as BackgroundWorker;
            worker.ReportProgress(0);
            monitor.PerformSync();
            this.UseWaitCursor = false;
        }
        private void statusBW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            if ((e.Cancelled == true)) {
                this.Status.Text = "Canceled!";
            }

            else if (!(e.Error == null)) {
                this.Status.Text = ("Error: " + e.Error.Message);
            }

            else {
                this.Status.Text = "Status: Done. Ready for next file sync.";
            }
        }
        private void statusBW_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            this.Status.Text = ("Syncing. Please wait.");
        }

        private void fileBW_DoWork(object sender, DoWorkEventArgs e) {
            BackgroundWorker worker = sender as BackgroundWorker;
            while (!worker.CancellationPending) {
                
                ArrayList temp = monitor.getNewFileList();

              
          
                String list = "";

                for (int i = 0; i < temp.Count; i++) {
                    list += temp[i].ToString();
                    list += "\r\n";
                }
                FileListBoxSetText(list);
            }
        }

        delegate void SetTextCallback(string text);
        private void FileListBoxSetText(string text) {
            if (this.FileList.InvokeRequired) {
                SetTextCallback d = new SetTextCallback(FileListBoxSetText);
                this.Invoke(d, new object[] { text });
            }
            else {
                this.FileListBox.Text = text;
            }
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void FileList_Click(object sender, EventArgs e) {

        }

        private void FileListBox_TextChanged(object sender, EventArgs e) {

        }
    }

}
