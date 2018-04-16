using System;
using System.Collections.Generic;
using System.Text;

namespace HeroSelector
{
    public partial class Coliseum
    {
        private string shape;
        private int height;
        private int circumference;

        public Coliseum(string shape, int height, int circumference)
        {
            this.shape = shape;
            this.height = height;
            this.circumference = circumference;
        }
    }
}
