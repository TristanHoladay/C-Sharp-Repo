
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Methods
{
    class Program
    {

        static void Main(string[] args)
        {
            //Hello Method
            //hello();

            //Addition Method
            //addition();

            //Catdog Method
            //catdog();

            //Even or Odd Method
            //oddEvent();

            //Ft to Inches Method
            //inches();

            //Echo Method
            //echo();

            //KillGrams Method
            //killgrams();

            //Date Method
            //date();

            //Age Method
            //age();

            //Guess Method
            //guess();
        }

        public static void hello()
        {
            Console.WriteLine("Hi! What is your name?");
            string Name = Console.ReadLine();
            Console.WriteLine("Goodbye" + " " + Name);
            Console.Read();
        }

        public static void addition()
        {
            Console.WriteLine("Please enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine("The sum is " + sum);
            Console.Read();
        }

        public static void catdog()
        {
            Console.WriteLine("What do you prefer, cats or dogs?");
            string animal = Console.ReadLine();

            if (animal == "cats")
            {
                Console.WriteLine("Meow!");
            }
            else
            {
                Console.WriteLine("Woof!");
            }

            Console.Read();
        }

        public static void oddEvent()
        {
            Console.WriteLine("Please input a number: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Your number is even!");
            }
            else
            {
                Console.WriteLine("Your number is odd!");
            }

            Console.Read();
        }

        public static void inches()
        {
            Console.WriteLine("Please input a height in feet: ");
            int ft = int.Parse(Console.ReadLine());
            int inches = ft * 12;

            Console.WriteLine("That equals " + inches + " inches!");
            Console.Read();
        }

        public static void echo()
        {
            Console.WriteLine("Please type a word: ");
            string word = Console.ReadLine();
            string upper = word.ToUpper();
            string lower = word.ToLower();
            Console.WriteLine(upper + " " + lower + " " + lower);
            Console.Read();
        }

        public static void killgrams()
        {
            Console.WriteLine("Please input a weight in pounds: ");
            int pounds = int.Parse(Console.ReadLine());
            decimal kilograms = pounds * 0.45359237M;
            Console.WriteLine("That is " + kilograms + " kilograms");
            Console.Read();
        }

        public static void date()
        {
            DateTime date = DateTime.Now;
            Console.WriteLine(date);
            Console.Read();
        }

        public static void age()
        {
            Console.WriteLine("What is your birth year?");
            int BirthYear = int.Parse(Console.ReadLine());
            DateTime date = DateTime.Now;
            int year = date.Year;

            int age = year - BirthYear;

            Console.WriteLine("You are " + age + " years old!");

            Console.Read();
        }

        public static void guess()
        {
            string word = "csharp";
            Console.WriteLine("Guess a word. Input your guess: ");
            string guess = Console.ReadLine();

            if (word == guess.ToLower())
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Wrong!");
            }
            Console.Read();

        }
    }
}
