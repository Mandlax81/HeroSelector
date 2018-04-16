using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;


namespace HeroSelector
{
    partial class Program
    {
        public static void CharacterSelectMenu()//selects character. Then calls method to select the action of each character.
        {
            WriteLine("Select a hero: \n1. Spartacus 2. Tousant L'Ouverture 3. Eleanor Roosevelt 4. Woodie Guthrie 0. Exit Program");
            double heroSelect = Convert.ToDouble(ReadLine());

            if (heroSelect == 1)
            {
                CharacterActionSpartacus(heroSelect);
            }
            else if (heroSelect == 2)
            {
                CharacterActionEleanor(heroSelect);
            }
            else if (heroSelect == 3)
            {
                CharacterActionToussant (heroSelect);
            }
            else if (heroSelect == 4)
            {
                CharacterActionEleanor(heroSelect);
            }
            else if (heroSelect == 0)
            {
                Environment.Exit(0);
            }
        }
    }
}
