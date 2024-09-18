using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME
{
    internal class GAME
    {
        static void Main(string[] args)
        {
            #region ConsoleCursor

            Console.BufferWidth =  Console.WindowWidth = 60;
            Console.BufferHeight =  Console.WindowHeight = 20;
            Console.SetWindowSize(Console.WindowWidth, Console.WindowHeight);
            Random random = new Random();
            int cursorLeft = random.Next(Console.BufferWidth);
            int cursorTop = random.Next(Console.BufferHeight);
            while (true)
            {
                Console.SetCursorPosition(cursorLeft, cursorTop);
                Console.Write('☻');
                Console.CursorVisible = false;
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.W: cursorTop--; break;
                    case ConsoleKey.S: cursorTop++; break;
                    case ConsoleKey.A: cursorLeft--; break;
                    case ConsoleKey.D: cursorLeft++; break;
                    case ConsoleKey.Enter: return;
                }
                Console.Clear();    
                cursorLeft = Clamp(cursorLeft, 0, Console.WindowWidth - 1);
                cursorTop = Clamp(cursorTop, 0, Console.WindowHeight - 1);
                

            }
            #endregion



        }
        public static int Clamp(int value, int min, int max)
        {
            if (value < min)
            {
                return min;
            }
            else if (value > max)
            {
                return max;
            }
            else
            {
                return value;
            }
        }
    }
}
