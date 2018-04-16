using System;
using static System.Console;

namespace HeroSelector
{
    partial class Program
    {
        static void Main(string[] args)
        {
            /*
             * string userFirstName = "";//Welcome screen, passing values
            string userLastName = "";
            string userEmail = "";
            long userPhone = 0;
            Program userInfo = new Program();
            Console.WriteLine(userInfo.WelcomeScreen(userFirstName, userLastName, userEmail, userPhone));
            WriteLine("");
            */
            CharacterSelectMenu();//menu to select characters, and their actions
            ReadLine();
        }
    }
}
