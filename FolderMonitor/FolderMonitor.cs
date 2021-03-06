﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/// <summary>
/// Monitors a specified directory and copies files/folders to multiple directories.
/// </summary>

namespace CCDestinyUploader {
    class FolderMonitor {

        private const bool DEBUG = false;

        private FileSystemWatcher watcher;

        private String directorySourcePath;
        private String[] directoryDestinationPathList;

        private ArrayList newFileList = new ArrayList();

        /// <summary>
        /// Constructor
        /// </summary>
        public FolderMonitor() {
            if (DEBUG) {
               directorySourcePath = "C:\\Users\\Jack\\Desktop\\DestinyDropbox";
               directoryDestinationPathList = new String[] { "C:\\Users\\Jack\\Desktop\\test\\", "C:\\Users\\Jack\\Desktop\\test2\\" };
            }
            else {
                directorySourcePath = "C:\\Users\\LAVA\\Desktop\\DestinyDropbox";
                directoryDestinationPathList = new String[]  { "\\\\Kanaloa1\\Share\\", "\\\\Kanaloa2\\Share\\", "\\\\Kanaloa3\\Share\\",
                    "\\\\Kanaloa4\\Share\\", "\\\\Kanaloa5\\Share\\", "\\\\Kanaloa6\\Share\\", "\\\\Kanaloa7\\Share\\", "\\\\Kanaloa8\\Share\\" };
            }
        }

        /// <summary>
        /// Creates folder monitor object with specified source folder.
        /// </summary>
        /// <param name="sourceFolderPath"></param>
        /// <param name="destinationFolderPath"></param>
        public FolderMonitor(String sourceFolderPath) {
            directorySourcePath = sourceFolderPath;
            
        }

        /// <summary>
        /// Runs FileSystemWatcher on a specified source directory.
        /// Calls methods when the water gets notified on different changes to the directory.
        /// </summary>
        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        public void Run() {
            watcher = new FileSystemWatcher();
            watcher.Path = directorySourcePath;

            watcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.LastWrite | NotifyFilters.LastAccess;
            watcher.Filter = "";
            watcher.IncludeSubdirectories = true;

            // Add event handlers.
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnCreated);
            watcher.Deleted += new FileSystemEventHandler(OnDeleted);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);


