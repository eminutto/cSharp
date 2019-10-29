using System;

namespace Wildcards
{
    class Program
    {
        static void Main(string[] args)
        {
            WildcardsClass wc = new WildcardsClass();

            Console.WriteLine(wc.Wildcards("*** kkk"));

            Console.WriteLine(wc.WildcardCharacters("++++ kkjk"));
        }
    }
}
