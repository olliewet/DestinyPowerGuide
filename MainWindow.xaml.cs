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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Destiny2PowerLevelMax
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            clear();
        }

        private void clear()
        {
            Helment_tb.Clear();
            Arms_tb.Clear();
            Chest_tb.Clear();
            Legs_tb.Clear();
            Class_tb.Clear();

            Prim_tb.Clear();
            Power_tb.Clear();
            Power_tb.Clear();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                float hel = float.Parse(Helment_tb.Text);
                float arms = float.Parse(Arms_tb.Text);
                float Chest = float.Parse(Chest_tb.Text);
                float Class = float.Parse(Class_tb.Text);
                float Legs = float.Parse(Legs_tb.Text);
                float Prim = float.Parse(Prim_tb.Text);
                float Secondary = float.Parse(Power_tb.Text);
                float Power = float.Parse(Power_tb.Text);

                float cal = hel + arms + Chest + Class + Legs + Prim + Secondary + Power;
                float ant = cal / 8;


                Score_tb.Text = ant.ToString();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
