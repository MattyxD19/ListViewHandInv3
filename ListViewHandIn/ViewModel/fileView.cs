using ListViewHandIn.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewHandIn.ViewModel
{
    class FileView
    {  
        /*
        public List<FileClass> Files
        {
            get; set;
        }

        public static List<FileClass> LoadList()
        {
            List<FileClass> FileList = new List<FileClass>();

            FileClass files = new FileClass();
            String[] folderFiles = files.FolderPath();
            String[] textFiles = files.FilePath();

            foreach (var folder in folderFiles)
            {
                Console.WriteLine(folder);
                FileList.Add(new FileClass() { FileName = folder.ToString() });
            }

            foreach (var file in textFiles)
            {
                FileList.Add(new FileClass() { FileName = file.ToString() });
            }

            return FileList;
        }

        public static List<String> convertListToString()
        {
            List<String> convertedList = new List<String>();

            foreach (var item in LoadList())
            {
                convertedList.Add(item.FileName.ToString());
            }

            return convertedList;
        }
        */


    }
}
