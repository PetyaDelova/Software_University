using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Reverse_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstSymbolAskedFromClient = Console.ReadLine()[0];
            char secondSymbolAskedFromClient = Console.ReadLine()[0];
            char thirdSymbolAskedFromClient = Console.ReadLine()[0];

            Console.WriteLine("{2}{1}{0}",firstSymbolAskedFromClient,
                                          secondSymbolAskedFromClient,
                                          thirdSymbolAskedFromClient);


        }
    }
}
