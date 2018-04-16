using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;


namespace HeroSelector
{
    partial class Program
    {
        public static void CharacterActionEleanor(double heroSelect)//eleanor action
        {
            HeroManObject eleanor = new HeroManObject();//instantiates new hero and sets the values
            eleanor.setValues("Eleanor", "Roosevelt", 5.2, 120.5, "KKK");
            WriteLine("The hero's name is " + eleanor.getFirstName() + " " + eleanor.getLastName());
            WriteLine("Select an action for the hero: " + "\n1. Talk 2. Shout. 3. Punch. 4. Slash. 5. Walk. 6. Run. 7. Debate. 8. Sing. 0. Exit Program");
            double actionHeroSelect = Convert.ToDouble(ReadLine());
            if (actionHeroSelect == 1)
            {
                WriteLine("The hero's action is: " + eleanor.Talk() + ".");
                CharacterSelectMenu();
            }
            else if (actionHeroSelect == 2)
            {
                WriteLine("The hero's action is: " + eleanor.Shout() + ".");
                CharacterSelectMenu();
            }
            else if (actionHeroSelect == 3)
            {
                WriteLine("The hero's action is: " + eleanor.Punch() + ".");
                CharacterSelectMenu();
            }
            else if (actionHeroSelect == 4)
            {
                WriteLine("The hero's action is: " + eleanor.Slash() + ".");
                CharacterSelectMenu();
            }
            else if (actionHeroSelect == 5)
            {
                WriteLine("The hero's action is: " + eleanor.Walk() + ".");
                CharacterSelectMenu();
            }
            else if (actionHeroSelect == 6)
            {
                WriteLine("The hero's action is: " + eleanor.Run() + ".");
                CharacterSelectMenu();
            }
            else if (actionHeroSelect == 7)
            {
                WriteLine("The hero's action is: " + eleanor.Debate() + ".");
            }
            else if (actionHeroSelect == 8)
            {
                WriteLine("The hero's action is: " + eleanor.Sing() + ".");
                CharacterSelectMenu();
            }
            else if (actionHeroSelect == 0)
            {
                Environment.Exit(0);
            }
            {
                WriteLine("Select an action");
                CharacterSelectMenu();
            };
        }
    }
}
