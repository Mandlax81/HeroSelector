using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace HeroSelector
{
    partial class Program
    {
        public static void Report(int pos, string sub)
        {
            if (pos != -1)
            {
                WriteLine("'" + sub + "' Found At " + pos);
            }
            else
            {
                WriteLine("'" + sub + "' Not Found");
            }
        }
        public static void HeroSearchEngine ()
        {            
            string heroList = "Spartacus,Eleanor,Tousaint";//List of content in CSV format
            string[] indivHeroes = heroList.Split(',');//split by the comma
            var i = 0;
            foreach (string hero in indivHeroes)//reformat in list
            {
                Write(("\n" + (i + 1) + ". ") + (String.Format("{0}", hero)));
                i++;
            }
            WriteLine("\nWhich hero are you searching for?: ");
            string searchRequest = ReadLine();//gets string of content
            char[] arrayHero = new char[searchRequest.Length];//creates char array equal to whatever the searchRequest string is
            searchRequest.CopyTo(0, arrayHero, 0, searchRequest.Length);//searchRequest is string to be copied.
            //copying this string...from start of string...to arrayHero, and number of characters to copy 
            int posRequest = heroList.IndexOf(searchRequest);//takes the whole hero list, and reports the index/place of the search Request
            if (posRequest != -1)//if position-index does not equal -1, which is wouldn't if matching content was found, do the following...
            {
                WriteLine("'" + searchRequest + "' Found At " + posRequest);
            }
            else//...just write the search request
            {
                WriteLine("'" + searchRequest + "' Not Found");
            }
            ReadKey();
        }
    }
}
