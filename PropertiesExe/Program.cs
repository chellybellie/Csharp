using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesExe
{
    class Program
    {
        static void Main(string[] args)
        {
            Name name = new Name();
            name.FullName = "John Earl Madden";
            name.FullName = "Abraham Lincoln";
            name.FullName = "Plato";

            name[0] = "Terry";
            name[1] = "Hotdoog";
            name[2] = "Nguyen";
            
            DatePeriod period = new DatePeriod();
            period.AddDays(8);
            period.AddWeeks(1000);
            //period.AddYears(10);

            Console.WriteLine("Days:  " + period.Days);
            Console.WriteLine("Weeks: " + period.Weeks);
            Console.WriteLine("Years: " + period.Years);


            Console.ReadLine();
        }
    }
}