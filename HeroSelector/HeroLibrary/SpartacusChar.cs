using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;


namespace HeroSelector
{
    partial class Program
    {
        public static void CharacterActionSpartacus(double heroSelect)//spartacus action menu
        {
            HeroManObject spartacus = new HeroManObject();//instantiates new hero and sets the values
            spartacus.setValues("Spartacus", "Spartacus", 5.10, 185.5, "Crassus");
            WriteLine("\nWelcome " + spartacus.getFirstName() + " " + spartacus.getLastName());
            WriteLine("Select an action for the hero: " + "\n1. Talk 2. Shout. 3. Punch. 4. Slash. 5. Walk. 6. Run. 7. Debate. 8. Sing. 0. Exit Program");
            double actionHeroSelect = Convert.ToDouble(Console.ReadLine());
            if (actionHeroSelect == 1)
            {
                WriteLine("The hero's action is: " + spartacus.Talk() + ".");
                CharacterSelectMenu();
            }
            else if (actionHeroSelect == 2)
            {
                WriteLine("The hero's action is: " + spartacus.Shout() + ".");
                CharacterSelectMenu();
            }
            else if (actionHeroSelect == 3)
            {
                WriteLine("The hero's action is: " + spartacus.Punch() + ".");
                CharacterSelectMenu();
            }
            else if (actionHeroSelect == 4)
            {
                WriteLine("The hero's action is: " + spartacus.Slash() + ".");
                CharacterSelectMenu();
            }
            else if (actionHeroSelect == 5)
            {
                WriteLine("The hero's action is: " + spartacus.Walk() + ".");
                CharacterSelectMenu();
            }
            else if (actionHeroSelect == 6)
            {
                WriteLine("The hero's action is: " + spartacus.Run() + ".");
                CharacterSelectMenu();
            }
            else if (actionHeroSelect == 7)
            {
                WriteLine("The hero's action is: " + spartacus.Debate() + ".");
            }
            else if (actionHeroSelect == 8)
            {
                WriteLine("The hero's action is: " + spartacus.Sing() + ".");
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
