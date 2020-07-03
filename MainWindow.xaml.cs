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
        #region Misc Methods 
        //Used for clearing the textbox of text when application is opened
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

        //Used as testing to automatically fill the boxes with values 
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

        #endregion

        #region Buttons 
        //Button event which calculates the users power level and displays it to a label 
        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Storing The Levels From the input into appropriate variables
                double hel = double.Parse(Helment_tb.Text);
                double arms = double.Parse(Arms_tb.Text);
                double Chest = double.Parse(Chest_tb.Text);
                double Class = double.Parse(Class_tb.Text);
                double Legs = double.Parse(Legs_tb.Text);
                double Prim = double.Parse(Prim_tb.Text);
                double Secondary = double.Parse(Sec_tb.Text);
                double Power = double.Parse(Power_tb.Text);

                //Calculation to Find out the average Power Level of The User
                double cal = hel + arms + Chest + Class + Legs + Prim + Secondary + Power;
                double PlValue = cal / 8;

                //Rounding up the Power Level, Rounding Down the PowerLevel
                double plRoundUp = Math.Round(PlValue, 1);
                double plRoundDown = Math.Floor(PlValue);
                double _basePl = Math.Ceiling(PlValue);


                //Displaying The Power Level Code
                powertext.Content = plRoundUp.ToString();
                avg(_basePl, plRoundUp);             
                colourchanger(hel,arms,Chest,Class,Legs,Prim,Secondary,Power,PlValue);
                pb_power.Visibility = Visibility.Visible;
                pb_power.Minimum = plRoundDown;
                pb_power.Maximum = _basePl;
                pb_power.Value = PlValue;
               
            }
            catch
            {
                //Very Basic Error Prevention Needs Editing 
                MessageBox.Show("Error");
            }
        }
        //Button click that calls the value fill method, that fills the text boxes with values
        private void Fill_Values_Click(object sender, RoutedEventArgs e)
        {
            val();
        }

        #endregion

        #region Functionality Methods 
        //Method for changing the colour of the text box depending on the gear score of the piece of armour 
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
       
        //Method for suggesting how many pieces need upgrading and best suited way to upgrade piece 
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
                    SuggestedRoute.Text = "Six Piece is Under Leveled, Use Tokens to gather Pieces that drop at your base Power make sure to check on vendorengrams.xyz to see which vendors are dropping at base power";
                    break;
                case 3:
                    SuggestedRoute.Text = "Six Piece is Under Leveled, Use Tokens to gather Pieces that drop at your base Power make sure to check on vendorengrams.xyz to see which vendors are dropping at base power";
                    break;
                case 4:
                    SuggestedRoute.Text = "Six Piece is Under Leveled, Use Tokens to gather Pieces that drop at your base Power make sure to check on vendorengrams.xyz to see which vendors are dropping at base power";
                    break;
                case 5:
                    SuggestedRoute.Text = "Six Piece is Under Leveled, Use Tokens to gather Pieces that drop at your base Power make sure to check on vendorengrams.xyz to see which vendors are dropping at base power";
                    break;
                case 6:
                    SuggestedRoute.Text = "Six Piece is Under Leveled, Use Tokens to gather Pieces that drop at your base Power make sure to check on vendorengrams.xyz to see which vendors are dropping at base power";
                    break;
                case 7:
                    SuggestedRoute.Text = "Seven Piece is Under Leveled, Use Tokens to gather Pieces that drop at your base Power make sure to check on vendorengrams.xyz to see which vendors are dropping at base power ";
                    break;
                case 8:
                    SuggestedRoute.Text = "Eight Piece is Under Leveled, Use Tokens to gather Pieces that drop at your base Power make sure to check on vendorengrams.xyz to see which vendors are dropping at base power ";
                    break;
            }
        }

        //Method for working out the users average power level
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
        #endregion

        #region Links

        private void UseFulSites_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void EngramLink_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://vendorengrams.xyz/");
        }

        private void DestinyItem_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://destinyitemmanager.com/");
        }
        #endregion 

    }
}
