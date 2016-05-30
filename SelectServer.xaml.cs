﻿using System;
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
using System.Windows.Shapes;

namespace Mattermost_WPF
{
    /// <summary>
    /// Interaction logic for SelectServer.xaml
    /// </summary>
    public partial class SelectServer : Window
    {
        public SelectServer()
        {
            InitializeComponent();
        }

        private void AddNewServerButton_Click(object sender, RoutedEventArgs e)
        {
            EditServer editServer = new EditServer();
            editServer.ShowDialog();
        }
    }
}
