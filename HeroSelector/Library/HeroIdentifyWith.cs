using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace HeroSelector
{
    partial class Program
    {
        public static void Copied()
        {
            string car1 = "Ghibli";
            string car2 = "GranTurismo";

            WriteLine("Original:");
            WriteLine("\tCar 1: " + car1 + "\t\tCar 2: " + car2);

            car1 = String.Copy(car2);
            WriteLine("\nCopied:");
            WriteLine("\tCar 1: " + car1 + "\tCar 2: " + car2);

            int num = car1.Length;
            char[] model = new char[num];
            car1.CopyTo(0, model, 0, num);//copies first string character of model into first string place of num
            WriteLine("\nCharacter Array:");
            foreach( char c in model) { Write(c + " "); }

            car1 = car1.Remove(4);
            WriteLine("\n\nRemoved... \tCar 1: " + car1);

            car1 = car1.Insert(0, "Maserati ");
            car1 = car1.Insert(13, "Cabrio");
            WriteLine("\nInserted... \tCar 1: " + car1);

            car1 = car1.Replace("GranCabrio", "Quattroporte");
            WriteLine("\nReplaced... \tCar 1: " + car1);
        }

        public string HeroIdentifyWith(int valueStrength, int valueIntelligence, int valueSocialTheme)//determines which hero you identify with
        {

            WriteLine("Which trait do you value more? Enter '1' for Strength or '2' for Intelligence.");//restructures points for each element
            int choiceStrVInt = 0;
            choiceStrVInt = Convert.ToInt32(ReadLine());
            WriteLine("Which social advocacy theme do you value most? Enter '1' for Anti-slavery, '2' for Civil Rights, or '3' for Women's Rights.");//restructures points for each element
            int choiceSocTheme = 0;
            choiceSocTheme = Convert.ToInt32(ReadLine());
            string HeroIdentity = "";
            if (choiceStrVInt == 1 && choiceSocTheme == 1)//choice leads to Spartacus
            {
                HeroManObject spartacus = new HeroManObject();
                spartacus.setValues("Spartacus", "Spartacus", 5.10, 185, "Crassus");
                HeroIdentity = spartacus.getFirstName();
            }
            else if (choiceStrVInt == 1 && choiceSocTheme == 2)//choice leads to Toussaint
            {
                HeroManObject toussaint = new HeroManObject();
                toussaint.setValues("Toussaint", "L'Ouverture", 5.11, 190, "Napoleon");
                HeroIdentity = toussaint.getFirstName() + " " + toussaint.getLastName();
            }
            else if (choiceStrVInt == 1 && choiceSocTheme == 3)//choice leads to Wonder Woman
            {
                HeroIdentity = "Wondrous Female";
            }
            else if (choiceStrVInt == 2 && choiceSocTheme == 1)//choice leads to Spartacus
            {
                HeroManObject spartacus = new HeroManObject();
                spartacus.setValues("Spartacus", "Spartacus", 5.10, 185, "Crassus");
                HeroIdentity = spartacus.getFirstName();
            }
            else if (choiceStrVInt == 2 && choiceSocTheme == 2)//choice leads to Toussaint
            {
                HeroManObject toussaint = new HeroManObject();
                toussaint.setValues("Toussaint", "L'Ouverture", 5.11, 190, "Napoleon");
                HeroIdentity = toussaint.getFirstName() + " " + toussaint.getLastName();
            }
            else if (choiceStrVInt == 2 && choiceSocTheme == 3)//choice leads to Eleanor
            {
                HeroManObject eleanor = new HeroManObject();
                eleanor.setValues("Eleanor", "Roosevelt", 5.5, 130, "KKK");
                HeroIdentity = eleanor.getFirstName() + " " + eleanor.getLastName();
            }
            else
            {
                WriteLine("Incorrect. Select from the options.");
                HeroIdentifyWith(valueStrength, valueIntelligence, valueSocialTheme);
            }

            string heroIdentInfo = ("The hero you would most identify with is..." + HeroIdentity + ".");
            return (heroIdentInfo);
        }
    }
}
