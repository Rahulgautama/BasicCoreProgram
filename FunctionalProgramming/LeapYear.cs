using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    public class LeapYear
    {
        public static void FindLeapYear()
        {
            Console.WriteLine("Enter Year : ");

            string yearLength = Console.ReadLine();
            try
            {
                if (yearLength.Length == 4)
                {
                    int year = Convert.ToInt32(yearLength);
                    if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                        Console.WriteLine("{0} is a Leap Year.", year);
                    else
                        Console.WriteLine("{0} is not a Leap Year.", year);
                }
                else
                {
                    Console.WriteLine("Please Enter Four Digit number ");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Please Enter only number");
            }

        }
    }
}
