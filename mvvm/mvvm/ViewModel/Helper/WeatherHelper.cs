using mvvm.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace mvvm.ViewModel.Helper
{
    public class WeatherHelper
    {
        public const string BaseUrl = "http://dataservice.accuweather.com/";
        public const string ApiKey = "z9ys2nHoWoDMyVjMwL0FQdIv4AHAnsjl";
        public const string AutocompliteEndpoint = "locations/v1/cities/autocomplete?apikey={0}={1}";
        public const string CurrentConditions = "currentconditions/v1/{0}?apikey={1}";

        public static async Task< List<City>> GetCities(string query) {

            List<City> cities = new List<City>();

            string url = BaseUrl + String.Format(AutocompliteEndpoint, ApiKey, query);

            using (HttpClient client = new HttpClient())
            {
              var responce =  await client.GetAsync(url);
                string json = await responce.Content.ReadAsStringAsync();
                cities = JsonConvert.DeserializeObject<List<City>>(json);
            }
                return cities;
        }

        public static async Task<Curent> GetCurent(string lokKey)
        {

           Curent curent = new Curent();

            string url = BaseUrl + String.Format(CurrentConditions, lokKey, ApiKey);

            using (HttpClient client = new HttpClient())
            {
                var responce = await client.GetAsync(url);
                string json = await responce.Content.ReadAsStringAsync();
                curent = JsonConvert.DeserializeObject<List<Curent>>(json)[0];
            }
            return curent;
        }

    }
}
