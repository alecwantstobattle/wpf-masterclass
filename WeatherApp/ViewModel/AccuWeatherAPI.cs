using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WeatherApp.Model;

namespace WeatherApp.ViewModel
{
    class AccuWeatherAPI
    {
        public const string API_KEY = "";
        public const string BASE_URL = "http://dataservice.accuweather/forecasts/v1/daily/5day/{0}?apikey={0}&metric=true";

        public async Task<AccuWeather> GetWeatherInformationAsync(string locationKey)
        {
            AccuWeather result = new AccuWeather();

            string url = string.Format(BASE_URL, locationKey, API_KEY);

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                string json = await response.Content.ReadAsStringAsync();

                result = JsonConvert.DeserializeObject<AccuWeather>(json);
            }

            return result;
        }
    }
}