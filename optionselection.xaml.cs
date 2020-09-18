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

namespace Destiny2PowerLevelMax
{
    /// <summary>
    /// Interaction logic for optionselection.xaml
    /// </summary>
    public partial class optionselection : Window
    {
        public optionselection()
        {
            InitializeComponent();
        }

        private void Option1_btn_Click(object sender, RoutedEventArgs e)
        {
            var Cal = new MainWindow();
            this.Close();
            Cal.Show();
        }

        private void Option2_btn_Click(object sender, RoutedEventArgs e)
        {
            var todo = new ToDoList();
            this.Close();
            todo.Show();
        }

        private void Option3_btn_Click(object sender, RoutedEventArgs e)
        {
            var rewards = new Rewards();
            this.Close();
            rewards.Show();
        }

        private void Option4_btn_Click(object sender, RoutedEventArgs e)
        {
            var prep = new Preparation();
            this.Close();
            prep.Show();
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
