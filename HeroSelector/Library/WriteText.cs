using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using static System.Console;

namespace HeroSelector
{
    partial class Program
    {
        public static void WriteText()
        {
            string path = "C:\\Users\\Benjamin\\Desktop\\poem.txt";
            string poem = "\r\n\tI never saw a man who looked";
            poem += "\r\n\tWith such a wistful eye";
            poem += "\r\n\tUpon that little tent of blue";
            poem += "\r\n\tWhich prisoners call the sky";

            if (File.Exists(path))
            {
                WriteLine("File Aleady Exists: " + path);
            }
            else
            {
                try
                {
                    File.WriteAllText(path, poem);//writes poem to the path file
                    WriteLine("File Written: " + path);

                }
                catch(Exception error)
                {
                    WriteLine(error.Message);
                }
            }
        }
        public static void AppendText()
        {
            string path = "C:\\Users\\Benjamin\\Desktop\\oscar.txt";
            string[] poem = new string[]//creates a string of content
            {
                "\tIn Debtors' Yard the stones are hard", "\tAnd the dripping wall is high"
            };
            string attrib = "\r\n\tThe Ballad of Reading Gaol";//content to be appended on
            attrib += "(Oscar Wilde 1898)";

            if (File.Exists(path))
            {
                File.AppendAllText(path, attrib);
                WriteLine("Appended to File: " + path);
            }
            else
            {
                try
                {
                    File.WriteAllLines(path, poem);
                    WriteLine("File Written: " + path);
                }
                catch(Exception error)
                {
                    WriteLine(error.Message);
                }
            }            
        }
        public static void ReadText()//this is a better version of the .CSV manipulator
        {
            string path = "C:\\Users\\Benjamin\\Desktop\\word.txt";
            if (File.Exists(path))
            {
                try
                {
                    string text = File.ReadAllText(path);//reads all from the text file
                    WriteLine("File Read: " + path + "\n");//writes out read path
                    WriteLine(text + "\n");//prints out read text

                    string[] lines = File.ReadAllLines(path);//read all lines and put inside array
                    int num = 1;
                    foreach(string line in lines)
                    {
                        WriteLine(num + " : " + line);
                        num++;
                    }
                }
                catch(Exception error)
                {
                    WriteLine(error.Message);
                }
            }
            else
            {
                WriteLine("File Not Found: " + path);
            }
        }
        public static void WriteStream()//using FileStream function
        {
            string path = "C:\\Users\\Benjamin\\Desktop\\robert.txt";
            string[] poem = new string[]//creates a string of content
            {
                "\tThis truth finds hones Tam o' Shanter",
                "\tAs he from Ayr one night did canter",
                "\tOld Ayr, which never a town surpasses",
                "\tFor honest men and bonnie lasses."
            };
            string attrib = "\r\n\tTam O'Shanter (Robert Burns 1790)";
            try
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    foreach(string line in poem)
                    {
                        writer.WriteLine(line);
                    }
                }
                using(StreamWriter writer = new StreamWriter(path, true))
                {
                    writer.WriteLine(attrib);
                    WriteLine("File Written: " + path);
                }                
            }
            catch(Exception error)
            {
                WriteLine(error.Message);
            }
        }
        public static void ReadStream()
        {
            string path = "C:\\Users\\Benjamin\\Desktop\\TopFive.csv";
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while((line = reader.ReadLine()) != null)//there has to be a path to read
                    {
                        if (line.IndexOf("Rank") != -1) line = line.ToUpper();//makes the top line of Rank upper case, also other top headings
                        if (line.IndexOf("Sia") != -1) line += "ft.Sean Paul";//add ft. Sean Paul to Sia if it's there.
                        string[] sub = line.Split(',');//creates an array of content, split by comma
                        line = String.Format("{0,-30}{1, -20}{2, -30}", sub[1], sub[2], sub[0]);
                        WriteLine(line);
                    }
                }

            }
            catch(Exception error)
            {
                WriteLine(error.Message);
            }

        }



    }
}
