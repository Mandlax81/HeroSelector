using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;


namespace HeroSelector
{
    partial class Program
    {
        public static void HeroStatistics()//gets hero statistics
        {
            HeroManObject hero = new HeroManObject();
            hero.setValues("Spartacus", "Spartacus", 6.2, 180.5, "Crassus");
            string statsHero = String.Format("{0} {1} is {2} in height, and {3} pounds. The antagonist is {4}",
                hero.getFirstName(), hero.getLastName(), hero.getHeight(), hero.getWeight(), hero.getAntagonist());
            WriteLine(statsHero);
            ReadKey();
        }
        public static void HeroActionTalk()
        {
            HeroManObject hero = new HeroManObject();
            WriteLine("Hero Action: " + hero.Talk());
            ReadKey();
        }
    }
}
