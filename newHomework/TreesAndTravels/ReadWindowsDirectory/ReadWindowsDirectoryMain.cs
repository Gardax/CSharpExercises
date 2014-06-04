using System;
using System.Linq;
using System.IO;

namespace ReadWindowsDirectory
{
    class ReadWindowsDirectoryMain
    {
        public static void Main()
        {
            string rootName = @"C:\Windows";
            string dirSearchSum = @"C:\Windows\Boot";
            Folder rootFolder = new Folder(rootName);
            Folder someDirectory = new Folder(dirSearchSum);
            CreateThree(rootFolder);

            Console.WriteLine("Folder {0}", dirSearchSum);
            Console.WriteLine("Size of folder is {0} bites", sumOfFileSizesInDirectory(rootFolder, someDirectory));
        }

        public static void CreateThree(Folder folder)
        {
            try
            {
                string[] filesName = Directory.GetFiles(folder.Name);
                folder.AddFiles(filesName);
                var dirs = Directory.GetDirectories(folder.Name);
                foreach (var dir in dirs)
                {
                    Folder newfolder = new Folder(dir);
                    folder.AddChieldsFolders(newfolder);
                    CreateThree(newfolder);
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("No access to {0} directory", folder.Name);
                return;
            }
        }

        public static long sumOfFileSizesInDirectory(Folder rootFolder, Folder searchFolder)
        {
            long sum = 0;

            if (rootFolder.Name == searchFolder.Name)
            {
                sum = rootFolder.FolderSize();
                return sum;
            }

            foreach (var folder in rootFolder.ChieldFolders)
            {
                if (folder.Name == searchFolder.Name)
                {
                    sum = folder.FolderSize();
                    return sum;
                }
                else
                {
                    sumOfFileSizesInDirectory(folder, searchFolder);
                }
            }

            return sum;
        }
    }
}
