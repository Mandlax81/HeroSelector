using System;
using System.Collections.Generic;
using System.Text;

namespace HeroSelector
{
    public class Woman
    {
        public void speak()
        {
            Console.Write("Hello:");
        }

        public void speak(string message)
        {
            Console.WriteLine(message + "!\n");
        }
    }

    public class Mujer: Woman//hides original base method
    {
        public new void speak(string message)
        {
            base.speak();
            Console.WriteLine(message);
        }
    }


}
