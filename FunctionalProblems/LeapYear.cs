using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProblems
{
    internal class LeapYear
    {
        public void Leapyear()
        {
            Console.WriteLine("Enter the Year :");
            int Year = Convert.ToInt32(Console.ReadLine());

            if (((Year % 4 == 0) && (Year % 100 != 0) || (Year % 400 == 0)))
            {
                Console.WriteLine("{0} is a leap year", Year);

            }
            else
            {
                Console.WriteLine("{0} is not a Leap year", Year);
            }
            
        }
    }
}
