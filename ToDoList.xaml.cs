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

        #region Variables 
        double timecounter = 0;
        #endregion

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            var home = new optionselection();
            this.Close();
            home.Show();
        }

        /// <summary>
        /// Used to Check if the item is checked is not already in the list it will be added too list
        /// </summary>
        /// <param name="listBox"></param>
        /// <param name="cb"></param>
        /// <param name="text"></param>
        /// <param name="duration"></param>
        private void itemsInputChecker(ListBox listBox, CheckBox cb, string text, int duration)
        {
            if (cb.IsChecked == true && listBox.Items.Contains(text) == false)
            {
                ToDoBox.Items.Add(text);
                timecounter = timecounter + duration;
            }
        }

        /// <summary>
        /// Used to calculate the hours and seconds from Mintues 
        /// </summary>
        /// <param name="_time"></param>
        private void getTime(double _time)
        {
            var totalMinutes = _time;
            var time = TimeSpan.FromMinutes(totalMinutes);          
            Time_lb.Content = ("Average amount of Time of Completion: " + "\n" + (int)time.TotalHours + " Hour And " + time.Minutes + " Mintues ");

        }

        /// <summary>
        /// Used to Input Items to ListBox and Calculate Time 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            itemsInputChecker(ToDoBox, FlashPoint_CB, "Flash Point", 10);
            itemsInputChecker(ToDoBox, Nmh_CB, "Nightmare Hunt", 13);
            itemsInputChecker(ToDoBox, Nightfall_CB, "Nightfall", 15);
            itemsInputChecker(ToDoBox, StrikesBounties_CB, "Strike Bounties", 20);
            itemsInputChecker(ToDoBox, CrucibleBounties_CB, "Crucible Bounties" , 20);
            itemsInputChecker(ToDoBox, GambitBounties_CB, "Gambit Bounties" , 20);
            itemsInputChecker(ToDoBox, strikes_CB, "3 Strike Completions", 10);
            itemsInputChecker(ToDoBox, crucible_CB, "4 Crucible Matches ", 13);
            itemsInputChecker(ToDoBox, gambit_CB, "3 Gambit Matches", 15);
            itemsInputChecker(ToDoBox, Raid_Graden, "Garden of salvation", 60);
            itemsInputChecker(ToDoBox, PitBoss_cb, "Pit Dungeon", 40);
            itemsInputChecker(ToDoBox, clan_engram, "Gambit Bounties", 20);

            SetCheckBoxToNull(ToGrid);           
            getTime(timecounter);
        }

        /// <summary>
        /// Used to Set all CheckBoxes to Null 
        /// </summary>
        /// <param name="gridName"></param>
        public void SetCheckBoxToNull(Grid gridName)
        {
            foreach (Control checkBox in gridName.Children)
            {
                if (checkBox.GetType() == typeof(CheckBox))
                    ((CheckBox)checkBox).IsChecked = false;              
            }
        }



    }
}
