using System;
using System.Collections.Generic;
using System.Text;

namespace HeroSelector
{
    partial class Program
    {
        enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };//enum constants used for ConstantDay() Method

        public static void HeroDayConstant()
        {
            const string spartacusBorn = "111 BC";//essential dates
            Console.WriteLine("Spartacus is born in Thrace: " + spartacusBorn);
            const string spartacusEscapeSlavery = "73 BC";
            Console.WriteLine("Spartacus escapes slavery as a gladiator: " + spartacusEscapeSlavery);
            const string spartacusDeath = "71 BC";
            Console.WriteLine("Spartacus dies in battle: " + spartacusDeath);

            var daysType = typeof(Days);//specific days of dates
            Console.WriteLine("\nBirth Day: " + Days.Sun);
            Console.WriteLine("Index: " + (int)Days.Sun);
            Console.WriteLine("\nEscape Day: " + Days.Wed);
            Console.WriteLine("Index: " + (int)Days.Wed);
            Console.WriteLine("\nDeath Day: " + Days.Fri);
            Console.WriteLine("Index: " + (int)Days.Fri);

            string name = Enum.GetName(daysType, 0);//Gets name of the enum at position 0
            Console.WriteLine("Index: " + name);
            bool flag = Enum.IsDefined(daysType, "Sun");//stores a flag to determine if the days type has Sun included, T/F
            Console.WriteLine("Contains Sun?: " + flag);
            string name2 = Enum.GetName(daysType, 3);//Gets name of the enum at position 3, which is Wed
            Console.WriteLine("Index: " + name2);
            bool flag2 = Enum.IsDefined(daysType, "Wed");//stores a flag to determine if the days type has Wed included, T/F
            Console.WriteLine("Contains Wed?: " + flag2);
            string name3 = Enum.GetName(daysType, 5);//Gets name of the enum at position 3, which is Fri
            Console.WriteLine("Index: " + name3);
            bool flag3 = Enum.IsDefined(daysType, "Fri");//stores a flag to determine if the days type has Fri included, T/F
            Console.WriteLine("Contains Fri?: " + flag3);
            Console.ReadKey();
        }
    }
}
