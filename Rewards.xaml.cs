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
using System.Windows.Shapes;

namespace Destiny2PowerLevelMax
{
    /// <summary>
    /// Interaction logic for Rewards.xaml
    /// </summary>
    public partial class Rewards : Window
    {
        public Rewards()
        {
            InitializeComponent();
            hidehead();
            tbReadOnly();
            
        }
        private void hidehead()
        {
            Info_Header.Visibility = Visibility.Collapsed;
            SoftCap_Header.Visibility = Visibility.Collapsed;
            PowerCap_Header.Visibility = Visibility.Collapsed;
            PinnCap_Header.Visibility = Visibility.Collapsed;
        }

        private void tbReadOnly()
        {
            softTB.IsReadOnly = true;
            powerTB.IsReadOnly = true;
            pinnTB.IsReadOnly = true;
        }
        private void Home_Click(object sender, RoutedEventArgs e)
        {
            var home = new optionselection();
            this.Close();
            home.Show();
        }

        private void Soft_Click(object sender, RoutedEventArgs e)
        {
            RewardInfo_TB.SelectedIndex = 1;
        }

        private void Power_Click(object sender, RoutedEventArgs e)
        {
            RewardInfo_TB.SelectedIndex = 2;

        }

        private void Pinn_Click(object sender, RoutedEventArgs e)
        {
            RewardInfo_TB.SelectedIndex = 3;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BackSoft_Click(object sender, RoutedEventArgs e)
        {
            RewardInfo_TB.SelectedIndex = 0;
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
