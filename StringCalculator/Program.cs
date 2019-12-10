using System;

namespace StringCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            StringCalculatorClass sc = new StringCalculatorClass();

            Console.WriteLine("Result: " + sc.StringCalculator("1,2,3,4"));
        }
    }
}
