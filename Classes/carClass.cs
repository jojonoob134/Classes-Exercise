using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class carClass
    {
        public carClass(string make, string modle, int year)
        {
            Console.WriteLine($"This car is the {modle} with the make of {make} and year is {year }");
        }
        public string make { get; set; }
        public string modle { get; set; }
        public int year { get; set; }
    }
}
