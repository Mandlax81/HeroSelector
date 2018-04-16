using System;
using System.Collections.Generic;
using System.Text;

namespace HeroSelector
{
    partial class Program
    {
        static string getWeight(out double theWeight)
        {
            theWeight = 10;
            return "Ten";
        }
        static double lbToKg(double pounds = 5)
        {
            return (pounds * 0.45359237);
        }
        static void kgToLb(ref double weight)
        {
            weight = (weight / 0.45359237);
        }

        static int corporateSalary( int corpSalary)
        {
            int bonus = 1000000;
            corpSalary = corpSalary + bonus;
            return corpSalary;
        }

    }
}
