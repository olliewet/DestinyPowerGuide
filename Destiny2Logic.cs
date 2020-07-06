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
        //Method for working out the users average power level
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

        //Method for suggesting how many pieces need upgrading and best suited way to upgrade piece 
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
                        textBlock.Text = "Six Piece is Under Leveled, Use Tokens to gather Pieces that drop at your base Power make sure to check on vendorengrams.xyz to see which vendors are dropping at base power";
                        break;
                    case 3:
                        textBlock.Text = "Six Piece is Under Leveled, Use Tokens to gather Pieces that drop at your base Power make sure to check on vendorengrams.xyz to see which vendors are dropping at base power";
                        break;
                    case 4:
                        textBlock.Text = "Six Piece is Under Leveled, Use Tokens to gather Pieces that drop at your base Power make sure to check on vendorengrams.xyz to see which vendors are dropping at base power";
                        break;
                    case 5:
                        textBlock.Text = "Six Piece is Under Leveled, Use Tokens to gather Pieces that drop at your base Power make sure to check on vendorengrams.xyz to see which vendors are dropping at base power";
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
                        textBlock.Text = "One Piece is Under Leveled, Suggested Route Pinnacles or use tokens to get that one piece to the base level, view rewards for detailed information on type of rewards";
                        break;
                    case 2:
                        textBlock.Text = "Six Piece is Under Leveled, Use Tokens to gather Pieces that drop at your base Power make sure to check on vendorengrams.xyz to see which vendors are dropping at base power";
                        break;
                    case 3:
                        textBlock.Text = "Six Piece is Under Leveled, Use Tokens to gather Pieces that drop at your base Power make sure to check on vendorengrams.xyz to see which vendors are dropping at base power";
                        break;
                    case 4:
                        textBlock.Text = "Six Piece is Under Leveled, Use Tokens to gather Pieces that drop at your base Power make sure to check on vendorengrams.xyz to see which vendors are dropping at base power";
                        break;
                    case 5:
                        textBlock.Text = "Six Piece is Under Leveled, Use Tokens to gather Pieces that drop at your base Power make sure to check on vendorengrams.xyz to see which vendors are dropping at base power";
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
