using System;

namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new TicTacToe();
            char[] board = t.CreateBoard();
            t.ChooseLetter();
            t.ShowBoard();
        }
    }
}
