using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace HeroSelector
{
    partial class Program
    {
        public static void Format()
        {
            int sum = 2500;
            WriteLine("Currency String: " + sum.ToString("C"));//format to currency string       
            Write(String.Format("\nGeneral:\t {0:G}", sum)) ;//format sum as general
            Write(String.Format("\nFixed Point:\t {0:F}", sum));//fixed point
            Write(String.Format("\nCurrency:\t {0:C}", sum));//format sum as currency

            sum /= 1000;
            Write(String.Format("\nPercentage:\t {0:P}", sum));
            Write(String.Format("\nZero Padded:\t {0:00.0000} \n", sum));

            string data = "Mike, McGrath, Author";//spliiting up CSV list
            string[] items = data.Split(',');//split by the comma
            foreach(string item in items)
            {
                Write(String.Format("\n* {0}", item));
            }
        }
        public static void DateFormat()
        {
            DateTime now = DateTime.Now;
            Write("Current Date and Time: " + now);
            Write("\nDay Name: " + now.DayOfWeek);
            Write("\nDate Only: " + now.ToShortDateString());
            Write("\nTime Only:" + now.ToShortTimeString());

            now = now.AddYears(4);
            Write("\n\nFuture Date: " + now);

            DateTime dt = new DateTime(2017, 7, 4, 8, 15, 30);
            Write("\n\nSet Date And Time: {0:f}", dt);

            Write("\nDay Name: {0:dddd}", dt);
            Write("\nLong Date: {0:D}", dt);
            Write("\nLong Time: {0:T}", dt);
        }
    }
}
