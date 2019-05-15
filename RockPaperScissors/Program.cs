using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks User for input
            Console.WriteLine("Let's play Rock Paper Scissors. \nStreet rules--Best 2 Out of 3 Wins! \nReady?... Rock, Paper, Scissors: ");
            string input = Console.ReadLine();
            Console.WriteLine(RockPaperScissors(input));
            Console.Read();
        }

        public static string RockPaperScissors(string word)
        {
            string userHand = word.ToLower();
            //int? userScore = null;
            //int? computerScore = null;
            string computerHand = String.Empty;
            //int handPlays = 0;

            //generates random number
            Random generator = new Random();
            int randNumber = generator.Next(0, 3);

            //while(handPlays <= 3 && (userScore != 2 || computerScore != 2))
           // {
                //associates number with choice
                //will revise code to use nested switch case
                switch (randNumber)
                {
                    case 0:
                        computerHand = "rock";
                        break;
                    case 1:
                        computerHand = "paper";
                        break;
                    case 2:
                        computerHand = "scissors";
                        break;
                    default:
                        Console.WriteLine("What....");
                        break;
                }

                if (userHand == computerHand)
                {
                    return "You tied.";
                }
                else if (userHand == "rock" && computerHand == "scissors")
                {
                    return $"{userHand} beats {computerHand}. \nYou Win!";
                }
                else if (userHand == "rock" && computerHand == "paper")
                {
                    return $"{computerHand} beats {userHand}. \nYou Lose!";
                }
                else if (userHand == "paper" && computerHand == "rock")
                {
                    return $"{userHand} beats {computerHand}. \nYou Win!";
                }
                else if (userHand == "paper" && computerHand == "scissors")
                {
                    return $"{computerHand} beats {userHand}. \nYou Lose!";
                }
                else if (userHand == "scissors" && computerHand == "paper")
                {
                    return $"{userHand} beats {computerHand}. \nYou Win!";
                }
                else
                {
                    return $"{computerHand} beats {userHand}. \nYou Lose!";
                }
            //}
        
        }
    }
}
