using System;
using System.Collections.Generic;
using System.Text;

namespace NumberReader
{
    class NumberReader
    {
        public static string IsValidNumber(int testNumber)
        {
            if ((testNumber <= 10) && (testNumber >= 1))
            {
                return "Valid";
            }

            else
            {
                return "Invalid";
            }
        }
    }
}
