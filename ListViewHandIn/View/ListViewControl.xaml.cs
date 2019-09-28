﻿using ListViewHandIn.ViewModel;
using System;
using System.Windows.Controls;

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
            
            foreach (var item in FileView.convertListToString())
            {
                ShowList.Items.Add(item);
            }
        }
    }
}