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
            Console.WriteLine(t.Toss()+ " won the toss and will start the game");
            t.MakeMove();
            t.ShowBoard();
            
        }
    }
}
