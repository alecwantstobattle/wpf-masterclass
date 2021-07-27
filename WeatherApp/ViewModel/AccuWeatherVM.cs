using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Model;

namespace WeatherApp.ViewModel
{
    class AccuWeatherVM
    {
        public AccuWeather AccuWeather { get; set; }

        public AccuWeatherVM()
        {
            AccuWeather = new AccuWeather();
        }
    }
}
