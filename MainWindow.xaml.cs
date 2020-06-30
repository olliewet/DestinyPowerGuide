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
            Sec_tb.Clear();
            Power_tb.Clear();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double hel = double.Parse(Helment_tb.Text);
                double arms = double.Parse(Arms_tb.Text);
                double Chest = double.Parse(Chest_tb.Text);
                double Class = double.Parse(Class_tb.Text);
                double Legs = double.Parse(Legs_tb.Text);
                double Prim = double.Parse(Prim_tb.Text);
                double Secondary = double.Parse(Sec_tb.Text);
                double Power = double.Parse(Power_tb.Text);

                double cal = hel + arms + Chest + Class + Legs + Prim + Secondary + Power;
                double ant = cal / 8;
                double roun = Math.Round(ant, 1);
                double _base = Math.Ceiling(ant);
                Score_tb.Text = roun.ToString();
                avg(_base, roun);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void avg(double _base, double power )
        {
            double answer = _base - power;
            double an = answer * 8;
            upgrade_tb.Text = an.ToString();
        }
    }
}
