using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPerformance
{
    internal class MathClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Enter 5 grades separated by new line:");

            double grade;
            double totalGrade = 0;
            double averageGrade;
            int roundOff;

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("-----");
                grade = Convert.ToDouble(Console.ReadLine());
                totalGrade += grade;
            }

            averageGrade = totalGrade / 5;
            roundOff = (int)Math.Round(averageGrade);

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("The average is " + averageGrade + " and round off to " + roundOff);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
