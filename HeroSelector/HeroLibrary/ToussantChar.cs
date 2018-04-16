using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;


namespace HeroSelector
{
    partial class Program
    {
        public static void CharacterActionToussant(double heroSelect)//tousant action
        {
            HeroManObject toussant = new HeroManObject();//instantiates new hero and sets the values
            toussant.setValues("Toussant", "L'Ouverture", 5.10, 180.5, "Napoleon");
            WriteLine("The hero's name is " + toussant.getFirstName() + " " + toussant.getLastName());
            WriteLine("Select an action for the hero: " + "\n1. Talk 2. Shout. 3. Punch. 4. Slash. 5. Walk. 6. Run. 7. Debate. 8. Sing. 0. Exit Program");
            double actionHeroSelect = Convert.ToDouble(ReadLine());
            if (actionHeroSelect == 1)
            {
                WriteLine("The hero's action is: " + toussant.Talk() + ".");
                CharacterSelectMenu();
            }
            else if (actionHeroSelect == 2)
            {
                WriteLine("The hero's action is: " + toussant.Shout() + ".");
                CharacterSelectMenu();
            }
            else if (actionHeroSelect == 3)
            {
                WriteLine("The hero's action is: " + toussant.Punch() + ".");
                CharacterSelectMenu();
            }
            else if (actionHeroSelect == 4)
            {
                WriteLine("The hero's action is: " + toussant.Slash() + ".");
                CharacterSelectMenu();
            }
            else if (actionHeroSelect == 5)
            {
                WriteLine("The hero's action is: " + toussant.Walk() + ".");
                CharacterSelectMenu();
            }
            else if (actionHeroSelect == 6)
            {
                WriteLine("The hero's action is: " + toussant.Run() + ".");
                CharacterSelectMenu();
            }
            else if (actionHeroSelect == 7)
            {
                WriteLine("The hero's action is: " + toussant.Debate() + ".");
            }
            else if (actionHeroSelect == 8)
            {
                WriteLine("The hero's action is: " + toussant.Sing() + ".");
                CharacterSelectMenu();
            }
            else if (actionHeroSelect == 0)
            {
                Environment.Exit(0);
            }
            {
                WriteLine("Select an action");
                CharacterSelectMenu();
            }
        }
    }
}
