﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowersOfHanoi
{
    class Program
    {
        //create dictionary with keys A, B, and C and int stacks as values
        private static Dictionary<string, Stack<int>> towerBoard = new Dictionary<string, Stack<int>>();

        //Track number of Moves it Takes Player to Win
        private static int moves = 0;
        static void Main(string[] args)
        {

            startingStacks();
            printBoard();
            gameLoop();
            Console.Read();    

        }

        #region Game Loop
        public static void gameLoop()
        {   //Intro Game
            Console.WriteLine("Welcome to Towers of Hanoi!");
            Console.WriteLine("Here's the goal: Get the blocks from the A tower to the C tower in the same order.");
            Console.WriteLine("You can't place larger blocks on top of smaller blocks. Try to do it in as few moves as possible");
            Console.WriteLine("And begin!!!");
            
            do
            {
                move();
                checkWin();
                printBoard();

            } while (!checkWin());
        }
        #endregion 

        #region Stacks
        private static void startingStacks()
        {   //Create stacks for each Tower
            Stack<int> aStack = new Stack<int>();
            Stack<int> bStack = new Stack<int>();
            Stack<int> cStack = new Stack<int>();

            //Add initial block values to aStack
            aStack.Push(4);
            aStack.Push(3);
            aStack.Push(2);
            aStack.Push(1);

            //Add stacks to Dictionary
            towerBoard.Add("A", aStack);
            towerBoard.Add("B", bStack);
            towerBoard.Add("C", cStack);
        }
        #endregion

        #region print
        private static void printBoard()
        {
            
            //Print out the tower board.
            //Take each key, value pair of dictionary and
            //convert the stacks to a list,
            //push that list to a temporary stack
            //print out the temporary stack so the values show from biggest to smallest
            foreach (KeyValuePair<string, Stack<int>> kvp in towerBoard)
            {
                string blocks = "";
                Stack<int> TempStack = new Stack<int>();
                List<int> tempList = kvp.Value.ToList();

                for(int i=0; i<tempList.Count; i++)
                {
                    TempStack.Push(tempList[i]);
                    
                }

                foreach(int block in TempStack)
                {
                    blocks += block.ToString() + " ";
                }


                Console.WriteLine(kvp.Key + ": " + blocks);
            }
        }
        #endregion

        #region Move Input
        private static void move()
        {   
            //Only need to know the tower to take from and the tower to place in.
            Console.Write("Select a Tower To Move From: ");
            string fromTower = Console.ReadLine().ToUpper();

            Console.Write("Select a Tower to Move to: ");
            string toTower = Console.ReadLine().ToUpper();
            
            //Pass input to validation function
            if(!checkMove(fromTower, toTower))
            {
                Console.WriteLine("That is an invalid move. \nTry Again.");
            }
            else
            {  
               //remove value from first tower and add to new tower
               towerBoard[toTower].Push(towerBoard[fromTower].Pop());
                moves++;
            }
        }
        #endregion

        #region Check Move
        private static bool checkMove(string fromTower, string toTower)
        {
            int fromValue = 0;
            int toValue = 0;

            //Check if user selected a tower to move from that has no values
            if(towerBoard[fromTower].Count == 0)
            {
                return false;
            }

            //Check that the tower to move to has at least 1 value
            //so peek() doesn't throw an empty stack exception.
            if (towerBoard[toTower].Count > 0)
            {
                fromValue = towerBoard[fromTower].Peek();
                toValue = towerBoard[toTower].Peek();
            }

            //Check if the value being moved is bigger
            //than the value it's to be placed on top of
            if(fromValue > toValue)
            {
                return false;
            }

            return true;
        }
        #endregion 

        #region Win?
        private static bool checkWin()
        {
            foreach (KeyValuePair<string, Stack<int>> kvp in towerBoard)
            {
                //Make sure that the stack with the correct order
                //and amount of values is not the first stack
                //If it's not then return Win.
                if (kvp.Key != "A" && kvp.Value.Count == 4)
                {      
                    Console.WriteLine("You Won!!!");
                    Console.WriteLine($"It took you {moves} moves.");
                    return true;
                }
            }
            return false;
        }
        #endregion

    }
}
