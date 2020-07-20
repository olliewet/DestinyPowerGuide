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
            double timecounter = 0; 
            if (FlashPoint_CB.IsChecked == true)
                ToDoBox.Items.Add("Flash Point");
            timecounter = timecounter + 10;
            if (Nmh_CB.IsChecked == true)
                ToDoBox.Items.Add("Nightmare Hunt");
            timecounter = timecounter + 10;
            if (Nightfall_CB.IsChecked == true)
                ToDoBox.Items.Add("Nightfall");
            timecounter = timecounter + 10;
            if (StrikesBounties_CB.IsChecked == true)
                ToDoBox.Items.Add("Strike Bounties");
            timecounter = timecounter + 10;
            if (CrucibleBounties_CB.IsChecked == true)
                ToDoBox.Items.Add("Crucible Bounties");
            timecounter = timecounter + 10;
            if (GambitBounties_CB.IsChecked == true)
                ToDoBox.Items.Add("Gambit Bounties");
            timecounter = timecounter + 10;
            SetCheckBoxToNull(ToGrid);
            string time = timecounter.ToString();
            Time_lb.Content = "Average Time to complete is " + time + "  mintues";
        }

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
