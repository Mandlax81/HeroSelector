using System;
using System.Collections.Generic;
using System.Text;

namespace HeroSelector
{
    partial class Program
    {
        public static void AmountGoldPerRegion1(int gold1, int gold2, int gold3)
        {
            int sumRegion1;
            sumRegion1 = gold1 + gold2 * gold3;
            Console.Write("Gold in Region 1:\t\t" + sumRegion1 + "\n");
        }

        public static void AmountGoldPerRegion2(int gold1, int gold2, int gold3)
        {
            int sumRegion2;
            sumRegion2 = gold1 + gold2 * gold3;
            Console.Write("Gold in Region 2:\t\t" + sumRegion2 + "\n");
        }

        public static void AmountGoldPerRegion3(int gold1, int gold2, int gold3)
        {
            int sumRegion3;
            sumRegion3 = gold1 + gold2 * gold3;
            Console.Write("Gold in Region 3:\t\t" + sumRegion3);
        }
    }
}
