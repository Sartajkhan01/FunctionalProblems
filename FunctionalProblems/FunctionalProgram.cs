using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProblems
{
    internal class FunctionalProgram
    {
        public void LargestNumber()
        {
            int a = 20;
            int b = 10;
            int c = 50;

            if(a > b && a > c)
            {
                Console.WriteLine("a is the largest Number");
            }
            else if (b> c && b>a)
            {
                Console.WriteLine("b is the largest Number");
            }
            else
            {
                Console.WriteLine("c is the largest number");
            }
           
        }
    }
}
