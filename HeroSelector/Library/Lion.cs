using System;
using System.Collections.Generic;
using System.Text;

namespace HeroSelector
{
    public class LionAction //base class of Lion, with actions
    {
        public virtual void talk()
        {
            Console.WriteLine("A Lion Talks");
        }
        public virtual void pounce()
        {
            Console.WriteLine("A Lion Pounces");
        }
    }
    public class RomanLion: LionAction//overrides actions of original Lion
    {
        public override void talk()
        {
            Console.WriteLine("Roman Lion Says: Rrr");
        }
        public override void pounce()
        {
            Console.WriteLine("A Roman Lion Pounces...");
            base.pounce();
        }
    }
    public class Panther: LionAction//overrides actions of original Lion
    {
        public override void talk()
        {
            Console.WriteLine("Panther Says: Grra.");
        }
        public override void pounce()
        {
            Console.WriteLine("A Panther Pounces...");
            base.pounce();
        }
    }
}
