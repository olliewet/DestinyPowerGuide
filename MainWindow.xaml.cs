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
        public PowerSum sum {get;set;} 
        public MainWindow()
        {
            InitializeComponent();
           //sum = new PowerSum { Helmet = "1002", Arms = "1000", Class = "1000", Chest = "1000", Legs = "1000", Power = "1000", Prim = "1000", Sec = "1000" };
          // this.DataContext = sum;
            clear();
            val();
            
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
            Helment_tb.Text = "1000";
            Arms_tb.Text = "1000";
            Chest_tb.Text = "1000";
            Legs_tb.Text = "1000";
            Class_tb.Text = "1000";

            Prim_tb.Text = "1000";
            Sec_tb.Text = "1000";
            Power_tb.Text = "1000";
        }
        private void PowerMethod(double power)
        {
            if (power < 1000)
            {
                TypeOfGrind.Content = "Softcap Grind";
            }
            else if (power >= 1000 && power < 1050)
            {
                TypeOfGrind.Content = "Powerful Grind";
            } 
            else if ( power >= 1050 )
            {
                TypeOfGrind.Content = "Pinnacle Grind";
            }
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

                int counter = 0;
                //Displaying The Power Level Code
                powertext.Content = plRoundUp.ToString();
                Destiny2Logic.avg(_basePl, plRoundUp, IncreaseVal);             
                colourchanger(counter,hel,arms,Chest,Class,Legs,Prim,Secondary,Power,PlValue,plRoundUp);
                PowerMethod(plRoundUp);

                //Progress Bar
                pb_power.Visibility = Visibility.Visible;
                pb_power.Minimum = plRoundDown;
                pb_power.Maximum = _basePl;
                pb_power.Value = PlValue;

                
            }
            catch
            {
                //Very Basic Error Prevention Needs Editing 
                MessageBox.Show("Please Enter Valid Gear Scores Within the Provided Boxes");
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
        private void colourchanger(int counter, double hel, double arms, double chest, double Class, double Legs, double Prim , double secondary, double Power, double _base, double mainpower)
        {                     
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

            
            Destiny2Logic.SuggestedUpgrade(mainpower,counter, SuggestedRoute);
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

        #region New Window Buttons 
        private void Rewards_Click(object sender, RoutedEventArgs e)
        {
            var rewards = new Rewards();
            this.Close();
            rewards.Show();
        }

        private void Prep_Click(object sender, RoutedEventArgs e)
        {
            var Prep = new Preparation();
            this.Close();
            Prep.Show();
        }
        #endregion
   

        private void ToDo_Click(object sender, RoutedEventArgs e)
        {
            var ToDo = new ToDoList();
            this.Close();
            ToDo.Show();
        }
    }
}
