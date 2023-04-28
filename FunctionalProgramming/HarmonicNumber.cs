using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    class HarmonicNumber
    {
        
        public static void PrintHamonicNumber()
        {
            try
            {
                Console.WriteLine("Enter number of length");
                int num = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= num; i++)
                {
                    Console.Write("1/" + i + " +");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Please Enter only Number");
            }
        }
    }
}
