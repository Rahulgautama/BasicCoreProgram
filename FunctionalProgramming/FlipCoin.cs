using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    public class FlipCoin
    {
        public static void FlipCoinHeadTail() {
            try {
                double heads = 0;
                double tails = 0;

                for (int i = 1; i <= 10; i++)
                {
                    Random random = new Random();
                    int value = random.Next(2);
                    if (value == 0)
                    {
                        heads += 1;
                    }
                    else
                    {
                        tails += 1;
                    }
                }
                double percentage = (heads / 10) * 100;
                Console.WriteLine("Number of flip heads " + heads + " Times and percentage " + percentage + "%");
                double percentageOfTails = (tails / 10) * 100;
                Console.WriteLine("Number of flip tails " + tails + " Times and percentage " + percentageOfTails + "%");
            }
            catch(Exception e)
            {
                Console.WriteLine("Please Enter only Number");
            }
          }
    }
}
