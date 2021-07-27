using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using Newtonsoft.Json;
using WeatherApp.Model;

namespace WeatherApp.ViewModel
{
    class WeatherUndergroundAPI
    {
        public const string API_KEY = "";
        public const string BASE_URL = "http://api/wunderground.com/api/{0}/forecase/q/{1}.json";

        public async Task<WeatherUnderground> GetWeatherInformationAsync(string cityName)
        {
            WeatherUnderground result = new WeatherUnderground();

            string url = string.Format(BASE_URL, API_KEY, cityName);

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                string json = await response.Content.ReadAsStringAsync();

                result = JsonConvert.DeserializeObject<WeatherUnderground>(json);
            }

            return result;
        }
    }
}
