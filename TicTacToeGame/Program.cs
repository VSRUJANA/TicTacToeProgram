using System;

namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTacToe Game !");
            var t = new TicTacToe();
            char[] board= t.CreateBoard();
        }
    }
}
