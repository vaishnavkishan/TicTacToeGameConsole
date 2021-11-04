using ConsoleApp1.Constants;
using ConsoleApp1.Services;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class TicTacToe
    {
        static Dictionary<EPiece, string> players;

        static void Main(string[] args)
        {
            string player1 = Console.ReadLine();
            string[] player1Inputs = player1.Split(' ');
            EPiece piece1 = player1Inputs[0] == "X" ? EPiece.X : EPiece.O;
            SetPlayer(piece1, player1Inputs[1]);

            string player2 = Console.ReadLine();
            string[] player2Inputs = player2.Split(' ');
            EPiece piece2 = player2Inputs[0] == "X" ? EPiece.X : EPiece.O;
            SetPlayer(piece2, player2Inputs[1]);

            ITicTacToeService game = new SimpleTicTacToeService();

            game.Print();

            string input;
            EPiece currentPlayer = EPiece.X;
            while (true)
            {
                input = Console.ReadLine();

                if (input.Equals("exit", StringComparison.InvariantCultureIgnoreCase))
                {
                    break;
                }

                int row = Convert.ToInt32(input.Split(' ')[0]);
                int col = Convert.ToInt32(input.Split(' ')[1]);

                row--;
                col--;

                if (game.IsValidMove(currentPlayer, row, col))
                {
                    game.Move(currentPlayer, row, col);

                    game.Print();

                    if (game.IsWinner(currentPlayer))
                    {
                        Console.WriteLine($"{players.GetValueOrDefault(currentPlayer)} won the game");
                        break;
                    }
                    if (game.IsGameOver())
                    {
                        Console.WriteLine("Game Over");
                        break;
                    }
                    currentPlayer = currentPlayer == EPiece.X ? EPiece.O : EPiece.X;
                }
                else
                {
                    Console.WriteLine("Invalid Move");
                }
            }


            Console.ReadKey();
        }

        public static void SetPlayer(EPiece piece, string name)
        {
            if (players == null)
                players = new Dictionary<EPiece, string>();
            players.Add(piece, name);
        }
    }
}
