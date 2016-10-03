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

        FolderMonitor monitor = new FolderMonitor();

        public Form1() {
            InitializeComponent();
            monitor.Run2();
        }

        private void button1_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            monitor.PerformSync();
            Cursor.Current = Cursors.Default;
        }
    }
}
