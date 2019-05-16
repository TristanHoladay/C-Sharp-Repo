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
            do
            {
                printBoard();
                getInput(); 
            } while (!hasWon() && !isTie());

            Console.ReadLine();
        }

        #region Input
        public static void getInput()
        {
            Console.WriteLine("Player " + currentPlayer);
            Console.WriteLine("Input a row: ");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Input a column: ");
            int column = int.Parse(Console.ReadLine());

            placeMark(row, column);
        }
        #endregion

        #region placemark
        static void placeMark(int row, int col)
        {
            int rowIndx = row - 1;
            int colIndx = col - 1;
          
           board[rowIndx, colIndx] = currentPlayer;
            
            printBoard();
            hasWon();
        }
        #endregion


        static bool isHorizontalWin()
        {
            for(int i = 0; i <3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 0] == board[i, 2])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
        
        static bool isVerticalWin()
        {
            for(int j = 0; j<3; j++)
            {
                if(board[0, j] == board[1, j] && board[0, j] == board[2, j])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        static bool isDiagonalWin()
        {
            for(int i = 0; i<3; i++)
            {

            }
        }

        #region win? method
        static bool hasWon()
        {
            if(isHorizontalWin() || isVerticalWin() || isDiagonalWin())
            {
                return true;
            }
            else if (isTie())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        static bool isTie()
        {
            
        }

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