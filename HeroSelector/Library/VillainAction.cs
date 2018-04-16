using System;
using System.Collections.Generic;
using System.Text;

namespace HeroSelector
{
    partial class Program
    {
        private static void VillainStatistics()//gets villain statistics
        {
            VillainManObject villain = new VillainManObject();
            villain.setFirstName("Marcus"); villain.setLastName("Crassus"); villain.setHeight(5.10); villain.setWeight(210); villain.setProtagonist("Spartacus");
            string villainfirstName = villain.getFirstName(); string villainLastName = villain.getLastName(); double villainHeight = villain.getHeight();
            double villainWeight = villain.getWeight(); string villainProtagonist = villain.getProtagonist();
            Console.WriteLine(villainfirstName + " " + villainLastName + " is " + villainHeight + " feet in height. The weight is " + villainWeight + ". The protagonist is " + villainProtagonist + ".");
            Console.ReadKey();
        }
        private static void VillainActionTalk()
        {
            VillainManObject villain = new VillainManObject();
            Console.WriteLine("Villain Action: " + villain.Command());
            Console.ReadKey();
        }
    }
}
