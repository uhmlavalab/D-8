using System;
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
        BackgroundWorker bw;

        public Form1() {
            InitializeComponent();
            bw = new BackgroundWorker();
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
            monitor = new FolderMonitor();
            monitor.Run();
        }

        private void button1_Click(object sender, EventArgs e) {
           // this.UseWaitCursor = true;
           // label1.Text = "Please wait, currently syncing.";
           // monitor.PerformSync();
           // System.Threading.Thread.Sleep(5000);
            //label1.Text = "Sync complete. Ready for next files";
           // this.UseWaitCursor = false;

            if (!bw.IsBusy) {
                bw.RunWorkerAsync();

            }
        
        }

        private void status_Click(object sender, EventArgs e) {

        }

          private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            this.UseWaitCursor = true;
            BackgroundWorker worker = sender as BackgroundWorker;
            worker.ReportProgress(0);
            this.Status.Text = ("Syncing. Please wait.");
            monitor.PerformSync();
            this.UseWaitCursor = false;
        }
        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((e.Cancelled == true))
            {
                this.Status.Text = "Canceled!";
            }

            else if (!(e.Error == null))
            {
                this.Status.Text = ("Error: " + e.Error.Message);
            }

            else
            {
                this.Status.Text = "Done. Ready for next file sync.";
            }
        }
        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.Status.Text = ("Syncing. Please wait.");
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
        
}
