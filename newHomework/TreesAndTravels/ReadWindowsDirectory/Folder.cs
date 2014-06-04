using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace ReadWindowsDirectory
{
    public class Folder
    {
        private string name;
        private List<File> files;
        private List<Folder> chieldFolders;

        public Folder(string name, List<File> files, List<Folder> chieldFolders)
        {
            this.name = name;
            this.files = files;
            this.chieldFolders = chieldFolders;
        }

        public Folder(string name):
            this(name, new List<File>(), new List<Folder>())
        {
        }
      
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                this.name = value;
            }
        }

        public List<File> Files
        {
            get
            {
                return this.files;
            }
            private set
            {
                this.files = value;
            }
        }

        public List<Folder> ChieldFolders
        {
            get
            {
                return this.chieldFolders;
            }
            private set
            {
                this.chieldFolders = value;
            }
        }

        public void AddFiles(string[] filesNames)
        {
             for (int i = 0; i < filesNames.Length; i++)
            {
                FileInfo newFileInfo = new FileInfo(filesNames[i]);
                long fileSize = newFileInfo.Length;
                this.files.Add(new File(filesNames[i], fileSize));
            }
        }

        public void AddChieldsFolders(Folder chieldFolder)
        {
            this.chieldFolders.Add(chieldFolder);
        }

        public long FolderSize()
        {
            long sum = 0;
            foreach (var file in this.files)
            {
                sum += file.Size;
            }

            foreach (var folder in this.chieldFolders)
            {
                sum += folder.FolderSize();
            }
            return sum;
        }
    }
}
