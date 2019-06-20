using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public enum Color { White, Black }
    public struct Position
    {
        public int Row { get; private set; }
        public int Column { get; private set; }
        public Position(int row, int col)
        {
            this.Row = row;
            this.Column = col;
        }
    }
    public class Checker
    {
        public string Symbol { get; private set; }
        public Color Team { get; private set; }
        public Position Position { get; set; }

        public Checker(Color team, int row, int col)
        {
            if(team == Color.White)
            {
                Symbol = "25CB";
                Position = new Position(row, col);
            }
            
            if(team == Color.Black)
            {
                Symbol = "25CF";
                Position = new Position(row, col);
            }
        }
    }

    public class Board
    {
        public List<Checker> checkers;
        public Board()
        {
            checkers = new List<Checker>();
            for(int r=0; r<3; r++)
            {
                for(int i=0; i<8; i+=2)
                {
                    Checker c = new Checker(Color.White, r, (r + 1) % 2 + i);
                    checkers.Add(c);
                }

                for (int i = 0; i < 8; i += 2)
                {
                    Checker c = new Checker(Color.Black, 5 + r, (r + 1) % 2 + i);
                    checkers.Add(c);
                }
            }
        }

        public Checker GetChecker(Position source)
        {
            foreach (Checker c in checkers)
            {
                if (c.Position.Row == source.Row && c.Position.Column == source.Column)
                {
                    return c;
                }
            }

            return null;
        }

        public void MoveChecker(Checker checker, Position destination)
        {
            Checker c = new Checker(checker.Team, destination.Row, destination.Column);
            checkers.Add(c);
            RemoveChecker(checker);
        }

        public void RemoveChecker(Checker checker)
        {
            if(checker != null)
            {
                checkers.Remove(checker);
            }
        }
    }

    public class Game
    {
        private Board board;

        public Game()
        {
            this.board = new Board();
        }

        private bool CheckForWin()
        {
            return false; //use LINQ
        }

        #region Legal Move?
        public bool IsLegalMove(Color player, Position source, Position destination)
        {
            //Make sure that source and destination points are on NOT outside the game board
            if (source.Row < 0 || source.Row > 7 || source.Column < 0 || source.Column > 7
                || destination.Row < 0 || destination.Row > 7 || destination.Column < 0 || destination.Column > 7)
            {
                return false;
            }

            //Get difference between the specified rows and columns
            //check if the absolute values of the distances yield a slope
            // of 1
            int rowDistance = Math.Abs(destination.Row - source.Row);
            int colDistance = Math.Abs(destination.Column - source.Column);

            if (colDistance == 0 || rowDistance == 0) return false;
            if (rowDistance / colDistance != 1) return false;

            //check if distance to destination is greater than 2
            //don't need to check col because previous line already 
            //tells us if the two are equivalent
            if (rowDistance > 2) return false;

            //no checker at source then false
            //if checker is in destination already then false
            Checker c = board.GetChecker(source);
            if (c == null) return false;
            c = board.GetChecker(destination);
            if (c != null) return false;

            if (rowDistance == 2)
            {
                if (IsCapture(player, source, destination))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
            
        }
        #endregion

        #region IsCapture
        public bool IsCapture(Color player, Position source, Position destination)
        {
            int row_mid = (destination.Row + source.Row) / 2;
            int col_mid = (destination.Column + source.Column) / 2;
            Position p = new Position(row_mid, col_mid);
            Checker c = board.GetChecker(p);
            //if mid point is empty then can't move two spaces
            if (c == null)
            {
                return false;
            }
            else
            {
                if (c.Team == player)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        #endregion

        public Checker GetCaptureChecker(Color player, Position source, Position destination)
        {
            if (IsCapture(player, source, destination))
            {
                int row_mid = (source.Row + destination.Row) / 2;
                int col_mid = (source.Column + destination.Column) / 2;
                Position p = new Position(row_mid, col_mid);
                Checker c = board.GetChecker(p);
                return c;
            }
            else
            {
                return null;
            }
        }
        
        public void drawBoard()
        {
            String[][] grid = new String[8][];
            for(int r=0; r<8; r++)
            {
                grid[r] = new string[8];
                for(int c=0; c<8; c++)
                {
                    grid[r][c] = " ";
                }
            }
            foreach(Checker c in board.checkers)
            {
                grid[c.Position.Row][c.Position.Column] = c.Symbol;
            }
        }

    }

}
