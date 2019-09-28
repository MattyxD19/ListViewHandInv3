using ListViewHandIn.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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

            String substringJPG = "jpg";

            if (FileView.convertListToString() != null)
            {

                foreach (var item in FileView.convertListToString())
                {
                    if (item.Substring(item.Length - 3) == substringJPG)
                    {
                        ShowImages.Items.Add(item);
                    }
                }
                
            }
            ShowImages.ItemsSource = FileView.LoadList();
        }
    }
}
