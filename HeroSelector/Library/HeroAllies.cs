using System;
using System.Collections.Generic;
using System.Text;

namespace HeroSelector
{
    partial class Program
    {
        public static void HeroAllies()//integrate this into a loop, and add a random element to the winner
        {
            string[] heroAllies = new string[3] { "Crixus", "Agron", "Gannicus" };
            Console.WriteLine("First Ally: " + heroAllies[0]);
            Console.WriteLine("Second Ally: " + heroAllies[1]);
            Console.WriteLine("Third Ally: " + heroAllies[2]);
            string[,] heroAlliesTablePlacement = new string[2, 4] { { "General", "Crixus", "Agron", "Gannicus" }, { "War", "Third Servile War", "Third Servile War", "Third Servile War" } };//two columns, three rows, 2D array
            Console.WriteLine("Allies: " + heroAlliesTablePlacement[0, 1] + ", " + heroAlliesTablePlacement[0, 2] + ", " + heroAlliesTablePlacement[0, 3]);
            Console.WriteLine("War fought in: " + heroAlliesTablePlacement[1, 1] + ", " + heroAlliesTablePlacement[1, 2] + ", " + heroAlliesTablePlacement[1, 3]);
            Console.ReadKey();
        }
    }
}
