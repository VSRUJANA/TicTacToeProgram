using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGame
{
    class TicTacToe
    {
        public char[] CreateBoard()
        {
            char[] board = new char[10];
            for (int i = 1; i < 10; i++)
            {
                board[i] = ' ';
            }
            return board;
        }
        public void ChooseLetter()
        {
            Console.WriteLine("Choose a letter - X or O");
            char playerLetter = Console.ReadKey().KeyChar;
            if (playerLetter == 'O' || playerLetter == 'X')
            {
                char computerLetter = (playerLetter == 'O') ? 'X' : 'O';
                Console.WriteLine("\nPlayer's choice: " + playerLetter);
                Console.WriteLine("computer's choice: " + computerLetter);
            }
            else
                Console.WriteLine("\nChoose a valid letter!");
        }

    }
}




