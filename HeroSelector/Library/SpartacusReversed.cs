using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
//Reverses characters of peoples' names
namespace HeroSelector
{
    partial class Program
    {   //way to reverse name 1
        public static void HeroNameReversed()
        {
            HeroManObject heroReversed = new HeroManObject();
            heroReversed.setValues("Spartacus", "Spartacus", 5.10, 185, "Crassus");
            string output = new string(heroReversed.getFirstName().ToCharArray().Reverse().ToArray());
            Console.WriteLine("Hero name is " + heroReversed.getFirstName() + ".");
            Console.WriteLine("Hero name reversed is " + output + ".");
            Console.ReadKey();
            //way to reverse name 2
            string heroReversed2 = "Spartacus";
            string output2 = "";
            for (int i = heroReversed2.Length - 1; i >= 0; i--)
            {
                output2 += heroReversed2[i];
            }
            Console.WriteLine("Hero name reversed is " + output + ".");
            //way to reverse name 3, using extension method of SpartacusReversed2
            Console.WriteLine("hello world".Reverse());

            Console.ReadKey();
        }
    }
}
