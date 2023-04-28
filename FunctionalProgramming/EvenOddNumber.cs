using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    class EvenOddNumber
    {
        public static void FindEvenOddNumber()
        {
            Console.WriteLine("Enter your number");
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 == 0)
                    Console.WriteLine(num + " is Even Number");
                else
                    Console.WriteLine(num + " is Odd Number");
            }
            catch(Exception e)
            {
                Console.WriteLine("Please Enter only Number");
            }
        }
    }
}
