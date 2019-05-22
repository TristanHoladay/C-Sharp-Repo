using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    class Program
    {

        static string[] secret = new string[2];
        static string[] colorArray = new string[] { "red", "green", "blue" };
        static bool gameOver = false;
        

        static void Main(string[] args)
        {
            createSecret();
            userGuess();
            Console.Read();
        }

        //Generate Random Secret Values
        public static void createSecret()
        {
            for (int i = 0; i < 2; i++)
            {
                Random num = new Random();
                secret[i] = colorArray[num.Next(0, 3)];
            }
        }

        //Get Guess from User and Compare to Secret
        public static void userGuess()
        {

            Console.WriteLine("I'm thinking of 2 colors. Try and guess.");
            while (gameOver == false)
            {

                Console.WriteLine("Enter your guess: ");
                string[] guess = Console.ReadLine().Split(' ');
                string guess0 = guess[0].ToLower();
                string guess1 = guess[1].ToLower();


                if (guess.Length > 2)
                {
                   Console.WriteLine("That's too many colors. \nTry again: ");
                   guess = Console.ReadLine().Split(' ');
                }

                //Check if Guess is Correct
                if(secret[0] == guess0 && secret[1] == guess1)
                {
                    Console.WriteLine("That's Correct! You Won!");
                    gameOver = true;
                }
                else
                {
                    int colorHintCount = 0;
                    int positionHintCount = 0;

                    //Any Colors Match
                    for(int i=0; i<2; i++)
                    {
                        if (secret[i] == guess[i].ToLower())
                        {
                            colorHintCount++;
                        }
                    }

                    //Any Positions Match
                    for(int i = 0; i < 2; i++)
                    {
                        if (secret[i] == guess[i].ToLower())
                        {
                            positionHintCount++;
                        }
                    }

                    Console.WriteLine(colorHintCount + "-" + positionHintCount);
                }
            }
        }
    }
}
