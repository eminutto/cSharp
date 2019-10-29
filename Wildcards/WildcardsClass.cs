using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Wildcards
{
    class WildcardsClass
    {
        public WildcardsClass()
        {

        }

        public bool Wildcards(string input)
        {
            string[] values = input.Split(' ');
            string pattern = values[0];
            string value = values[1];

            string newPattern = "^";


            Console.WriteLine("Values: ");
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }

            char[] charArray = pattern.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == '+')
                {
                    newPattern += @"[a-zA-Z]";
                }

                if (charArray[i] == '$')
                {
                    newPattern += @"[1-9]\d*";
                }

                if (charArray[i] == '*')
                {
                    if (i == charArray.Length - 1 || charArray[i + 1] != '{')
                    {
                        newPattern += @"\w{3}";
                    }
                    else if (charArray[i + 1] == '{' && Char.IsDigit(charArray[i + 2]))
                    {
                        newPattern += @"\w{";
                        newPattern += charArray[i + 2] + "}";
                    }

                }

            }

            newPattern += "$";

            Console.WriteLine("Pattern: " + newPattern);


            Regex regex = new Regex(newPattern);

            bool match = regex.IsMatch(value);

            return match;
        }

        public bool WildcardCharacters(string input)
        {
            string[] values = input.Split(' ');
            string pattern = values[0];
            string value = values[1];

            string newPattern = "^";


            Console.WriteLine("Values: ");
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }

            //pattern = pattern.Replace("+", "[a-zA-Z0-9]");
            //pattern = pattern.Replace("*", @"\w{3}");
            //pattern = pattern.Replace("*{5}", @"\w{5}");

            char[] charArray = pattern.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == '+')
                {
                    newPattern += @"[a-zA-Z0-9]";
                }

                if (charArray[i] == '*')
                {
                    if (i == charArray.Length - 1 || charArray[i + 1] != '{')
                    {
                        newPattern += @"\w{3}";
                    }
                    else if (charArray[i + 1] == '{' && Char.IsDigit(charArray[i + 2]))
                    {
                        newPattern += @"\w{";
                        newPattern += charArray[i + 2] + "}";
                    }

                }

            }

            newPattern += "$";

            Console.WriteLine("Pattern: " + newPattern);


            Regex regex = new Regex(newPattern);

            bool match = regex.IsMatch(value);

            return match;

        }
    }
}
