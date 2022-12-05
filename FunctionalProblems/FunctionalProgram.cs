using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProblems
{
    internal class FunctionalProgram
    {
        public void swaping()
        {
            int a = 20;
            int b = 40;

            Console.WriteLine("values before Swaping a = {0} ,b = {1}", a , b);

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Values after Swaping a = {0}, b = {1}",a , b);

            Console.ReadLine();
        }
    }
}
