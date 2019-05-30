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

            //don't need block to move, it's implicit because you can only take off one block
            //don't have to add pop() and push() to check, use peek()
            //push stacks to temp stack to print

            //
            if(!checkMove(fromTower, toTower, moveBlock))
            {
                Console.WriteLine("That is an invalid move. \nYou cannot place a larger block ontop of a smaller block.");
            }
        }
        #endregion

        #region Check Move
        private static bool checkMove(string fromTower, string toTower, int moveBlock)
        {   
            //turning "from" stack into an array
            Stack<int> previousStack = towerBoard[fromTower.ToUpper()];
            int[] prevStackArray = previousStack.ToArray();

            //turning "to" stack into a list
            Stack<int> newStack = towerBoard[toTower.ToUpper()];
            List<int> blocksList = newStack.ToList();

            blocksList.Add(moveBlock);

            //Checks That Last Index is Less than 1 before
            if (blocksList.Count > 1)
            {
                for (int i = 1; i<blocksList.Count; i++)
                {
                    if (blocksList[i] > blocksList[i - 1])
                    {
                        return false;
                    }
                }
                
                    for (int i = 0; i < blocksList.Count - 1; i++)
                    {
                        newStack.Pop();
                    }

                    int lastNSIndex = blocksList.Count - 1;

                    for (int i = lastNSIndex; i >= 0; i--)
                    {
                        newStack.Push(blocksList[i]);
                        return true;
                    }
                
            }

            //Remove All Values in Stack
            int numPS = 1;
            while(numPS <= previousStack.Count)
            {
                previousStack.Pop();
            }

            //So Can Add Back in LIFO Order
            int lastIndex = prevStackArray.Length - 1;

            for(int i=lastIndex; i>=0; i--)
            {
                
                if(prevStackArray[i] != moveBlock)
                {
                    previousStack.Push(prevStackArray[i]);
                }
            }

            newStack.Push(moveBlock);
            return true;
        }
        #endregion 

        #region Win?
        private static bool checkWin()
        {
            foreach (KeyValuePair<string, Stack<int>> kvp in towerBoard)
            {
                if (kvp.Key != "A" && kvp.Value.Count == 4)
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
