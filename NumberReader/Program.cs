using System;
using NumberReader;

namespace NumberReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 10");
            var numberInput = Console.ReadLine();

            NumberReader.IsValidNumber(int.Parse(numberInput));
        }
    }
}
