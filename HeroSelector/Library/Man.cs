using System;
using System.Collections.Generic;
using System.Text;

namespace HeroSelector
{
    public class Man
    {
        protected string firstName;
        protected string lastName;
        protected double height;
        protected double weight;
        protected string antagonist;

        public void setValues(string firstName, string lastName, double height, double weight, string antagonist)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.height = height;
            this.weight = weight;
            this.antagonist = antagonist;
        }
    }

    public class Hero1Man : Man
    {
        public string FullNameHero1() { return firstName + " " + lastName; }
        public double HeightWeightHero1() { return (height + weight); }
        public string AntagonistOfHero1() { return antagonist; }
    }

    public class Villain1Man : Man
    {
        public string FullNameVillain1() { return firstName + " " + lastName; }
        public double HeightWeightVillain1() { return (height + weight); }
        public string AntagonistOfVillain1() { return (antagonist); }
    }
}
