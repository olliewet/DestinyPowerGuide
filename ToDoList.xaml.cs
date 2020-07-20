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
    /// Interaction logic for ToDoList.xaml
    /// </summary>
    public partial class ToDoList : Window
    {
        public ToDoList()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            var home = new MainWindow();
            this.Close();
            home.Show();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            if(Pinn.IsChecked == true)
            {
                ToDoBox.Items.Add("Pinn");
            }
        }
    }
}
