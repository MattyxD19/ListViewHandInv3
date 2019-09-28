using ListViewHandIn.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace ListViewHandIn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<ShowText> textList = new List<ShowText>();
        List<ShowImages> imageList = new List<ShowImages>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListViewControl_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            DialogResult result = FBD.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                string[] textFiles = Directory.GetFiles(FBD.SelectedPath, "*.txt");
                string[] imageFiles = Directory.GetFiles(FBD.SelectedPath, "*.jpg");

                string[] dirs = Directory.GetDirectories(FBD.SelectedPath);

                //Handel the text files
                foreach (string file in textFiles)
                {
                    textList.Add(new ShowText() { MyText = file });

                }

                foreach (string dir in dirs)
                {
                    textList.Add(new ShowText() { MyText = dir });
                }


                //Handel the Image files 
                foreach (string file in imageFiles)
                {
                    imageList.Add(new ShowImages() { MyImage = file });

                }

                foreach (string dir in dirs)
                {
                    imageList.Add(new ShowImages() { MyImage = dir });
                }
            }


            listbox2.ItemsSource = textList;
            listbox1.ItemsSource = imageList;
        }
    }
}
