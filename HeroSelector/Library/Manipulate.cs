using System;
using System.Collections.Generic;
using System.Text;

namespace HeroSelector
{
    partial class Program
    {
        public static void Manipulate()
        {
            Console.Write("Please Enter Text");
            string text = Console.ReadLine();
            Console.Write("\nThanks. You Entered:\n'" + text + "'");
            Console.WriteLine("\t\tText Length: " + text.Length);

            text = text.Trim();
            Console.Write("\nTrimmed:\t'" + text + "'");
            Console.WriteLine("\tText Length: " + text.Length);

            string upper = text.ToUpper();
            Console.WriteLine("\nUpperCase:\t'" + upper + "'");

            string lower = text.ToLower();
            Console.WriteLine("LowerCase:\t" + lower + "'");

            upper = upper.PadLeft(40);
            lower = lower.PadRight(40, '#');
            text = text.PadLeft(30, '*').PadRight(40,'*');

            Console.WriteLine("\nPadded Left:\t'" + upper + "'");
            Console.WriteLine("\nPadded Right:\t'" + lower + "'");
            Console.WriteLine("\nPadded Both:\t'" + text + "'");

            Console.WriteLine("\nTrimmed Start:\t" + upper.TrimStart() + "'");
            Console.WriteLine("\nTrimmed End:\t" + upper.TrimEnd() + "'");
            Console.ReadKey();
        }

        public static void Joined()
        {
            string[] a = new string[3] { "Alpha", "Bravo", "Charlie" };
            string s = String.Concat(a[0], a[1]);
            string s2 = String.Concat(a[1], a[2]);
            Console.WriteLine("Concatenated:\t" + s);
            Console.WriteLine("Concatenated:\t" + s2);

            s = String.Join("", a[0], a[1]);
            Console.WriteLine("Joined:\t\t" + s);

            int num = String.Compare(a[0], a[1]);
            Console.WriteLine(a[0] + " v " + a[1] + ":\t" + num);
            num = String.Compare(a[2], a[1]);
            Console.WriteLine(a[2] + " v " + a[1] + ":\t" + num);
            num = a[1].CompareTo(a[1]);
            Console.WriteLine(a[1] + " v " + a[1] + ":\t" + num + "\n");

            bool flag = (a[0] == a[1]);
            Console.WriteLine(a[0] + " == " + a[1] + ":\t\t" + flag);
            flag = a[2].Equals(a[2]);
            Console.WriteLine(a[2] + " == " + a[2] + ":\t\t" + flag);
            Console.ReadKey();
        }
    }
}
