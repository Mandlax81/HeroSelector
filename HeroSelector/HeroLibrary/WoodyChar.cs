using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;


namespace HeroSelector
{
    partial class Program
    {
        public static void CharacterActionWoody(double heroSelect)//tousant action
        {
            HeroManObject woody = new HeroManObject();//instantiates new hero and sets the values
            woody.setValues("Woody", "Guthrie", 5.5, 150, "Bank");
            WriteLine("The hero's name is " + woody.getFirstName() + " " + woody.getLastName());
            WriteLine("Select an action for the hero: " + "\n1. Talk 2. Shout. 3. Punch. 4. Slash. 5. Walk. 6. Run. 7. Debate. 8. Sing. 0. Exit Program");
            double actionHeroSelect = Convert.ToDouble(ReadLine());
            if (actionHeroSelect == 1)
            {
                WriteLine("The hero's action is: " + woody.Talk() + ".");
                CharacterSelectMenu();
            }
            else if (actionHeroSelect == 2)
            {
                WriteLine("The hero's action is: " + woody.Shout() + ".");
                CharacterSelectMenu();
            }
            else if (actionHeroSelect == 3)
            {
                WriteLine("The hero's action is: " + woody.Punch() + ".");
                CharacterSelectMenu();
            }
            else if (actionHeroSelect == 4)
            {
                WriteLine("The hero's action is: " + woody.Slash() + ".");
                CharacterSelectMenu();
            }
            else if (actionHeroSelect == 5)
            {
                WriteLine("The hero's action is: " + woody.Walk() + ".");
                CharacterSelectMenu();
            }
            else if (actionHeroSelect == 6)
            {
                WriteLine("The hero's action is: " + woody.Run() + ".");
                CharacterSelectMenu();
            }
            else if (actionHeroSelect == 7)
            {
                WriteLine("The hero's action is: " + woody.Debate() + ".");
            }
            else if (actionHeroSelect == 8)
            {
                WriteLine("The hero's action is: " + woody.Sing() + ".");
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
