using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        //Create 2 dimensional game board with empty spaces
        static string[,] board = new string[,]
        {
           {" ", " ", " "},
           {" ", " ", " "},
           {" ", " ", " "}
        };

        static string currentPlayer = firstPlayer();

        #region firstPlayer
        //Randomly select X or O for first player
        static string firstPlayer()
        {
            Random num = new Random();
            int determinePlayer = num.Next(0, 2);
            if(determinePlayer == 0)
            {
                return "X";
            }
            else
            {
                return "O";
            }
        }      
        #endregion

        static void Main(string[] args)
        {
            printBoard();
            getInput();
            Console.ReadLine();
        }

        #region Input
        public static void getInput()
        {
            //Ask for user to give row number and column number and pass those numbers to placeMark,
            //while there is not a winner or a tie
            do
            {
                Console.WriteLine("Player " + currentPlayer);
                Console.WriteLine("Input a row and press enter: ");
                int row = int.Parse(Console.ReadLine());
                Console.WriteLine("You typed " + row);
                Console.WriteLine("Input a column and press enter: ");
                int column = int.Parse(Console.ReadLine());
                Console.WriteLine("You typed " + column);
                
                placeMark(row, column);

            } while (!hasWon() && !isTie());

            
        }
        #endregion

        #region placemark
        static void placeMark(int row, int col)
        {
            //subtract 1 from user input to give correct index value
            int rowIndx = (row - 1);
            int colIndx = (col - 1);

            if (board[rowIndx, colIndx] == " ")
            {
                board[rowIndx, colIndx] = currentPlayer;
               

                //Check if currentPlayer has won before it is changed
                hasWon();

                //switch letter per turn
                if (currentPlayer == "X")
                {
                    currentPlayer = "O";
                }
                else
                {
                    currentPlayer = "X";
                }
            }
            else
            {
                //there is a bug that occurs when getInput is called again
                //point for refactoring
                Console.WriteLine("That space is taken try again.");
                getInput();
            }

            printBoard();
        }
        #endregion

        #region winning methods
        static bool isHorizontalWin()
        {
            //check if a space equals an X or O and if the horizontally adjacent spaces have same letter
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
            //check if a space has X or O value and if the vertically adjacent spaces have same value
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
            //check if the middle or central space is X or O
            //then if spaces going diagnolly from top left to bottom right are same value
            //or from bottom left to top right are same value
            if(board[1, 1] == currentPlayer && ((board[0,0] == board[1,1] && board[0,0] == board[0,2]) || (board[2,0] == board[1,1] && board[2,0] == board[0,2])))
            {
                return true;
            }
            
                return false;
        }
        

        static bool isTie()
        {
            bool tie = false;

            //if spaces are empty return false--it's not a tie
            foreach (var a in board)
            {

                if(a == "X" || a == "O")
                {
                    tie = true;
                }
                else
                {
                    return false;
                }       
            }
            
            if(tie)
            {
                return true;
            }

            return false;
        }
        #endregion

        #region win? method
        static bool hasWon()
        {
            //check if any possible winning scenarios are true
            if(isHorizontalWin() || isVerticalWin() || isDiagonalWin())
            {
                Console.WriteLine(currentPlayer + " has won!");
                return true;
            };


            return false;
        }
        #endregion

        #region Print the game Board
        static void printBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("-------");

                for (int j = 0; j < 3; j++)
                {
                    Console.Write("|" + board[i, j]);
                }
                Console.WriteLine("|");
            }
            Console.WriteLine("-------");
            
        }

    }
}
#endregion 





/*
 GameStatus[r1, r2, r3, col1, col2, col3, diag1, diag2]
 row 1: +1 -1 +1 [x, o, x]
 row 2: -1 +1 -1 [o, o, x]
 row 3: +1 +1 +1 [x, x , x]
 you update the row/col depending on what was inputted. 
 */