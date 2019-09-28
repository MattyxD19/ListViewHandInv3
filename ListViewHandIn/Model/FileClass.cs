using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewHandIn.Model
{
    public class FileClass : IFile
    {
        /*
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

        public String[] FolderPath()
        {
            String path = "F:/Test";
            //String[] folderDir = new Directory.GetFiles(path).GetFiles().Select(o => o.Name).ToArray();
            //string[] dir = new Directory.GetFiles(path).Select(File => Path.GetFileName(File)).toArray();

            string[] folder = Directory.GetDirectories(path).Select(file => Path.GetFileName(file)).ToArray();


            return folder;
        }

        public String[] FilePath()
        {
            String path = "F:/Test";
            //String[] folderDir = new Directory.GetFiles(path).GetFiles().Select(o => o.Name).ToArray();
            //string[] dir = new Directory.GetFiles(path).Select(File => Path.GetFileName(File)).toArray();

            string[] files = Directory.GetFiles(path).Select(file => Path.GetFileName(file)).ToArray();


            return files;


        }
        */
    }
}
