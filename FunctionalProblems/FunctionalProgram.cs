using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProblems
{
    internal class FunctionalProgram
    {
        public void  QuetientRemainder()
       {
            int Quetient = 0, Remainder = 0;

            Console.WriteLine("enter any number");
            int n = Convert.ToInt32(Console.ReadLine());

            Quetient = n / 10;
            Remainder = n % 10;

            Console.WriteLine("Quetient of given number is {0}", Quetient );

            Console.WriteLine("Remainder of given number is {0}", Remainder);
           
            }
           
        }
    }

