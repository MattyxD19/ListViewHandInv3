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
    /// Interaction logic for ListViewControl.xaml
    /// </summary>
    public partial class ListViewControl : UserControl
    {
        public ListViewControl()
        {
            InitializeComponent();

            /**
             *Reads the LoadList and adds the items
             *to the List View (ShowList)
             */ 

            ShowList.Items.Clear();
            foreach (var item in FileView.LoadList())
            {
                ShowList.Items.Add(item.FileName);
            }
        }

    }
}
