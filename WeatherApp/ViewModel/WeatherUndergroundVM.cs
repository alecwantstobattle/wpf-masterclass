using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Model;

namespace WeatherApp.ViewModel
{
    class WeatherUndergroundVM
    {
        public WeatherUnderground WeatherUnderground { get; set; }

        public WeatherUndergroundVM()
        {
            WeatherUnderground = new WeatherUnderground();
        }
    }
}
