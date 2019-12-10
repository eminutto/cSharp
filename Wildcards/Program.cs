using System;

namespace Wildcards
{
    class Program
    {
        static void Main(string[] args)
        {
            WildcardsClass wc = new WildcardsClass();

            Console.WriteLine(wc.Wildcards("$**+* 9mmmrrrkbb"));

            Console.WriteLine(wc.WildcardCharacters("++++ kkjk"));

            Console.Write(helloWorld());

        }

        public static string helloWorld()
        {
            return "hello world";
        }



    }
}
