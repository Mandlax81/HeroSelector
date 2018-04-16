using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace HeroSelector
{
    partial class Program
    {
        public string WelcomeScreen(string userFirstName, string userLastName, string userEmail, long userPhone)
        {
            WriteLine("Welcome. Please enter your contact details: ");//gets contact details and reformats them 
            Write("First Name: ");
            userFirstName = ReadLine();
            Write("Last Name: ");
            userLastName = ReadLine();
            string[] fullName = new string[2] { userFirstName, userLastName };
            string fullNameCombine = String.Concat(fullName[0]," ", fullName[1]);

            Write("E-mail: ");
            userEmail = ReadLine();
            Write("Phone Number: ");
            userPhone = Convert.ToInt64(ReadLine());
            string userInfo = ("Welcome " + fullNameCombine.Trim() + ". I see you can be reached at " +
                userEmail + " and " + userPhone + ".");
            return (userInfo);
        }
    }
}
