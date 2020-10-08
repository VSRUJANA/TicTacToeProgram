using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace TicTacToeGame
{
    class TicTacToe
    {
        //constants
        public const int HEAD = 1;
        public const int TAIL = 0;
        public static int toss;
        //variables
        public static char[] board = new char[10];
        public static char letter;
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
                Console.WriteLine("Player's choice   : " + playerLetter);
                Console.WriteLine("computer's choice : " + computerLetter);
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
        public int Toss()
        {
            Random random = new Random();
            toss = random.Next(0, 2);
            string s = (toss == 1) ? "USER" : "COMPUTER";
            Console.WriteLine(s + " won the toss and will start the game");
            return (toss == HEAD) ? 1 : 0;
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
        public void ComputerMove()
        {
            Random random = new Random();
            int index = random.Next(1, 10);
            char computerLetter = (letter == 'X') ? 'O' : 'X';
            if (board[index] != ' ')
            {
                ComputerMove();
            }
            else
            {
                board[index] = computerLetter;
            }
        }
        public void Play()
        {
            if (toss == 1)
            {
                MakeMove();
                ShowBoard();
            }
            else
            {
                ComputerMove();
                ShowBoard();
            }
        }
        public bool CheckWinner(char playerLetter)
        {
            return ((board[1] == playerLetter && board[2] == playerLetter && board[3] == playerLetter) ||
                    (board[1] == playerLetter && board[4] == playerLetter && board[7] == playerLetter) ||
                    (board[1] == playerLetter && board[5] == playerLetter && board[9] == playerLetter) ||
                    (board[3] == playerLetter && board[6] == playerLetter && board[9] == playerLetter) ||
                    (board[3] == playerLetter && board[5] == playerLetter && board[7] == playerLetter) ||
                    (board[7] == playerLetter && board[8] == playerLetter && board[9] == playerLetter));
        }
        public bool CheckDraw()
        {
            int temp = 0;
            for (int i = 1; i < 10; i++)
            {
                if (board[i] != ' ')
                    temp++;
            }
            if (temp == 9)
            {
                if (!CheckWinner('X') && !CheckWinner('O'))
                    return true;
            }
            return false;
        }
    }
}




