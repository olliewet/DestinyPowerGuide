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
        //Variables 
        bool isAdmin = false; 
        public MainWindow()
        {
            InitializeComponent();
            clear();
            val();           
        }


        #region Misc Methods 
        /// <summary>
        /// Used for clearing the textbox of text when application is opened
        /// </summary>
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

        /// <summary>
        /// Automatically fill the boxes with default Values 
        /// </summary>
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

        /// <summary>
        /// Used to Check which Type of Content to display to the user
        /// </summary>
        /// <param name="power"></param>
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
                Armour newset = new Armour();
                newset.Helmet = double.Parse(Helment_tb.Text);
                newset.Arms = double.Parse(Arms_tb.Text);
                newset.Chest = double.Parse(Chest_tb.Text);
                newset.Legs = double.Parse(Legs_tb.Text);
                newset.Class = double.Parse(Class_tb.Text);
                newset.Primary = double.Parse(Prim_tb.Text);
                newset.Secondary = double.Parse(Sec_tb.Text);
                newset.Power = double.Parse(Power_tb.Text);
                
                //Calculation to Find out the average Power Level of The User
                double cal = newset.cal();
                double PlValue = cal / 8;

                //Rounding up the Power Level, Rounding Down the PowerLevel
                double plRoundUp = Math.Round(PlValue, 1);
                double plRoundDown = Math.Floor(PlValue);
                double _basePl = Math.Ceiling(PlValue);

                //Counter Used Counting How Many Pieces are Underleveled
                int counter = 0;

                //Displaying The Power Level Code
                powertext.Content = plRoundUp.ToString();
                Destiny2Logic.avg(_basePl, plRoundUp, IncreaseVal);
                colourchanger(counter, newset.Helmet , newset.Arms , newset.Chest , newset.Class , newset.Legs , newset.Primary , newset.Secondary , newset.Power, PlValue, plRoundUp);               
                PowerMethod(plRoundUp);

                //Progress Bar
                SettingProgressBar(plRoundDown, _basePl, PlValue);              
            }
            catch (Exception ex)
            {
                if(isAdmin == true)
                {
                    MessageBox.Show(ex.ToString());
                }
                else
                {                   
                    MessageBox.Show("Please Enter Valid Gear Scores Within the Provided Boxes");
                }

            }
        }

        /// <summary>
        /// Button, Which Calls the Method that fills the values of the input boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Fill_Values_Click(object sender, RoutedEventArgs e)
        {
            val();
        }

        /// <summary>
        /// Calling new Instance of ToDoList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToDo_Click(object sender, RoutedEventArgs e)
        {
            var ToDo = new ToDoList();
            this.Close();
            ToDo.Show();
        }
        #endregion

        #region Functionality Methods 

        /// <summary>
        /// Method for changing the colour of the text box depending on the gear score of the piece of armour
        /// </summary>
        /// <param name="counter"></param>
        /// <param name="hel"></param>
        /// <param name="arms"></param>
        /// <param name="chest"></param>
        /// <param name="Class"></param>
        /// <param name="Legs"></param>
        /// <param name="Prim"></param>
        /// <param name="secondary"></param>
        /// <param name="Power"></param>
        /// <param name="_base"></param>
        /// <param name="mainpower"></param>
        private void colourchanger(int counter, double hel, double arms, double chest, double Class, double Legs, double Prim , double secondary, double Power, double _base, double mainpower)
        {
            try
            {
                double basedown = Math.Floor(_base);
                Destiny2Logic.isItemLessThan(hel, basedown, counter, Helment_tb);
                Destiny2Logic.isItemLessThan(arms, basedown, counter, Arms_tb);
                Destiny2Logic.isItemLessThan(chest, basedown, counter, Chest_tb);
                Destiny2Logic.isItemLessThan(Legs, basedown, counter, Legs_tb);
                Destiny2Logic.isItemLessThan(Class, basedown, counter, Class_tb);
                Destiny2Logic.isItemLessThan(Prim, basedown, counter, Prim_tb);
                Destiny2Logic.isItemLessThan(secondary, basedown, counter, Sec_tb);
                Destiny2Logic.isItemLessThan(Power, basedown, counter, Power_tb);
                Destiny2Logic.SuggestedUpgrade(mainpower, counter, SuggestedRoute);
            }
            catch(Exception exe)
            {
                if (isAdmin == true)
                {
                    MessageBox.Show("Error with Colour Changer with the error message off {0}",exe.ToString());
                }
                else
                {
                    MessageBox.Show("Please Enter Valid Gear Scores Within the Provided Boxes");
                }
            }
        }

        /// <summary>
        /// Method use for Setting the progress on the progress Bars, depending on the values provided
        /// </summary>
        /// <param name="plRoundDown"></param>
        /// <param name="_basePl"></param>
        /// <param name="PlValue"></param>
        private void SettingProgressBar(double plRoundDown, double _basePl, double PlValue)
        {
            pb_power.Visibility = Visibility.Visible;
            pb_power.Minimum = plRoundDown;
            pb_power.Maximum = _basePl;
            pb_power.Value = PlValue;
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
        private void CG_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/document/d/1TM5B8R4xSlR-omci6kaSLJXz9qfqi5fo/edit");
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

        private void Admin_Click(object sender, RoutedEventArgs e)
        {
            if(isAdmin == false)
            {
                isAdmin = true;
                MessageBox.Show("Admin has been enabled.");
                TypeOfUser.Content = "Admin features";
            }
            else
            {
                isAdmin = false;
                MessageBox.Show("Admin has been disabled");
                TypeOfUser.Content = "Standard Users";
            }          
            
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = System.Windows.WindowState.Minimized;
        }
    }
}
