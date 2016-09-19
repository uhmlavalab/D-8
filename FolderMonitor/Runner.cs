using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Main loop of the program. Simply runs the Folder monitor class.
/// </summary>
class Runner {
    
    [STAThread]
    public static void Main() {
        FolderMonitor folderMonitor = new FolderMonitor();
        folderMonitor.Run();
    }
}

