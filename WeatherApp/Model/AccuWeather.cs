using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WeatherApp.Model
{
    public class Range: INotifyPropertyChanged
    {
        public double value;

        public double Value 
        { 
            get { return value; }
            set
            {
                this.value = value;
                OnPropertyChanged("Value");
            }
        }

        public string unit;

        public string Unit
        {
            get { return unit; }
            set
            {
                unit = value;
                OnPropertyChanged("Unit");
            }
        }

        public int unitType;

        public int UnitType
        {
            get { return unitType; }
            set
            {
                unitType = value;
                OnPropertyChanged("UnitType");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class Temperature : INotifyPropertyChanged
    {
        public Range minimum;
        public Range Minimum
        {
            get { return minimum; }
            set
            {
                minimum = value;
                OnPropertyChanged("Minimum");
            }
        }

        public Range maximum;
        public Range Maximum
        {
            get { return maximum; }
            set
            {
                maximum = value;
                OnPropertyChanged("Maximum");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class TimeOfDay : INotifyPropertyChanged
    {
        public int icon;
        public int Icon
        {
            get { return icon; }
            set
            {
                icon = value;
                OnPropertyChanged("Icon");
            }
        }

        public string iconPhrase;
        public string IconPhrase
        {
            get { return iconPhrase; }
            set
            {
                iconPhrase = value;
                OnPropertyChanged("IconPhrase");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class DailyForecast: INotifyPropertyChanged
    {
        public List<string> Sources { get; set; }

        public DateTime date;

        public DateTime Date
        {
            get { return date; }
            set
            {
                date = value;
                OnPropertyChanged("Date");
            }
        }

        public Temperature temperature;

        public Temperature Temperature
        {
            get { return temperature; }
            set
            {
                temperature = value;
                OnPropertyChanged("Temperature");
            }
        }

        public TimeOfDay day;

        public TimeOfDay Day
        {
            get { return day; }
            set
            {
                day = value;
                OnPropertyChanged("Day");
            }
        }

        public TimeOfDay night;

        public TimeOfDay Night
        {
            get { return night; }
            set
            {
                day = value;
                OnPropertyChanged("Night");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    class AccuWeather
    {
        public List<DailyForecast> DailyForecasts { get; set; }

        public AccuWeather()
        {
            if (DesignerProperties.GetIsInDesignMode(new DependencyObject()))
            {
                DailyForecasts = new List<DailyForecast>();
                for (int i = 0; i < 3; i++)
                {
                    DailyForecast dailyForecast = new DailyForecast
                    {
                        Date = DateTime.Now.AddDays(-i),
                        Temperature = new Temperature
                        {
                            Maximum = new Range()
                            {
                                Value = 21 + i
                            },
                            Minimum = new Range()
                            {
                                Value = 5 - i
                            }
                        }
                    };
                    DailyForecasts.Add(dailyForecast);
                }
            }
        }
    }
}
