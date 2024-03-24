using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Builder.CustomProperties
{
    /// <summary>
    /// Special property where present baseValue (basis), and percent of that value.
    /// Can be converted to double, as value used class Value property.
    /// </summary>
    public class PercentProperty: INotifyPropertyChanged
    {
        private double _baseValue;

        public double BaseValue
        {
            get { return _baseValue;}
            set
            {
                _baseValue = value;
                NotifyPropertyChanged();
            }
        }

        private double _percent;
        public double Percent
        {
            get { return _percent; }
            set
            {
                _percent = value;
                NotifyPropertyChanged();
            }
        }

        public double Value => BaseValue * Percent;

        public static explicit operator double(PercentProperty property)
        {
            return property.Value;
        }

        public PercentProperty()
        {
            BaseValue = 0;
            Percent = 1;
        }

        public PercentProperty(double baseValue)
        {
            BaseValue = baseValue;
            Percent = 1;
        }

        public PercentProperty(double baseValue, double percent)
        {
            BaseValue = baseValue;
            Percent = percent;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        // This method is called by the Set accessor of each property.
        // The CallerMemberName attribute that is applied to the optional propertyName
        // parameter causes the property name of the caller to be substituted as an argument.
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public string GetInfo()
        {
            return $"Base value - {BaseValue}, percentage - {Math.Round(Percent*100, 2)}%";
        }
    }
}
