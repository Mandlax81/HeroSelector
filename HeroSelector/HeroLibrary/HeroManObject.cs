using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace HeroSelector
{
    public class HeroManObject
    {
        //variables/properties of Hero Man
        private string firstName;
        private string lastName;
        private double height;
        private double weight;
        private string antagonist;
        //setters method
        public void setValues(string firstName, string lastName, double height, double weight, string antagonist)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.height = height;
            this.weight = weight;
            this.antagonist = antagonist;
        }
        //getters methods
        public string getFirstName() { return firstName; }
        public string getLastName() { return lastName; }
        public double getHeight() { return height; }
        public double getWeight() { return weight; }
        public string getAntagonist() { return antagonist; }
        //action methods
        public string Talk() { return "'Blah.'\n"; }
        public string Shout() { return "'AHH!'\n"; }
        public string Punch() { return "'Pow!'\n"; }
        public string Slash() { return "'sssLLSSH!'\n"; }
        public string Walk() { return "'dum dum.'\n"; }
        public string Run() { return "'Dum Dum Dum!'\n"; }
        public string Debate() { return "'I disagree with you...and here's why!'"; }
        public string Sing() { return "'This land is yoouuurr laaannnd...'"; }
    }
}
