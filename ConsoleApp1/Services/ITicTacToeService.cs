using ConsoleApp1.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    /// <summary>
    /// Approach:
    /// Input Player names.
    /// Print the board
    /// 
    /// X makes the first move: Take first input. In Row Column format.
    /// 
    /// Check if the input is exit
    /// 
    /// Check if the move is valid.
    /// Make the move
    /// Print the board
    /// Check if the player won
    /// Check if game over - Keep count 
    /// 
    /// 
    /// </summary>
    internal interface ITicTacToeService
    {
        void Print();

        //void SetPlayer(EPiece piece, string name);

        void Move(EPiece piece, int row, int col);

        bool IsValidMove(EPiece piece, int row, int col);

        bool IsWinner(EPiece piece);
        
        bool IsGameOver();
    }
}
