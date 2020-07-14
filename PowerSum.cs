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
        /// <summary>
        /// Work In Progress Class Using Property Changed 
        /// </summary>
        private string val_helmet;
        private string val_arms;
        private string val_chest;
        private string val_class;
        private string val_legs;
        private string val_prim;
        private string val_secondary ;
        private string val_power;
        private string result; 

        public string Val_Helmet
        {
            get { return val_helmet; }
            set
            {
                double number;
                bool res = double.TryParse(value, out number);
                if (res) val_helmet = value;
                OnPropertyChanged("HelBox");
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
                OnPropertyChanged("ArmsBox"); 
                OnPropertyChanged("Result");
            }
        }
        public string Val_Chest 
        {
            get { return val_chest; }
            set
            {
                double number;
                bool res = double.TryParse(value, out number);
                if (res) val_chest = value;
                OnPropertyChanged("ChestBox");//Change to Correct Box 
                OnPropertyChanged("Result");
            }
        }
        public string Val_Legs
        {
            get { return val_legs; }
            set
            {
                double number;
                bool res = double.TryParse(value, out number);
                if (res) val_legs = value;
                OnPropertyChanged("LegsBox"); //Change to Correct Box 
                OnPropertyChanged("Result");
            }
        }
        public string Val_Class
        {
            get { return val_class; }
            set
            {
                double number;
                bool res = double.TryParse(value, out number);
                if (res) val_class = value;
                OnPropertyChanged("ClassBox"); 
                OnPropertyChanged("Result");
            }
        }

        public string Val_Prim
        {
            get { return val_prim; }
            set
            {
                double number;
                bool res = double.TryParse(value, out number);
                if (res) val_prim = value;
                OnPropertyChanged("PrimBox"); //Change to Correct Box 
                OnPropertyChanged("Result");
            }
        }

        public string Val_Secondary
        {
            get { return val_secondary; }
            set
            {
                double number;
                bool res = double.TryParse(value, out number);
                if (res) val_secondary = value;
                OnPropertyChanged("SecBox"); //Change to Correct Box 
                OnPropertyChanged("Result");
            }
        }

        public string Val_Power
        {
            get { return val_power; }
            set
            {
                double number;
                bool res = double.TryParse(value, out number);
                if (res) val_power = value;
                OnPropertyChanged("PowerBox"); //Change to Correct Box 
                OnPropertyChanged("Result");
            }
        }



        
        public string Result
        {
            get
            {
                double cal = double.Parse(Val_Helmet) + double.Parse(Val_Arms) + double.Parse(Val_Chest) + double.Parse(Val_Legs) + double.Parse(Val_Class) + double.Parse(Val_Prim) + double.Parse(Val_Secondary) + double.Parse(Val_Power);
                double PlValue = cal / 8;
                return PlValue.ToString();
            }
            set
            {
                double cal = double.Parse(Val_Helmet) + double.Parse(Val_Arms) + double.Parse(Val_Chest) + double.Parse(Val_Legs) + double.Parse(Val_Class) + double.Parse(Val_Prim) + double.Parse(Val_Secondary) + double.Parse(Val_Power);
                double PlValue = cal / 8;               
                result = PlValue.ToString();
                OnPropertyChanged("Result");
            }

        }
        

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
