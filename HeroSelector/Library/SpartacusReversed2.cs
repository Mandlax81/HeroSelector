using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeroSelector
{
    static class StringExtensions
    {
        public static string Reverse(this string input)
        {
            return new string(input.ToCharArray().Reverse().ToArray());
        }
    }
}
