using System;

namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new TicTacToe();
            char[] board = t.CreateBoard();
            char letter = t.ChooseLetter();
            t.Toss();
            t.Play();
            Console.WriteLine("\nCheck if won : " + t.CheckWinner(letter));
        }
    }
}
