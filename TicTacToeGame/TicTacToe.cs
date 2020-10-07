using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGame
{
    class TicTacToe
    {
        //constants
        public const int HEAD = 1;
        public const int TAIL = 0;
        //variables
        public static char[] board = new char[10];
        public static char letter;
        public enum Player { USER, COMPUTER };
        public char[] CreateBoard()
        {
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
                Console.WriteLine("------------------------");
                Console.WriteLine("Player's choice: " + playerLetter);
                Console.WriteLine("computer's choice: " + computerLetter);
                Console.WriteLine("------------------------");
            }
            else
            {
                Console.WriteLine("\nChoose a valid letter! ");
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
            int index = Int32.Parse(Console.ReadLine());
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
        public Player Toss()
        {
            Random random = new Random();
            int toss = random.Next(0, 2);
            return (toss == HEAD) ? Player.USER : Player.COMPUTER;
        }
    }
}




