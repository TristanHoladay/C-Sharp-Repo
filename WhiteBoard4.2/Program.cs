using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteBoard4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please give 5 numbers separated by commas: ");

            string[] Array = Console.ReadLine().Split(',', ' ');

            for(int i=Array.Length-1; i>=0; i--)
            {
                Console.WriteLine(Array[i]);
            }

            Console.Read(); 



        }
    }
}
