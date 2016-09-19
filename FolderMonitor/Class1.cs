using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;


    class FolderMonitor {

        public static void Main() {
            Run();

        }

        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        public static void Run() {

            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = "C:\\Users\\Jack\\Documents\\GitHub\\TestFolderSync";
            /* Watch for changes in LastAccess and LastWrite times, and
               the renaming of files or directories. */
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
               | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            // Only watch text files.
            watcher.Filter = "*.*";
            watcher.IncludeSubdirectories = true;

            // Add event handlers.
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);

            // Begin watching.
            watcher.EnableRaisingEvents = true;

            // Wait for the user to quit the program.
            Console.WriteLine("Press \'q\' to quit the sample.");
            while (Console.Read() != 'q') ;
        }

        // Define the event handlers.
        private static void OnChanged(object source, FileSystemEventArgs e) {
            // Specify what is done when a file is changed, created, or deleted.
            Console.WriteLine("File: " + e.FullPath + " " + e.ChangeType);
            if (String.Compare(e.ChangeType.ToString(), "Changed") == 0) {
                copyFile(e.FullPath);
            }
        }

        private static void OnRenamed(object source, RenamedEventArgs e) {
            // Specify what is done when a file is renamed.
            Console.WriteLine("File: {0} renamed to {1}", e.OldFullPath, e.FullPath);
            copyFile(e.FullPath);
        }


        private static void copyFile(String FileSource) {
           // AppDomain.CurrentDomain.SetPrincipalPolicy(System.Security.Principal.PrincipalPolicy.WindowsPrincipal);
            
            
            
            WindowsIdentity idnt = new WindowsIdentity(username, passwords);
            WindowsImpersonationContext context = idnt.Impersonate();
            File.Copy(FileSource,"\\\\Cathy\\C$\\test.txt");
            context.Undo();
           // File.Copy(FileSource,"C:\\Users\\Jack\\Desktop\\"+"filename.txt", true);

        }

    }

