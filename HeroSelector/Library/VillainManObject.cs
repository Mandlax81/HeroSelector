using System;
using System.Collections.Generic;
using System.Text;

namespace HeroSelector
{
    public class VillainManObject
    {
        //variables/properties of Villain Man
        private string firstName;
        private string lastName;
        private double height;
        private double weight;
        private string protagonist;
        //constructor method to set default values
        public VillainManObject()
        {
            firstName = "Marcus";
            lastName = "Crassus";
            height = 5.5;
            weight = 150.5;
            protagonist = "Spartacus";
        }
        //setters
        public void setFirstName(string firstName) { this.firstName = firstName; }
        public void setLastName(string lastName) { this.lastName = lastName; }
        public void setHeight(double height) { this.height = height; }
        public void setWeight(double weight) { this.weight = weight; }
        public void setProtagonist(string protagonist) { this.protagonist = protagonist; }
        //getters
        public string getFirstName() { return firstName; }
        public string getLastName() { return lastName; }
        public double getHeight() { return height; }
        public double getWeight() { return weight; }
        public string getProtagonist() { return protagonist; }
        //action methods
        public string Talk() { return "Blah.\n"; }
        public string Shout() { return "AHH!\n"; }
        public string Punch() { return "Pow!\n"; }
        public string Slash() { return "sssLLSSH!\n"; }
        public string Walk() { return "dum dum.\n"; }
        public string Run() { return "Dum Dum Dum!\n"; }
        public string Command() { return "Approach!\n"; }
        public string Punish() { return "Kneel.\n"; }
    }
}
