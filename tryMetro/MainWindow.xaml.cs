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

namespace tryMetro
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        private void SignIn(object sender, RoutedEventArgs e)
        {

            var uname = username.Text;

            MessageBox.Show(uname);
            
        }

        private void Button_Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
