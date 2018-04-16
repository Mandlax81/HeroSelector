using System;
using System.Collections.Generic;
using System.Text;

namespace HeroSelector
{
    public class Tribe//we're creating a tribe, this being the base class
    {
        public Tribe()//we're calling the tribe
        {
            Console.WriteLine("Tribe Called for Backup because...");
        }
        public Tribe(int num)//we're calling the tribe and want some kind of number back
        {
            Console.WriteLine("Tribe Called for Specific Backup: " + num + " troops, because...");
        }

        public Tribe(string message)
        {
            Console.WriteLine("The General Message was made:" + message);
        }

    }

    public class MaleMember : Tribe //class derived from base
    {
        public MaleMember()
        {
            Console.WriteLine("\tMale Member Called for General Backup!\n");
        }
    }

    public class FemaleMember : Tribe//class derived from class
    {
        public FemaleMember()
        {
            Console.WriteLine("\tFemale Member Called for General Backup!\n");
        }
        public FemaleMember(int num): base(num)
        {
            Console.WriteLine("\tFemale Member Called for Specific Backup!: " + num);
        }
        public FemaleMember(string message): base(message)
        {
            Console.WriteLine("\tFemale Member Made the following message: " + message);
        }

    }


}
