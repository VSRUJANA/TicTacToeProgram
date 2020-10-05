using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGame
{
    class TicTacToe
    {
        public static char[] board = new char[10];
        static int index = 0;
        static int i = 0;
        public static char letter;
        public char[] CreateBoard()
        {
            //char[] board = new char[10];
            for (int i = 1; i < 10; i++)
            {
                board[i] = ' ';
            }
            return board;
        }
        public char ChooseLetter()
        {
            Console.WriteLine("Choose a letter - X or O");
            char playerLetter = char.ToUpper(Console.ReadLine()[0]);
            if (playerLetter == 'O' || playerLetter == 'X')
            {
                char computerLetter = (playerLetter == 'O') ? 'X' : 'O';
                Console.WriteLine("\nPlayer's choice: " + playerLetter);
                Console.WriteLine("computer's choice: " + computerLetter);
            }
            else
            {
                Console.WriteLine("\nChoose a valid letter!");
                ChooseLetter();
            }
            letter = playerLetter;
            return letter;
        }
        public void ShowBoard()
        {
            Console.Write("\n| ");
            for (int i = 1; i < 10; i++)
            {
                Console.Write(board[i] + " | ");
                if (i % 3 == 0 && i != 9)
                {
                    Console.WriteLine("\n-------------");
                    Console.Write("| ");
                }
            }
        }
        public void MakeMove()
        {
            Console.WriteLine(" \nChoose an index from 1 to 9 ");
            index = Int32.Parse(Console.ReadLine());
            if (index > 0 && index <= 9)
            {
                if (board[index] != ' ')
                {
                    Console.WriteLine("The index chosen is already occupied! Choose another index..");
                    MakeMove();
                }
                else
                {
                    board[index] = letter;
                }
            }
            else
            {
                Console.WriteLine("The index chosen is invalid! choose a number between 1 to 9");
                MakeMove();
            }
        }
    }
}




