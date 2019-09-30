using ListViewHandIn.Model;
using ListViewHandIn.ViewModel;
using System.Collections.Generic;
using System.Windows.Controls;

namespace ListViewHandIn.View
{
    /// <summary>
    /// Interaction logic for ListBoxImages.xaml
    /// </summary>
    public partial class ListBoxImages : UserControl
    {
        public ListBoxImages()
        {
            InitializeComponent();

            /**
             * reads the LoadList as well
             * but the only items that are added
             * are the files ending on .jpg
             */

            List<FileClass> populateListBox = new List<FileClass>();
            ShowImage.Items.Clear();

            foreach (var item in FileView.LoadList())
            {
                if (item.FileName.Substring(item.FileName.Length - 3) == "jpg")
                {
                    populateListBox.Add(item);
                }
               
            }
            ShowImage.ItemsSource = populateListBox;
        }
    }
}
