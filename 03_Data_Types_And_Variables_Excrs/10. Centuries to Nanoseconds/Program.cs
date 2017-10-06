using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var centuries = int.Parse(Console.ReadLine());

            int years = centuries * 100;
            double days = years * 365.2422;
            double hours = days * 24;
            double minutes = hours * 60;
            double seconds = minutes * 60;
            double miliseconds = seconds * 1000;
            double microseconds =(miliseconds * 1000);
            string microSecToString = Convert.ToString(microseconds);
            double nanoseconds = microseconds * 100;
            string nanoSecToString = Convert.ToString(nanoseconds);
            Console.WriteLine($"{centuries} centuries = {years} years = {days:f0} days = {hours:f0} hours = {minutes} minutes = {seconds} seconds = {miliseconds} milliseconds = {0} microseconds = {1} nanoseconds",);
        }
    }
}
