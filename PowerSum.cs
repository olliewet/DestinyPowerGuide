using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2PowerLevelMax
{
    public class PowerSum : INotifyPropertyChanged
    {

        private string val_helmet;
        private string val_arms;
        private string val_chest;
        private string val_class;
        private string val_legs;
        private string val_prim;
        private string val_secondary ;
        private string val_power;
        private string val_result;

        public string Val_Helmet
        {
            get { return val_helmet; }
            set
            {
                double number;
                bool res = double.TryParse(value, out number);
                if (res) val_helmet = value;
                OnPropertyChanged("Hel"); //Change to Correct Box 
                OnPropertyChanged("Result"); //Change to Correct Box 
            }
        }
        public string Val_Arms
        {
            get { return val_arms; }
            set
            {
                double number;
                bool res = double.TryParse(value, out number);
                if (res) val_arms = value;
                OnPropertyChanged("Arms"); //Change to Correct Box 
                OnPropertyChanged("Result");
            }
        }
        public string Val_chest 
        {
            get { return val_chest; }
            set
            {
                double number;
                bool res = double.TryParse(value, out number);
                if (res) val_arms = value;
                OnPropertyChanged("Chest");//Change to Correct Box 
                OnPropertyChanged("Result");
            }
        }
        public string Val_legs
        {
            get { return val_legs; }
            set
            {
                double number;
                bool res = double.TryParse(value, out number);
                if (res) val_arms = value;
                OnPropertyChanged("legs"); //Change to Correct Box 
                OnPropertyChanged("Result");
            }
        }
        public string Val_class
        {
            get { return val_class; }
            set
            {
                double number;
                bool res = double.TryParse(value, out number);
                if (res) val_arms = value;
                OnPropertyChanged("Class"); //Change to Correct Box 
                OnPropertyChanged("Result");
            }
        }

        public string Val_prim
        {
            get { return val_prim; }
            set
            {
                double number;
                bool res = double.TryParse(value, out number);
                if (res) val_arms = value;
                OnPropertyChanged("Prim"); //Change to Correct Box 
                OnPropertyChanged("Result");
            }
        }

        public string Val_secondary
        {
            get { return val_secondary; }
            set
            {
                double number;
                bool res = double.TryParse(value, out number);
                if (res) val_arms = value;
                OnPropertyChanged("secondary"); //Change to Correct Box 
                OnPropertyChanged("Result");
            }
        }

        public string Val_power
        {
            get { return val_power; }
            set
            {
                double number;
                bool res = double.TryParse(value, out number);
                if (res) val_arms = value;
                OnPropertyChanged("power"); //Change to Correct Box 
                OnPropertyChanged("Result");
            }
        }



        /*
        public string Result
        {
            get
            {
                double cal = hel + arms + Chest + Class + Legs + Prim + Secondary + Power;
                double PlValue = cal / 8;
                return res.ToString();
            }
            set
            {
                double cal = hel + arms + Chest + Class + Legs + Prim + Secondary + Power;
                double PlValue = cal / 8;
                int res = int.Parse(Num1) + int.Parse(Num2);
                result = res.ToString();
                OnPropertyChanged("Result");
            }

        }
        */

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
