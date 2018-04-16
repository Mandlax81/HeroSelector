using System;
using System.Collections.Generic;
using System.Text;

namespace HeroSelector
{
    partial class Program
    {
        static double computeArea(double width)
        {
            double radius = width / 2;
            return ((radius * radius) * 3.141593);
        }
        static double computeArea(double width, double height)
        {
            return (width * height);
        }
        static double computeArea(double width, double height, char letter)
        {
            return ((width / 2) * height);
        }
    }
}
