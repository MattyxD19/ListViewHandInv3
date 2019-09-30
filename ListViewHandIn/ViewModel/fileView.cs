using ListViewHandIn.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace ListViewHandIn.ViewModel
{
    class FileView
    {
        
        public static List<FileClass> LoadList()
        {
            List<FileClass> FileList = new List<FileClass>();
            FileClass files = new FileClass();

            foreach (var file in files.FilePath())
            {
                FileList.Add(new FileClass() { FileName = file.ToString(), FilePathImage = files.FilePathImage });
            }
            return FileList;
        }

        public static List<BitmapImage> LoadPictureBox()
        {
            List<BitmapImage> pictureList = new List<BitmapImage>();
            FileClass files = new FileClass();

            string[] images = System.IO.Directory.GetFiles(files.UseablePath());
           

            foreach (string path in images)
            {
                if (path.Substring(path.Length - 3) == "jpg")
                {
                    BitmapImage bitmap = new BitmapImage();
                    bitmap.BeginInit();
                    bitmap.UriSource = new Uri(path, UriKind.RelativeOrAbsolute);
                    bitmap.EndInit();
                    pictureList.Add(bitmap);
                }
               
            }

            return pictureList;
        }
    }
}
