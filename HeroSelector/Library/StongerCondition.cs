using System;
using System.Collections.Generic;
using System.Text;

namespace HeroSelector
{
    partial class Program
    {
        public static void StrongerCondition(int spartacusStrength, int crassusStrength)
        {
            //int spartacusStrength = 10;
            //int crassusStrength = 12;

            string verb = (spartacusStrength != 1) ? " is " : " are ";//determines which verb is used
            Console.Write("Strength" + verb + spartacusStrength + ".\n");
            string verb2 = (crassusStrength != 1) ? " is " : " are ";
            Console.Write("Strength" + verb2 + crassusStrength + ".\n");

            string stronger = (spartacusStrength > crassusStrength) ? "Spartacus" : "Crassus";//determines who the stronger of the two are
            Console.Write("The strongest Champion is " + stronger + ".");
            Console.ReadKey();
        }
    }
}
