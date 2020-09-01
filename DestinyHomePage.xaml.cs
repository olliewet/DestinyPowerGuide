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
    /// Interaction logic for DestinyHomePage.xaml
    /// </summary>
    public partial class DestinyHomePage : Window
    {
        public DestinyHomePage()
        {
            InitializeComponent();
        }

        private void New_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Exp_Button_Click(object sender, RoutedEventArgs e)
        {
            var Cal = new MainWindow();
            this.Close();
            Cal.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var Cal = new MainWindow();
            this.Close();
            Cal.Show();
        }
    }
}
