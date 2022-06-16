using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PublicHolidayChecker
{
    public class Option
    {
        private HttpClient _client;

        public Option(HttpClient client, string url)
        {
            _client = client;
            _client.BaseAddress = new Uri(url);
           client.DefaultRequestHeaders.Add("User-Agent", "C# App"); // this is a requirement to access the API
        }

        public Option()
        {

        }

        public void ClearSpace()
        {
            string output;
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
            Console.Clear();
            output = "Closing app...";
            Console.WriteLine(output);
        }

        public async Task<Holiday[]> CheckByYearAndCountry(string year, string countryCode)
        {
            string url = $"https://date.nager.at/api/v3/PublicHolidays/{year}/{countryCode}";
            HttpResponseMessage y = await _client.GetAsync(url);

            string result = await y.Content.ReadAsStringAsync();
            Holiday[] holidays = JsonConvert.DeserializeObject<Holiday[]>(result);
            if (y.IsSuccessStatusCode)
                return holidays;

            throw new Exception("ERROR");
     
        }

        public async Task<bool> CheckToday(string countryCode)
        {
            string url = $"https://date.nager.at/api/v3/IsTodayPublicHoliday/{countryCode}";
            HttpResponseMessage y = await _client.GetAsync(url);
            System.Net.HttpStatusCode result = y.StatusCode;
            int newResult = (int)result; // turning it into an int so we can use it to validate below if it is successful(200), empty content(204) or invalid search(404). 

            if (newResult == 200)
            {
                Console.WriteLine("Today is a Public Holiday");
                return true;
            }
            else if (newResult == 204)
            {
                Console.WriteLine("Today is not a Public Holiday");
                return false;
            }
            else
                Console.WriteLine("Invalid Country Code");
                    return false;
        }

        

        public async Task<Holiday[]> CheckDateForHoliday(string year, string countryCode)
        {

            string url = $"https://date.nager.at/api/v3/PublicHolidays/{year}/{countryCode}";
            HttpResponseMessage y = await _client.GetAsync(url);

            string result = await y.Content.ReadAsStringAsync();
            Holiday[] h = JsonConvert.DeserializeObject<Holiday[]>(result);
            if (y.IsSuccessStatusCode)
                return h;

            throw new Exception("ERROR");

        }


    }
}
