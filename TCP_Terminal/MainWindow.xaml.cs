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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TCP_Terminal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool server = false;
        bool client = false;
        string IP_Adress;


        public MainWindow()
        {
            InitializeComponent();
        }

         private void btnConnect_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void cbkServer_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void cbkClient_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
