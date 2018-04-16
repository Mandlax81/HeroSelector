using System;
using System.Collections.Generic;
using System.Text;

namespace HeroSelector
{
    partial class Program
    {
        public static void Features()
        {
            Console.Write("Please Enter Text: ");
            string text = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("\nERROR: No Text Found!");
            }
            else
            {
                Console.WriteLine("\nThanks. You Entered\n: " + text + "");
                Console.WriteLine("\nText Length: " + text.Length);
                string query = text.StartsWith("C#") ? "Does" : "Does Not";
                Console.WriteLine("Text" + "Start With 'C#'");
                query = text.EndsWith("steps") ? "Does" : "Does Not";
                Console.WriteLine("Text " + query + " Contain 'easy'");
            }
            Console.ReadKey();
        }
    }
}
