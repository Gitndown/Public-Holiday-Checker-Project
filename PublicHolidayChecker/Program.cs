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

                    Option option1 = new();
                    option1.CheckByYearAndCountry(year, countryCode);
                    break;

                case "2":
                    Console.Clear();
                    bool isPublicHoliday = true;
                    if ( isPublicHoliday == true)

                    output = "Today is a public Holiday";
                  
                    else output = "Today is not a public holiday";
                    Console.WriteLine(output);
                    break;

                case "3":
                    Console.Clear();
                    output = "Please enter in the date you want to check using the format DD/MM/YYY";
                    Console.WriteLine(output);
                    string date = Console.ReadLine();
                    string QueenBday = "13/06/2022";
                    if (date == QueenBday)
                        output = "This was a public holiday";
                    else;
                    Console.WriteLine(output);
                    break;

                case "4":
                    output = "Closing app...";
                    Console.WriteLine(output);
                    break;

            }
            









        }
}
}