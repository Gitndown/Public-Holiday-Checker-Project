using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicHolidayChecker
{
    public class Menu
    {
        

        public Menu()
        {  
            
        }

        public void DisplayMenu()
        {
            Console.WriteLine("1. Search by Year and Country");
            Console.WriteLine("2. Check if today is a public Holiday");
            Console.WriteLine("3. Check a specific date for a public holiday");
            Console.WriteLine("4. Quit");
        }
    }
}
