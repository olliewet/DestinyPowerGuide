using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Destiny2PowerLevelMax
{
    public class Destiny2Logic
    {
        /// <summary>
        /// Destiny 2 main leveling chase is called Power, Power is calculated by working out an average of the user gear score, 
        /// this method works out how much power the user requires on a certain piece of gear to reach the next power mark, this method
        /// revolves around simple division and substraction, however uses an if statement to check if the user is already at a full level. 
        /// </summary>
        /// <param name="_base"></param>
        /// <param name="power"></param>
        /// <param name="label"></param>     
        public static void avg(double _base, double power, Label label)
        {
            double answer = _base - power;
            double an = answer * 8;
            double increase = Math.Ceiling(an);
            if (power % 1 == 0)
            {
                label.Content = "8";
            }
            else
            {
                label.Content = increase.ToString();
            }
        }

        /// <summary>
        /// This method uses an if statement to check which part of the power grind the user is on, and with that information a counter is then user to calculate how
        /// many pieces of armour are underleveled and then suggests to the user what activites can be completed to min/max.
        /// </summary>
        /// <param name="power"></param>
        /// <param name="counter"></param>
        /// <param name="textBlock"></param>
        public static void SuggestedUpgrade(double power, int counter, TextBlock textBlock)
        {
            if (power >= 1000 && power < 1050)
            {
                switch (counter)
                {
                    case 0:
                        textBlock.Text = "No Pieces are under Leveled, Suggested Route Powerfuls ";
                        break;
                    case 1:
                        textBlock.Text = "One Piece is Under Leveled, Suggested Route Powerfuls or use tokens to get that one piece to the base level, view rewards for detailed information on type of rewards";
                        break;
                    case 2:
                        textBlock.Text = "Two Piece is Under Leveled, Use Tokens to gather Pieces that drop at your base Power make sure to check on vendorengrams.xyz to see which vendors are dropping at base power";
                        break;
                    case 3:
                        textBlock.Text = "Three Piece is Under Leveled, Use Tokens to gather Pieces that drop at your base Power make sure to check on vendorengrams.xyz to see which vendors are dropping at base power";
                        break;
                    case 4:
                        textBlock.Text = "Four Piece is Under Leveled, Use Tokens to gather Pieces that drop at your base Power make sure to check on vendorengrams.xyz to see which vendors are dropping at base power";
                        break;
                    case 5:
                        textBlock.Text = "Five Piece is Under Leveled, Use Tokens to gather Pieces that drop at your base Power make sure to check on vendorengrams.xyz to see which vendors are dropping at base power";
                        break;
                    case 6:
                        textBlock.Text = "Six Piece is Under Leveled, Use Tokens to gather Pieces that drop at your base Power make sure to check on vendorengrams.xyz to see which vendors are dropping at base power";
                        break;
                    case 7:
                        textBlock.Text = "Seven Piece is Under Leveled, Use Tokens to gather Pieces that drop at your base Power make sure to check on vendorengrams.xyz to see which vendors are dropping at base power ";
                        break;
                    case 8:
                        textBlock.Text = "Eight Piece is Under Leveled, Use Tokens to gather Pieces that drop at your base Power make sure to check on vendorengrams.xyz to see which vendors are dropping at base power ";
                        break;
                }
            } 
            else if (power >= 1050)
            {
                switch (counter)
                {
                    case 0:
                        textBlock.Text = "No Pieces are under Leveled, Suggested Route Pinnacles ";
                        break;
                    case 1:
                        textBlock.Text = "One Piece is Under Leveled, Suggested Route Powerfuls or use tokens to get that one piece to the base level, view rewards for detailed information on type of rewards";
                        break;
                    case 2:
                        textBlock.Text = "Two Piece is Under Leveled, Use Tokens to gather Pieces that drop at your base Power make sure to check on vendorengrams.xyz to see which vendors are dropping at base power";
                        break;
                    case 3:
                        textBlock.Text = "Three Piece is Under Leveled, Use Tokens to gather Pieces that drop at your base Power make sure to check on vendorengrams.xyz to see which vendors are dropping at base power";
                        break;
                    case 4:
                        textBlock.Text = "Four Piece is Under Leveled, Use Tokens to gather Pieces that drop at your base Power make sure to check on vendorengrams.xyz to see which vendors are dropping at base power";
                        break;
                    case 5:
                        textBlock.Text = "Five Piece is Under Leveled, Use Tokens to gather Pieces that drop at your base Power make sure to check on vendorengrams.xyz to see which vendors are dropping at base power";
                        break;
                    case 6:
                        textBlock.Text = "Six Piece is Under Leveled, Use Tokens to gather Pieces that drop at your base Power make sure to check on vendorengrams.xyz to see which vendors are dropping at base power";
                        break;
                    case 7:
                        textBlock.Text = "Seven Piece is Under Leveled, Use Tokens to gather Pieces that drop at your base Power make sure to check on vendorengrams.xyz to see which vendors are dropping at base power ";
                        break;
                    case 8:
                        textBlock.Text = "Eight Piece is Under Leveled, Use Tokens to gather Pieces that drop at your base Power make sure to check on vendorengrams.xyz to see which vendors are dropping at base power ";
                        break;
                }
            }
        }


    }
}
