using System;
using System.Collections.Generic;
using System.Text;

namespace HeroSelector
{
    partial class Program//selects blade of choice
    {
        public static string BladeOfChoice()
        {
            string bladeOfChoice = "Half-sword";
            return "The weapon is a: " + bladeOfChoice + ".";
        }
        public static double BladeSize ()//selectes blade size
        {
            double bladeSize = 6.5;
            return bladeSize;
        }
        public static int BladeAge()//selects blade age
        {
            int bladeAge = 10;
            return bladeAge;
        }
    }
}
