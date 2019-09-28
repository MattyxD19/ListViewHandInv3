using System;
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

        public String[] FolderPath()
        {
            
            string[] folder = Directory.GetDirectories(UseablePath()).Select(file => Path.GetFileName(file)).ToArray();
            return folder;
        }

        public String[] FilePath()
        {
            string[] files = Directory.GetFiles(UseablePath()).Select(file => Path.GetFileName(file)).ToArray();
            return files;
        }
    }
}
