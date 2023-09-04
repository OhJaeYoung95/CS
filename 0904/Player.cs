using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0904
{
    enum PlayerTurn
    {
        O,
        X
    };
    internal class Player
    {
        static PlayerTurn playerTurn = PlayerTurn.O;
        static int placeCursorX = 2;
        static int placeCursorY = 1;

        public static void UseTurn(char[] board)
        {
            Choice(board);

        }

        public static void Choice(char[] board)
        {
            ConsoleKeyInfo keyInfo;
            keyInfo = Console.ReadKey(true);

            // 가로는 4 씩 증가
            // 세로는 2 씩 증가
            switch(keyInfo.Key)
            {
                case ConsoleKey.W:
                    placeCursorY -= 2;
                    Console.SetCursorPosition(placeCursorX, placeCursorY); 
                    break;
                case ConsoleKey.A:
                    placeCursorX -= 4;
                    Console.SetCursorPosition(placeCursorX, placeCursorY);
                    break;
                case ConsoleKey.S:
                    placeCursorY += 2;
                    Console.SetCursorPosition(placeCursorX , placeCursorY);
                    break;
                case ConsoleKey.D:
                    placeCursorX += 4;
                    Console.SetCursorPosition(placeCursorX, placeCursorY);
                    break;
                case ConsoleKey.Enter:
                    if(playerTurn == PlayerTurn.O)
                        board[(placeCursorY / 2) * 3 + placeCursorX / 4] = 'O';
                    else
                        board[(placeCursorY / 2) * 3 + placeCursorX / 4] = 'X';
                    playerTurn += 1;
                    playerTurn = (PlayerTurn)((int)playerTurn % 2);

                    Board.DrawBoard(board);
                    Console.SetCursorPosition(placeCursorX, placeCursorY);
                    break;
            }
        }
    }
}
