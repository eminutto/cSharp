using System;
using System.Collections.Generic;
using System.Text;

namespace StringCalculator
{
    public class StringCalculatorClass
    {
        public StringCalculatorClass()
        {

        }

        public int StringCalculator(string numbers)
        {
            int result = 0;

            if (string.IsNullOrEmpty(numbers))
            {
                return result = 0;

            }else if (numbers.Length ==1)
            {
                return result = int.Parse(numbers);
            }
            else
            {
                string[] stringArray = numbers.Split(',');

                int[] intArray = new int[stringArray.Length];

                for (int i = 0; i < stringArray.Length; i++)
                {
                    intArray[i] = int.Parse(stringArray[i]);

                    result = result + intArray[i];
                }

                for (int i = 0; i < intArray.Length; i++)
                {
                    Console.WriteLine(intArray[i]);
                }

                return result;
            }

            
        }
    }
}
