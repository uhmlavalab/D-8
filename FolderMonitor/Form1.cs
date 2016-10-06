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
           

            monitor = new FolderMonitor();
            monitor.Run();

           
            fileBW.RunWorkerAsync();
            
        }

        private void button1_Click(object sender, EventArgs e) {
            // this.UseWaitCursor = true;
            // label1.Text = "Please wait, currently syncing.";
            // monitor.PerformSync();
            // System.Threading.Thread.Sleep(5000);
            //label1.Text = "Sync complete. Ready for next files";
            // this.UseWaitCursor = false;

            if (!statusBW.IsBusy) {
                statusBW.RunWorkerAsync();

            }

        }

        private void status_Click(object sender, EventArgs e) {

        }

        private void statusBW_DoWork(object sender, DoWorkEventArgs e) {
            this.UseWaitCursor = true;
            BackgroundWorker worker = sender as BackgroundWorker;
            worker.ReportProgress(0);
            this.Status.Text = ("Syncing. Please wait.");
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
                this.Status.Text = "Done. Ready for next file sync.";
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
                    list += " ";
                }
                FileListSetText(list);
            }
        }

        delegate void SetTextCallback(string text);
        private void FileListSetText(string text) {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.FileList.InvokeRequired) {
                SetTextCallback d = new SetTextCallback(FileListSetText);
                this.Invoke(d, new object[] { text });
            }
            else {
                this.FileList.Text = text;
            }
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void FileList_Click(object sender, EventArgs e) {

        }
    }

}
