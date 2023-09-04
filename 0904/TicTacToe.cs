using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0904
{
    internal class TicTacToe
    {
        static void Main(string[] args)
        {
            char[] board = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };

            Board.DrawBoard(board);
            Console.SetCursorPosition(2, 1);

            while (true)
            {
                Player.UseTurn(board);
            }
        }

    }
}