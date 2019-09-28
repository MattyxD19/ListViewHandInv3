using ListViewHandIn.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace ListViewHandIn.ViewModel
{
    class FileView
    {

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
    }
}
