using System;
using System.Collections.Generic;
using System.Text;

namespace HeroSelector
{
    partial class Program
    {
        public static void WealthComparison()
        {
            int romanSenator = 10, romanCitizen = 6, celticGladiator = 2, thracianGladiator = 2, celticSlave = 1, thracianSlave = 1, celticCaptive = 0;
            string heroName = "Spartacus", villainName = "Crassus";
            Console.Write("Status Comparison:");
            Console.Write("\t Wealth of Celtic Gladiator = Thracian Gladiator: " + (celticGladiator == thracianGladiator));//true
            Console.Write("\n\t\t\t Wealth of Celtic Gladiator = Roman Citizen: " + (celticGladiator == romanCitizen));//false
            Console.Write("\n\t\t\t Spartacus is the same as Crassus?: " + (heroName == villainName));//false
            Console.Write("\n\t\t\t Spartacus is different from Crassus?: " + (heroName != villainName));//true
            Console.Write("\n\t\t\t Wealth of Roman Citizen is greater than Roman Senator?: " + (romanCitizen >= romanSenator));//false
            Console.Write("\n\t\t\t Wealth of Celtic Slave is less than Celtic Gladiator?: " + (celticSlave <= celticGladiator));//true
            Console.Write("\n\t\t\t Wealth of Celtic Captive is equal to Celtic Slave?: " + (celticCaptive == romanSenator));//false
            Console.Write("\n\t\t\t Wealth of Celtic Slave is equal to Thracian Slave?: " + (celticSlave == thracianSlave));//true

            bool spartacus = true, crassus = false;
            Console.Write("\tSpartacus and Spartacus" + (spartacus && spartacus)); //true 
            Console.Write("\tSpartacus or Spartacus" + (spartacus || spartacus));//true
            Console.Write("\tSpartacus not Spartacus" + (!spartacus));//false

            Console.Write("\tCrassus is Spartacus" + (spartacus && crassus));//false
            Console.Write("\tSpartacus and Spartacus" + (spartacus || crassus));//true
            Console.Write("\tCrassus not Crassus" + (!crassus));//false

            Console.ReadKey();
        }
    }
}
