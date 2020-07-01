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

        private void val()
        {
            Helment_tb.Text = "750";
            Arms_tb.Text = "750";
            Chest_tb.Text = "750";
            Legs_tb.Text = "750";
            Class_tb.Text = "750";

            Prim_tb.Text = "750";
            Sec_tb.Text = "750";
            Power_tb.Text = "750";
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
                powertext.Content = roun.ToString();
                avg(_base, roun);             
                colourchanger(hel,arms,Chest,Class,Legs,Prim,Secondary,Power,ant);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void colourchanger(double hel, double arms, double chest, double Class, double Legs, double Prim , double secondary, double Power, double _base)
        {          
            int counter = 0;
            double basedown = Math.Floor(_base);
            if( hel < basedown)
            {
                Helment_tb.BorderBrush = System.Windows.Media.Brushes.Red;
                counter++;
            } 
            else
            {
                Helment_tb.BorderBrush = System.Windows.Media.Brushes.Green;
            }

            if (arms < basedown)
            {
                counter++;
                Arms_tb.BorderBrush = System.Windows.Media.Brushes.Red;
            }
            else
            {             
                Arms_tb.BorderBrush = System.Windows.Media.Brushes.Green;
            }

            if (chest < basedown)
            {
                counter++;
                Chest_tb.BorderBrush = System.Windows.Media.Brushes.Red;
            }
            else
            {
                Chest_tb.BorderBrush = System.Windows.Media.Brushes.Green;
            }

            if (Class < basedown)
            {
                counter++;
                Class_tb.BorderBrush = System.Windows.Media.Brushes.Red;
            }
            else
            {         
                Class_tb.BorderBrush = System.Windows.Media.Brushes.Green;
            }

            if (Legs < basedown)
            {
                counter++;
                Legs_tb.BorderBrush = System.Windows.Media.Brushes.Red;
            }
            else
            {               
                Legs_tb.BorderBrush = System.Windows.Media.Brushes.Green;
            }

            if (Prim < basedown)
            {
                counter++;
                Prim_tb.BorderBrush = System.Windows.Media.Brushes.Red;
            }
            else
            {
                
                Prim_tb.BorderBrush = System.Windows.Media.Brushes.Green;
            }

            if (secondary < basedown)
            {
                counter++;
                Sec_tb.BorderBrush = System.Windows.Media.Brushes.Red;
            }
            else
            {
                
                Sec_tb.BorderBrush = System.Windows.Media.Brushes.Green;
            }

            if (Power < basedown)
            {
                counter++;
                Power_tb.BorderBrush = System.Windows.Media.Brushes.Red;
            }
            else
            {
                Power_tb.BorderBrush = System.Windows.Media.Brushes.Green;
            }

            
            SuggestedUpgrade(counter);
        }
        private void SuggestedUpgrade(int counter)
        {
            switch (counter)
            {
                case 0: SuggestedRoute.Text = "No Pieces are under Leveled, Suggested Route Powerfuls ";
                    break; 
                case 1:
                    SuggestedRoute.Text = "One Piece is Under Leveled, Suggested Route Powerfuls or use tokens to get that one piece to the base level";
                    break;
                case 2:
                    SuggestedRoute.Text = "Two Piece is Under Leveled";
                    break;
                case 3:
                    SuggestedRoute.Text = "Three Piece is Under Leveled ";
                    break;
                case 4:
                    SuggestedRoute.Text = "Four Piece is Under Leveled ";
                    break;
                case 5:
                    SuggestedRoute.Text = "Five Piece is Under Leveled ";
                    break;
                case 6:
                    SuggestedRoute.Text = "Six Piece is Under Leveled ";
                    break;
                case 7:
                    SuggestedRoute.Text = "Seven Piece is Under Leveled ";
                    break;
                case 8:
                    SuggestedRoute.Text = "Eight Piece is Under Leveled ";
                    break;
            }
        }

        private void avg(double _base, double power )
        {
            double answer = _base - power;
            double an = answer * 8;          
            double increase = Math.Ceiling(an);
            if (power % 1 == 0)
            {
                IncreaseVal.Content = "8";
            }
            else
            {
                IncreaseVal.Content = increase.ToString();
            }

        }

        private void Fill_Values_Click(object sender, RoutedEventArgs e)
        {
            val();
        }
    }
}
