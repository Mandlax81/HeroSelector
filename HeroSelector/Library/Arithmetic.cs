using System;
using System.Collections.Generic;
using System.Text;

namespace HeroSelector
{
    partial class Program
    {
        public static void TroopsArithmetic()//inventory of troop numbers, arms, and willpower
        {
            int heroTroops = 30000;
            int heroTroopsWill = 10;
            int heroTroopsArms = 3;
            int villainTroops = 100000;
            int villainTroopsWill = 8;
            int villainTroopsArms = 10;
            Console.WriteLine("Troops added:\t: " + (heroTroops + villainTroops));
            Console.WriteLine("Troops substracted:\t: " + (heroTroops - villainTroops));
            Console.WriteLine("Troops multiplied:\t: " + (heroTroops * villainTroops));
            Console.WriteLine("Troops divided:\t: " + (heroTroops / villainTroops));
            Console.WriteLine("Troops modulus:\t: " + (heroTroops % villainTroops));

            Console.WriteLine("\nHero Troops Postfix:\t: " + (heroTroops++));
            Console.WriteLine("Hero Troops Postfix Result...:\t: " + (heroTroops));

            Console.WriteLine("\nVillain Troops Prefix:\t " + (++villainTroops));
            Console.WriteLine("Villain Troops Prefix Result...\t: " + (villainTroops));

            Console.WriteLine("\nWillpower of Hero Troops:\t" + (heroTroopsWill * 3));
            Console.WriteLine("Willpower of Villain Troops:\t" + (villainTroopsWill * 3));

            Console.WriteLine("\nArmanents of Hero Troops:\t" + (heroTroopsArms * 3));
            Console.WriteLine("Armanents of Villain Troops:\t" + (villainTroopsArms * 3));
        }
        /*
        public static void TroopsAssigned()
        {
            int a;//declare variables
            int b;
            Console.Write("Assign Values: ");//assign values
            Console.Write("\t a = " + ( a = 8));
            Console.WriteLine("\t b = " + (b = 4));

            Console.Write("\n\nAdd and Assign: ");
            Console.Write("\t a = " + (a += b));//12

            Console.Write("\n\nSubtract and Assign: ");
            Console.Write("\t a = " + (a -= b));//8

            Console.Write("\n\nMultiply and Assign: ");
            Console.Write("\t a = " + (a *= b));//32

            Console.Write("\n\nDivide and Assign: ");
            Console.Write("\t a = " + (a /= b));//8

            Console.Write("\n\nModulus and Assign: ");
            Console.Write("\t a = " + (a %= b));//0
        }
        */
    }
}
