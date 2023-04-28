using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    class Factor
    {
        public static void PrimeFactor()
        {
            int a, i;
            Console.WriteLine("Please enter your integer: ");
            a = int.Parse(Console.ReadLine());
            for (i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    Console.WriteLine(i + " is a factor of " + a);
                }
            }
        }
    }
}
