using System;
using System.Collections.Generic;
using System.Text;

namespace HeroSelector
{
    public abstract class Bear
    {
        public abstract void Talk();

        public abstract void Walk();
    }
    public sealed class BlackBear: Bear//implements and overrides Bear
    {
        public override void Talk()
        {
            Console.WriteLine("Black Bear Says: 'Grow'");
        }
        public override void Walk()
        {
            Console.WriteLine("A Black Bear Walks Upright...");
        }        
    }
    public sealed class BrownBear : Bear//implements and overrides Bear
    {
        public override void Talk()
        {
            Console.WriteLine("Brown Bear Says: 'Graw'");
        }

        public override void Walk()
        {
            Console.WriteLine("A Brown Bear Walks Upright...");
        }
    }
    public sealed class Caller//this method accepts an object argument of Bear type, it helps to direct which one to use
    {
        public void describe(Bear obj)
        {
            obj.Talk();
            obj.Walk();
        }
    }


}
