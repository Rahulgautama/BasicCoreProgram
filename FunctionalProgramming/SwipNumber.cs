using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    class SwipNumber
    {
        public static void Swip()
        {
            int a = 5;
            int b = 10;

            Console.WriteLine("a={0} b={1} Before Swip value",a,b);
            a = a * b;
            b = a / b; 
            a = a / b;

            //int temp = a;
            //a = b;
            //b = temp;
            Console.WriteLine("a={0} b={1} After Swip value",a,b);


        }
    }
}
