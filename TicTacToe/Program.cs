using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static string[,] board = new string[,]
        {
           {" ", " ", " "},
           {" ", " ", " "},
           {" ", " ", " "}
        };

        static string currentPlayer = "X";


        static void Main(string[] args)
        {
            printBoard();
            getInput();
        }

        #region Input
        public static void getInput()
        {
            
            do
            {
                Console.WriteLine("Player " + currentPlayer);
                Console.WriteLine("Input a row and press enter: ");
                Console.ReadLine();
                int row = int.Parse(Console.ReadLine());
                Console.WriteLine("You typed " + row);
                Console.WriteLine("Input a column and press enter: ");
                int column = int.Parse(Console.ReadLine());
                Console.WriteLine("You typed " + column);
                Console.ReadLine();
                placeMark(row, column);

            } while (!hasWon() && !isTie());

            Console.ReadLine();
        }
        #endregion

        #region placemark
        static void placeMark(int row, int col)
        {
            int rowIndx = (row - 1);
            int colIndx = (col - 1);
          
           board[rowIndx, colIndx] = currentPlayer;
           Console.WriteLine(board);
            
            printBoard();
        }
        #endregion

        #region winning methods
        static bool isHorizontalWin()
        {

            for(int i = 0; i <3; i++)
            {
                if (board[i, 0] == currentPlayer && (board[i, 0] == board[i, 1] && board[i, 0] == board[i, 2]))
                {
                    return true;
                }
            }

                return false;
            
        }
        
        static bool isVerticalWin()
        {
          

            for(int j = 0; j<3; j++)
            {
                if(board[0, j] == currentPlayer && (board[0, j] == board[1, j] && board[0, j] == board[2, j]))
                {
                    return true;
                }
            }

           
                return false;
            
        }

        static bool isDiagonalWin()
        {
            
            if(board[1, 1] == currentPlayer && ((board[0,0] == board[1,1] && board[0,0] == board[0,2]) || (board[2,0] == board[1,1] && board[2,0] == board[0,2])))
            {
                return true;
            }
            
                return false;
            
        }
        

        static bool isTie()
        {
            //if spaces are empty return false--it's not a tie
            return false;
            
        }
        #endregion

        #region win? method
        static bool hasWon()
        {
            if(isHorizontalWin() || isVerticalWin() || isDiagonalWin())
            {
                return true;
            };


            return false;
        }
        #endregion

        #region Print the game Board
        static void printBoard()
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("-------");

                for (int i = 0; i < 3; i++)
                {
                    Console.Write("|" + board[i, j]);
                }
                Console.WriteLine("|");
            }
            Console.WriteLine("-------");
            Console.Read();
        }

    }
}
#endregion 