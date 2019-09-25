using System;
using System.Collections.Generic;
using System.Text;

namespace NumberReader
{
    class NumberReader
    {
        public static void IsValidNumber(int testNumber)
        {
            if ((testNumber <= 10) && (testNumber >= 1))
            {
                Console.WriteLine("Valid");
            }

            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
