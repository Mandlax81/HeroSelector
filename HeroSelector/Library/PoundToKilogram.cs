using System;
using System.Collections.Generic;
using System.Text;

namespace HeroSelector
{
    partial class Program
    {
        //one way of passing in lbs to get kgs
        public static void PoundsToKilograms(int pounds)//multiply .45 by the lbs to get the kgs
        {
            int Pounds = pounds;
            Console.WriteLine("The weight in kilograms is:{0:F3}", pounds * .45);
        }
        //one way of passing in kgs to get lbs
        public static void KilogramsToPounds(int kilo)//divide the kgs by 2.2 to get the pounds
        {
            int Kilo = kilo;
            Console.WriteLine("The weight in pounds is:{0:F3}", kilo / 2.2);
        }  
    }
}

