using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    class Program
    {

        static void Main(string[] args)
        {
            colorPicker();
        }

        //generate randome colors and hold in variable
        static void colorPicker()
        {
            string[] colors = { "Red", "Blue", "Green" };
            Random numbers = new Random();

            int colorIndx1 = numbers.Next(0, 3);
            int colorIndx2 = numbers.Next(0, 3);
            Console.WriteLine(colors[colorIndx1] + " " + colors[colorIndx2]);
            Console.Read();
        }
    }
}



//1. Generate Code

//2. Ask User Input
//3. If not correct answer give hint
//4. call within while loop