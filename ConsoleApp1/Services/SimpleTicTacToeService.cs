using ConsoleApp1.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    internal class SimpleTicTacToeService : ITicTacToeService
    {
        private const int GRID_SIZE = 3;
        private const int NO_OF_PIECES = 5;

        int countX;
        EPiece[,] grid;

        public SimpleTicTacToeService()
        {
            grid = new EPiece[3, 3];
        }

        public bool IsGameOver()
        {
            return countX == NO_OF_PIECES;
        }

        public bool IsValidMove(EPiece piece, int row, int col)
        {
            //Return true if the cell is empty.
            return grid[row, col] == EPiece.NA;
        }

        public bool IsWinner(EPiece piece)
        {
            bool result = false;

            for (int col = 0; col < GRID_SIZE; col++)
            {
                if (result)
                    break;
                result = ColCheck(piece, col);

                if (result)
                    break;
                result = RowCheck(piece, col);
            }

            if (!result)
                result = LeftCrossCheck(piece);
            if (!result)
                result = RightCrossCheck(piece);

            return result;
        }

        private bool RowCheck(EPiece piece, int row)
        {
            //Check for the row.
            if (grid[row, 0] == piece && grid[row, 1] == piece && grid[row, 2] == piece)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ColCheck(EPiece piece, int row)
        {
            bool result = true;

            for (int i = 0; i < GRID_SIZE; i++)
            {
                if (!result)
                    break;
                result = grid[row, i] == piece;
            }

            return result;
        }

        private bool LeftCrossCheck(EPiece piece)
        {
            return grid[0, 0] == piece
                && grid[1, 1] == piece
                && grid[2, 2] == piece;
        }

        private bool RightCrossCheck(EPiece piece)
        {
            return grid[0, 2] == piece
                && grid[1, 1] == piece
                && grid[2, 0] == piece;
        }

        public void Move(EPiece piece, int row, int col)
        {
            grid[row, col] = piece;

            if (piece == EPiece.X)
                countX++;
        }

        public void Print()
        {
            for (int i = 0; i < GRID_SIZE; i++)
            {
                for (int j = 0; j < GRID_SIZE; j++)
                {
                    Console.Write(GetPieceName(grid[i, j]) + " ");
                }
                Console.WriteLine();
            }
        }

        private string GetPieceName(EPiece piece)
        {
            string result;
            switch (piece)
            {
                case EPiece.NA:
                    result = "-";
                    break;
                case EPiece.X:
                    result = EPiece.X.ToString();
                    break;
                case EPiece.O:
                    result = EPiece.O.ToString();
                    break;
                default:
                    result = "-";
                    break;
            }
            return result;
        }
    }
}
