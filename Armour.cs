using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2PowerLevelMax
{
    class Armour
    {
        private double helmet;
        private double arms;
        private double chest;
        private double classpiece;
        private double legs;
        private double primary;
        private double secondary;
        private double power;
        private double calculator; 

        public double Helmet
        {
            get { return helmet; }
            set { helmet = value; }
        }

        public double Arms
        {
            get { return arms; }
            set { arms = value; }
        }

        public double Chest
        {
            get { return chest; }
            set { chest = value; }
        }

        public double Class
        {
            get { return classpiece; }
            set { classpiece = value; }
        }

        public double Legs
        {
            get { return legs; }
            set { legs = value; }
        }

        public double Primary
        {
            get { return primary; }
            set { primary = value; }
        }

        public double Secondary
        {
            get { return secondary; }
            set { secondary = value; }
        }

        public double Power
        {
            get { return power; }
            set { power = value; }
        }

        public double cal()
        {
            calculator = Helmet + Arms + Chest + Class + Legs + Primary + Secondary + Power;
            return calculator;
        }








    }
}
