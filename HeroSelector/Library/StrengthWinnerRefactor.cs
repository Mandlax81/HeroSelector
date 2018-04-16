using System;
using System.Collections.Generic;
using System.Text;

namespace HeroSelector
{
    partial class Program
    {
        public static int Factorial(int num)
        {
            int result;
            if(num == 1)
            {
                result = 1;
            }
            else
            {
                result = (Factorial(num - 1) * num);//else re-call the method, passing in ex.5 -1 which is 4 *5 is 20, return result
            }
            return result;
        }
        public static void ComputeFactorials(int num, int max)
        {
            while(num <= max)
            {
                Console.Write("Factorial Of " + num + " : ");
                Console.WriteLine(Factorial(num));
                num++;
            }
        }
        public static void StrengthPrompt()//prompts for users strength determination
        {
            Console.WriteLine("What is the Hero's Strength? ");
            int strengthHero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the Villain's Strength? ");
            int strengthVillain = Convert.ToInt32(Console.ReadLine());                
            int winner = (StrengthWinner(strengthHero, strengthVillain));
            StrengthWinnerDeclair(winner);
            Console.ReadKey();
        }


        public static int StrengthWinner(int strengthHero, int strengthVillain)//determines winner
        {
            int winner;
            if (strengthHero > strengthVillain)
            {
                winner = 1;
            }
            else if (strengthHero < strengthVillain)
            {
                winner = 2;
            }
            else
            {
                winner = 3;//else re-call the method, passing in ex.5 -1 which is 4 *5 is 20, return result                
            }
            return winner;
        }
        public static void StrengthWinnerDeclair(int winner)//declairs the winner, creating a new heroman or villainMan object
        {
            while (winner == 1)
            {
                HeroManObject spartacus = new HeroManObject();
                spartacus.setValues("Spartacus", "Spartacus", 6.2, 180.5, "Crassus");
                Console.WriteLine("The winner is: " + spartacus.getFirstName());                
                Console.ReadKey();
                StrengthPrompt();
            }
            while (winner == 2)
            {
                VillainManObject crassus = new VillainManObject();
                crassus.setFirstName("Marcus");
                crassus.setLastName("Crassus");
                Console.WriteLine("The winner is: " + crassus.getLastName());
                Console.ReadKey();
                StrengthPrompt();
            }
            while (winner == 3)
            {
                Console.WriteLine("It is a tie. {0}{0} are equally strong.");
                StrengthPrompt();
            }
        }
    }
}
