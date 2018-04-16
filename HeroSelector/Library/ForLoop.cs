using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace HeroSelector
{
    partial class Program
    {
        public static void ForLoop()
        {
            string[] heros = new string[4] { "Spartacus", "Eleanor", "Tousant", "Woody" };
            Console.Write("Heros:\n");
            for(int i = 0; i < heros.Length; i++)
            {
                Console.Write((i + 1) + "." + heros[i] + ". ");
            }

            int count = 0;

            string[] villains = new string[4] { "Koch Brothers", "Jeff Bezos", "Bill Gates", "Sam Walton" };
            Console.Write("\n\nVillains:\n");
            foreach (string i in villains)
            {
                count += 1;
                Console.Write("{0}", count + "." + i + ". ");
            }
            WhileLoop();
        }

        public static void WhileLoop()
        {

            int[] nums = new int[10];
            int i = 0;
            while(i< nums.Length)
            {

                nums[i] = i;
                Console.Write(" | " + nums[i]);
                i++;
            }
            Console.Write("\n\n");

            do
            {
                i--;
                Console.Write(" | " + nums[i]);
                if(i == 7) { Console.Write(" | Six");continue; }
                if (i == 6) { Console.Write(" | Seven"); continue; }
                if (i == 3) { Console.Write(" | Done");break; }
            }
            while (i > 0);
            Console.ReadKey();

        }

        public static void ForEachVillain()
        {
            string[] villains = new string[3]
            {"Battiatus", "Pompey", "Caesar"};
            Console.WriteLine("Roman Villains...");
            int i = 1;
            foreach(string name in villains)
            {
                Console.WriteLine("Villain " + i + ". " + name);
                i++;
            }
            KeyValue();
        }

        public static void KeyValue()
        {
            Dictionary<string, string> VillainList = new Dictionary<string, string>();
            VillainList.Add("Pompey", "106 BC");
            VillainList.Add("Caesar", "100 BC");
            VillainList.Add("Battiatus", "105 BC");
            Console.WriteLine("Villain Name and Birth Date...");
            foreach(KeyValuePair<string, string> nameBirth in VillainList)
            {
                Console.WriteLine("Name: " + nameBirth.Key + ".\tBirthDay: " + nameBirth.Value + ".");
            }
            Console.ReadKey();
        }

    }
}