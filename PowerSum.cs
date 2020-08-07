using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2PowerLevelMax
{
    public class PowerSum : INotifyPropertyChanged
    {
        /// <summary>
        /// Work In Progress Class Using Property Changed, 
        /// 
        /// Idea behind the class is to remove the need of the calculate button and have the value change whenever a user changes a value
        /// </summary>
        

        ///Declaring Variables to be used in Properties
        private string val_helmet;
        private string val_arms;
        private string val_chest;
        private string val_class;
        private string val_legs;
        private string val_prim;
        private string val_secondary ;
        private string val_power;
        private string result; 


       
        public string Helmet
        {
            get { return val_helmet; }
            set
            {
                double number;
                bool res = double.TryParse(value, out number);
                if (res) val_helmet = value;
                OnPropertyChanged("Helmet");
                OnPropertyChanged("Result"); 
            }
        }

        public string Arms
        {
            get { return val_arms; }
            set
            {
                double number;
                bool res = double.TryParse(value, out number);
                if (res) val_arms = value;
                OnPropertyChanged("Arms"); 
                OnPropertyChanged("Result");
            }
        }

        public string Chest 
        {
            get { return val_chest; }
            set
            {
                double number;
                bool res = double.TryParse(value, out number);
                if (res) val_chest = value;
                OnPropertyChanged("Chest");
                OnPropertyChanged("Result");
            }
        }

        public string Legs
        {
            get { return val_legs; }
            set
            {
                double number;
                bool res = double.TryParse(value, out number);
                if (res) val_legs = value;
                OnPropertyChanged("Legs"); 
                OnPropertyChanged("Result");
            }
        }

        public string Class
        {
            get { return val_class; }
            set
            {
                double number;
                bool res = double.TryParse(value, out number);
                if (res) val_class = value;
                OnPropertyChanged("Class"); 
                OnPropertyChanged("Result");
            }
        }

        public string Prim
        {
            get { 
                return val_prim; 
            }
            set
            {
                double number;
                bool res = double.TryParse(value, out number);
                if (res) val_prim = value;
                OnPropertyChanged("Prim"); 
                OnPropertyChanged("Result");
            }
        }

        public string Sec
        {
            get {
                return val_secondary; 
            }
            set
            {
                double number;
                bool res = double.TryParse(value, out number);
                if (res) val_secondary = value;
                OnPropertyChanged("Sec"); //Change to Correct Box 
                OnPropertyChanged("Result");
            }
        }

        public string Power
        {
            get 
            { return val_power; 
            }
            set
            {
                double number;
                bool res = double.TryParse(value, out number);
                if (res) val_power = value;
                OnPropertyChanged("Power"); //Change to Correct Box 
                OnPropertyChanged("Result");
            }
        }

       
        public string Result
        {
            get
            {
                double cal = double.Parse(Helmet) + double.Parse(Arms) + double.Parse(Chest) + double.Parse(Legs) + double.Parse(Class) + double.Parse(Prim) + double.Parse(Sec) + double.Parse(Power);
                double PlValue = cal / 8;
                double plRoundUp = Math.Round(PlValue, 1);
                double plRoundDown = Math.Floor(PlValue);
                double _basePl = Math.Ceiling(PlValue);
                              
                return PlValue.ToString();
            }
            set
            {
                double cal = double.Parse(Helmet) + double.Parse(Arms) + double.Parse(Chest) + double.Parse(Legs) + double.Parse(Class) + double.Parse(Prim) + double.Parse(Sec) + double.Parse(Power);
                double PlValue = cal / 8;
                double plRoundUp = Math.Round(PlValue, 1);
                double plRoundDown = Math.Floor(PlValue);
                double _basePl = Math.Ceiling(PlValue);           
                result = PlValue.ToString();
                OnPropertyChanged("IncreaseValue");
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