            // Begin watching.
            watcher.EnableRaisingEvents = true;
        }

        // Define the event handlers.
        private void OnChanged(object source, FileSystemEventArgs e) {
            if (IsFileInRootFolder(e.FullPath)) {
                if (!newFileList.Contains(e.FullPath)) {
                    newFileList.Add(e.FullPath);
                } 
            }
        }

        private void OnCreated(object source, FileSystemEventArgs e) {
            if (IsFileInRootFolder(e.FullPath)) {
                if (!newFileList.Contains(e.FullPath)) {
                    newFileList.Add(e.FullPath);
                }
            }
        }

        private void OnDeleted(object source, FileSystemEventArgs e) {
            //Console.WriteLine("File: " + e.FullPath + " " + e.ChangeType);
            DeleteFileRoutine(e.FullPath);
        }

        private void OnRenamed(object source, RenamedEventArgs e) {
            if (IsFileInRootFolder(e.FullPath)) {
                if (!newFileList.Contains(e.FullPath)) {
                    newFileList.Add(e.FullPath);
                }
            }
        }

        public bool PerformSync() {
            foreach(String file in newFileList) {
                CopyFileRoutine(file);
            }
            newFileList.Clear();
            return true;
        }

        public bool PerformSync(String dir) {      
            CopyFileRoutine(dir);
            return true;
        }

        /// <summary>
        /// A copy routine that will inititate a file/directory copy from source to 8 destination folders.
        /// </summary>
        /// <param name="fileSource">Path to source file/directory.</param>
        private void CopyFileRoutine(String fileSource) {
            Task copy0 = Task.Factory.StartNew(() => CopyFile(fileSource, 0));
            if (!DEBUG) {
                Task copy1 = Task.Factory.StartNew(() => CopyFile(fileSource, 1));
                Task copy2 = Task.Factory.StartNew(() => CopyFile(fileSource, 2));
                Task copy3 = Task.Factory.StartNew(() => CopyFile(fileSource, 3));
                Task copy4 = Task.Factory.StartNew(() => CopyFile(fileSource, 4));
                Task copy5 = Task.Factory.StartNew(() => CopyFile(fileSource, 5));
                Task copy6 = Task.Factory.StartNew(() => CopyFile(fileSource, 6));
                Task copy7 = Task.Factory.StartNew(() => CopyFile(fileSource, 7));

                Task.WaitAll(copy0, copy1, copy2, copy3, copy4, copy5, copy6, copy7);
            }
        }

        private void DeleteFileRoutine(String fileSource) {
            Task copy0 = Task.Factory.StartNew(() => DeleteFile(fileSource, 0));
            if (!DEBUG) {
                Task copy1 = Task.Factory.StartNew(() => DeleteFile(fileSource, 1));
                Task copy2 = Task.Factory.StartNew(() => DeleteFile(fileSource, 2));
                Task copy3 = Task.Factory.StartNew(() => DeleteFile(fileSource, 3));
                Task copy4 = Task.Factory.StartNew(() => DeleteFile(fileSource, 4));
                Task copy5 = Task.Factory.StartNew(() => DeleteFile(fileSource, 5));
                Task copy6 = Task.Factory.StartNew(() => DeleteFile(fileSource, 6));
                Task copy7 = Task.Factory.StartNew(() => DeleteFile(fileSource, 7));

                Task.WaitAll(copy0, copy1, copy2, copy3, copy4, copy5, copy6, copy7);
            }
        }

        /// <summary>
        /// Copies a file from source to destination folder indicated by an index from the list of destination directories.
        /// </summary>
        /// <param name="fileSource">Path of source file/directory.</param>
        /// <param name="destinationDirectoryIndex">Index of directory to copy to.</param>
        private void CopyFile(String fileSource, int destinationDirectoryIndex) {
            String directoryDestinationPath = directoryDestinationPathList[destinationDirectoryIndex];
            FileAttributes attr = File.GetAttributes(fileSource);
            if (attr.HasFlag(FileAttributes.Directory)) {
                DirectoryCopy(fileSource, directoryDestinationPath, true, true);
            }
            else {
                bool fileInUse = true;
                while (fileInUse) {
                    if (!isFileLocked(new FileInfo(fileSource))) {
                        String fileName = fileSource.Substring(fileSource.LastIndexOf("\\") + 1);
                        File.Copy(fileSource, directoryDestinationPath + fileName, true);
                        fileInUse = false;
                    }
                    Console.WriteLine(fileSource + " Is locked");
                }
            }
        }
        

        /// <summary>
        /// Checks to see if a file is not in the root directory.
        /// </summary>
        /// <param name="fileSource">Path to file.</param>
        /// <returns>True if in another foledr besides root. False otherwise.</returns>
        private bool IsFileInRootFolder(String fileSource) {
            String fileFolder = fileSource.Substring(0, fileSource.LastIndexOf("\\"));
            if (String.Compare(directorySourcePath, fileFolder, true) == 0) {
                return true;
            } else {
                return false;
            }
        }

        /// <summary>
        /// Copies a directory and its contents to the destination directory.
        /// </summary>
        /// <param name="sourceDirName">Path to the directory to be copied.</param>
        /// <param name="destDirName">Path to destination directory.</param>
        /// <param name="copySubDirs">Copy subdirectories if true.</param>
        private void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs, bool keepFolderName) {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            DirectoryInfo[] dirs = dir.GetDirectories();
            String fullFolderName;
            if (keepFolderName == true) {
                String fileName = sourceDirName.Substring(sourceDirName.LastIndexOf("\\") + 1);
                fullFolderName = destDirName + fileName;

            } else {
                fullFolderName = destDirName;
            }

            if (Directory.Exists(fullFolderName)) {
                DirectoryDelete(fullFolderName);
            }

            Directory.CreateDirectory(fullFolderName);

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files) {
                string temppath = Path.Combine(fullFolderName, file.Name);
                bool fileInUse = true;
                while (fileInUse) {
                    if (!isFileLocked(file)) {
                        try {
                            file.CopyTo(temppath, true);
                        } catch (UnauthorizedAccessException) {
                            Console.WriteLine("Unable to access " + temppath);
                        }
                        fileInUse = false;
                    }
                }
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs) {
                foreach (DirectoryInfo subdir in dirs) {
                    string temppath = Path.Combine(fullFolderName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs, false);
                }
            }

        }

        /// <summary>
        /// Checks to see if a file is locked.
        /// </summary>
        /// <param name="file">Path to the file.</param>
        /// <returns>True if locked, false otherwise.</returns>
        private bool isFileLocked(FileInfo file) {
            FileStream stream = null;

            try {
                stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.Read);
            } catch (IOException) {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                return true;
            } finally {
                if (stream != null)
                    stream.Close();
            }

            //file is not locked
            return false;
        }

        /// <summary>
        /// Deletes a directory or file in the destination folder given a path from the source folder.
        /// </summary>
        /// <param name="fileSource">Full Path to the file/directory.</param>
        private void DeleteFile(String fileSource, int destinationDirectoryIndex) {
            String directoryDestinationPath = directoryDestinationPathList[destinationDirectoryIndex];

            String fileName = fileSource.Substring(directorySourcePath.Length);
                try {
                    FileAttributes attr = File.GetAttributes(directoryDestinationPath + fileName);
                    if (attr.HasFlag(FileAttributes.Directory)) {
                        DirectoryDelete(directoryDestinationPath + fileName);
                        Console.WriteLine("Deleted " + fileSource);
                    } else {
                        if (!isFileLocked(new FileInfo(fileSource))) {
                            File.Delete(directoryDestinationPath + fileName);
                            Console.WriteLine("Delete file " + fileSource);
                        } else {
                            Console.WriteLine(fileSource + " is locked. Cannot delete.");
                        }
                    }
                } catch (FileNotFoundException) {
                    Console.WriteLine("Delete error. Could not find " + fileSource + " Skipping.");
                } catch (DirectoryNotFoundException) {
                    Console.WriteLine("Delete error. Could not find " + fileSource + " Skipping.");
                } catch (UnauthorizedAccessException) {
                    Console.WriteLine("Unable to access " + fileSource + " for deletion. Skipping.");
                }
        }

        /// <summary>
        /// Deletes a directory and its contents.
        /// </summary>
        /// <param name="deleteDir">Full Path to directory to delete.</param>
        public void DirectoryDelete(string deleteDir) {
            DirectoryInfo dir = new DirectoryInfo(deleteDir);
            if (!dir.Exists) {
                return;
            }
            foreach (FileInfo file in dir.GetFiles()) {
                try {
                    if (!isFileLocked(file)) {
                        file.Delete();
                    } else {
                        Console.WriteLine("Unable to access " + file + " for deletion. Skipping.");
                    }
                } catch (FileNotFoundException) {
                    Console.WriteLine("Delete error. Could not find " + file + " Skipping.");
                } catch (UnauthorizedAccessException) {
                    Console.WriteLine("Unable to access " + file.ToString() + " for deletion. Skipping.");
                }
            }
            try {
                dir.Delete(true);
            } catch (DirectoryNotFoundException) {
                Console.WriteLine("Delete error. Could not find " + deleteDir + " Skipping.");
            }
        }

        public ArrayList getNewFileList() {
            return newFileList;
        }

        public void CleanFolders() {
            DirectoryInfo masterDir = new DirectoryInfo(directoryDestinationPathList[0]);
            DirectoryInfo[] masterSubDirs = masterDir.GetDirectories();
            List<String> masterSubDirsString = new List<String>();

            foreach (DirectoryInfo dir in masterSubDirs) {
                masterSubDirsString.Add(dir.Name);
            }

            for(int i = 1; i < directoryDestinationPathList.Length; i++) {
                DirectoryInfo childDir = new DirectoryInfo(directoryDestinationPathList[i]);
                DirectoryInfo[] childSubDirs = childDir.GetDirectories();

                List<String> childSubDirString = new List<String>();
                foreach(DirectoryInfo dir in childSubDirs) {
                    childSubDirString.Add(dir.Name);
                }

                List<String> removeDirs = childSubDirString.Except(masterSubDirsString).ToList();

                foreach(String dir in removeDirs) {
                    DirectoryDelete(directoryDestinationPathList[i]+ dir);
                }
            }
        }

        public void WriteDirectoriesToFile() {
            DirectoryInfo masterDir = new DirectoryInfo(directoryDestinationPathList[0]);
            DirectoryInfo[] subDirs = masterDir.GetDirectories();
    
            StreamWriter file = new StreamWriter(directoryDestinationPathList[0] + "fileIndex.destiny");

            foreach (DirectoryInfo dir in subDirs) {
                file.WriteLine(dir.Name.ToString());
            }

            file.Close();
        }
    }
}
