using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    internal class MathProgram
    {
        static void Main(string[] args)
        {
            double number_1 = 8.1;
            double number_2 = 9.9;
            double number_3 = 19;
            double number_4 = 28;
            double number_5 = 7.4;

            Console.WriteLine("--------------------------");
            Console.WriteLine("Ceiling: " + Math.Ceiling(number_1));
            Console.WriteLine("Floor: " + Math.Floor(number_2));
            Console.WriteLine("Pow: " + Math.Pow(number_3, 2));
            Console.WriteLine("Sqrt: " + Math.Sqrt(number_4));
            Console.WriteLine("Round: " + Math.Round(number_5));
            Console.WriteLine("--------------------------");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}
