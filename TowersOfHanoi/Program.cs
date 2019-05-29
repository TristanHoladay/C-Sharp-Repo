using System;
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
        static void Main(string[] args)
        {

            startingStacks();
            printBoard();
            gameLoop();
            Console.Read();    

        }

        #region Game Loop
        public static void gameLoop()
        {
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
        {
            Stack<int> aStack = new Stack<int>();
            Stack<int> bStack = new Stack<int>();
            Stack<int> cStack = new Stack<int>();

            //Add initial block values to aStack
            aStack.Push(1);
            aStack.Push(2);
            aStack.Push(3);
            aStack.Push(4);

            //Add stacks to Dictionary
            towerBoard.Add("A", aStack);
            towerBoard.Add("B", bStack);
            towerBoard.Add("C", cStack);
        }
        #endregion

        #region print
        private static void printBoard()
        {
            //print out the tower board
            foreach (KeyValuePair<string, Stack<int>> kvp in towerBoard)
            {
                string blocks = "";

                foreach (int block in kvp.Value)
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
            Console.WriteLine("Select a Tower To Move From: ");
            string fromTower = Console.ReadLine();

            Console.WriteLine("Select a Block To Move: ");
            int moveBlock = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Select a Tower to Move Block to: ");
            string toTower = Console.ReadLine();

            if(!checkMove(fromTower, toTower, moveBlock))
            {
                Console.WriteLine("That is an invalid move. \nYou cannot place a larger block ontop of a smaller block.");
            }
        }
        #endregion

        #region Check Move
        private static bool checkMove(string fromTower, string toTower, int moveBlock)
        {
            Stack<int> previousStack = towerBoard[fromTower.ToUpper()];
            Stack<int> newStack = towerBoard[toTower.ToUpper()];
                
            newStack.Push(moveBlock);

            int[] blocksArray = newStack.ToArray();

            if (blocksArray.Length > 1)
            {
                for (int i = 1; i < blocksArray.Length; i++)
                {
                    if (blocksArray[i] > blocksArray[i - 1])
                    {
                        newStack.Pop();
                        return false;
                    }
                }
            }

            previousStack.Pop();
            return true;
        }
        #endregion 

        #region Win?
        private static bool checkWin()
        {
            foreach(KeyValuePair<string, Stack<int>> kvp in towerBoard)
            {
                if (kvp.Key != "A")
                {
                    int[] winArray = towerBoard[kvp.Key].ToArray();
                    int lastIndex = winArray.Length - 1;
                    if (winArray[0] == 4 && lastIndex == 1)
                    {
                        Console.WriteLine("You Won!!!");
                        return true;
                    }
                }
            return false;
        }
        #endregion

    }
}
