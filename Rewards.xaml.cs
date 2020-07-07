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
        }
        private void hidehead()
        {
            SoftCap_Header.Visibility = Visibility.Collapsed;
            PowerCap_Header.Visibility = Visibility.Collapsed;
            PinnCap_Header.Visibility = Visibility.Collapsed;
        }
        private void Home_Click(object sender, RoutedEventArgs e)
        {
            var home = new MainWindow();
            this.Close();
            home.Show();
        }

        private void Soft_Click(object sender, RoutedEventArgs e)
        {
            RewardInfo_TB.SelectedIndex = 0;
        }

        private void Power_Click(object sender, RoutedEventArgs e)
        {
            RewardInfo_TB.SelectedIndex = 1;

        }

        private void Pinn_Click(object sender, RoutedEventArgs e)
        {
            RewardInfo_TB.SelectedIndex = 2;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
