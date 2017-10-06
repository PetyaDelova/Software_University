using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine(a);

            }
            catch (Exception)
            {
                char b = char.Parse(Console.ReadLine());
                Console.WriteLine("letter");

                throw;
            }
        }
    }
}
