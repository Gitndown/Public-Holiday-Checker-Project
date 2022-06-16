using System;

namespace PublicHolidayChecker
{
    class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the public holiday checker");

            Menu listedMenu = new Menu();
            listedMenu.DisplayMenu();

            string mainMenu = Console.ReadLine(); 
            string output = null;           
            switch (mainMenu)
            {
                case "1":
                    Console.Clear();
                    output = "Please enter in the country code";
                    Console.WriteLine(output);
                    string countryCode = Console.ReadLine();
                    output = "Please enter in the year eg. 2022";
                    Console.WriteLine(output);
                    string year = Console.ReadLine();

                    Option option1 = new Option(new HttpClient(), $"https://date.nager.at/api/v3/PublicHolidays/{year}/{countryCode}");
                    Holiday[] test = option1.CheckByYearAndCountry(year, countryCode).GetAwaiter().GetResult();
                    foreach (Holiday h in test)
                    {
                        Console.WriteLine($"{h.name}-{h.date}");
                    }
                    option1.ClearSpace();
                    break;

                case "2":
                    Console.Clear();
                    output = "Please enter in the country code";
                    Console.WriteLine(output);
                    string country = Console.ReadLine();
                    Option option2 = new Option(new HttpClient(), $"https://date.nager.at/api/v3/IsTodayPublicHoliday/{country}");
                    option2.CheckToday(country).GetAwaiter().GetResult();
                    option2.ClearSpace();
                    break;

                case "3":
                    Console.Clear();
                    output = "Please enter in the country code";
                    Console.WriteLine(output);
                    string countryC = Console.ReadLine();
                    output = "Please enter in the date you want to check using the format YYYY-MM-DD";
                    Console.WriteLine(output);
                    string date = Console.ReadLine();
                    string yearTaken = GrabYearFromDate(date);
                    Option option3 = new Option(new HttpClient(), $"https://date.nager.at/api/v3/IsTodayPublicHoliday/{yearTaken}/{countryC}");
                    option3.CheckDateForHoliday(yearTaken, countryC).GetAwaiter().GetResult();
                    Holiday[] test2 = option3.CheckByYearAndCountry(yearTaken, countryC).GetAwaiter().GetResult();
                    Console.WriteLine("NOTE: Any results found will display below. Press any key to continue");
                    Console.ReadLine();
                    foreach (Holiday h in test2)
                    {
                        string hDateStr = Convert.ToString(h.date);
                        if (hDateStr == date)
                            Console.WriteLine($"Public holiday DETECTED: {h.name}-{h.date}");
                        
                    }
                    option3.ClearSpace();
                    break;

                case "4":
                    output = "Closing app...";
                    Console.WriteLine(output);
                    break;

            }
            static string GrabYearFromDate(string date)
            {
                string[] arrDate = date.Split('-');

                string day = arrDate[2];
                string month = arrDate[1];
                string year = arrDate[0];

                return year;


            }










        }
}
}