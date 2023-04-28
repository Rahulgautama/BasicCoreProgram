using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    class PrintPowerOf2Table
    {
        public static void PrintTable()
        {
            Console.WriteLine("Enter your number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i=1;i<=10;i++)
            {
                //var num2 = num * i;
                Console.WriteLine(i+" * "+num+" = "+num*i +" Power "+Math.Pow((num*i), 2));
            }
        }
    }
}
