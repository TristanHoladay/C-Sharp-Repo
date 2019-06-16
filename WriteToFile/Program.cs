using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteToFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a text file
            string fileName = @"C:\Users\Tristan\C#_File.txt";

            try
            {
                //Check if File already exists. If yes, delete it.
                if(File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                //Create file to write to
                using (StreamWriter sw = File.CreateText(fileName))
                {
                    //Add some text to file
                    string Title = "My Text File Test,";
                    string Author = "by Tristan H.";
                    sw.WriteLine(Title);
                    sw.WriteLine(Author);
                }

                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
            
        }
    }
}
