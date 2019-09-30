using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ListViewHandIn.Model
{
    public class FileClass : IFile
    {
        private string fileName;
        public string FileName
        {
            get { return fileName; }
            set
            {
                if (fileName != value)
                {
                    fileName = value;
                }
            }
        }

        private string filePathImage;

        public string FilePathImage
        {
            get { return filePathImage; }
            set
            {
                if (filePathImage != value)
                {
                    filePathImage = value;
                }
            }
        }

        public String UseablePath()
        {
            String path = "C:/Users/Mathias/Desktop/test";
            return path;
        }

        public List<String> FilePath()
        {
            List<String> BuildFilesCollection = new List<String>();
            string[] files = Directory.GetFiles(UseablePath());
            string[] folders = Directory.GetDirectories(UseablePath());

            foreach (string file in files)
            {
                BuildFilesCollection.Add(file);

            }

            foreach (string dir in folders)
            {
                BuildFilesCollection.Add(dir);
            }

            return BuildFilesCollection;
        }
    }
}
