using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicHolidayChecker
{
    public class Option
    {
        private HttpClient _client;

        public Option(HttpClient client)
        {
            _client = client;
           client.DefaultRequestHeaders.Add("User-Agent", "C# App"); // this is a requirement to access the API
        }

        public Option()
        {

        }

        public async Task<string> CheckByYearAndCountry(string year, string countryCode)
        {
            string url = $"https://date.nager.at/api/v3/LongWeekend/{year}/{countryCode}";
            HttpResponseMessage y = await _client.GetAsync(url);

            string result = await y.Content.ReadAsStringAsync();
            if (y == null)

                throw new Exception("ERROR");
            return result;
            
           //onsole.WriteLine(result);
        }


    }
}
