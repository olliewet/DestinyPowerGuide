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

        private string hel;
        private string arms;
        private string chest;
        private string _class;
        private string legs;
        private string prim;
        private string secondary ;
        private string power;
        private string result;

        public string Hel
        {
            get { return hel; }
            set
            {
                int number;
                bool res = int.TryParse(value, out number);
                if (res) hel = value;
                OnPropertyChanged("Hel");
                OnPropertyChanged("Result");
            }
        }
        public string Arms
        {
            get { return arms; }
            set
            {
                int number;
                bool res = int.TryParse(value, out number);
                if (res) arms = value;
                OnPropertyChanged("Arms");
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
