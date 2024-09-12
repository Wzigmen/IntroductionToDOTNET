using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;
using System.IO;
using System.Runtime.InteropServices;

namespace Домашняя_работа_СS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Cursor
            //int cursorLeft = 0;
            //int cursorTop = 0;

            //while (true)
            //{
            //    Console.SetCursorPosition(cursorLeft, cursorTop);
            //    ConsoleKeyInfo key = Console.ReadKey(true);

            //    switch (key.Key)
            //    {
            //        case ConsoleKey.UpArrow:
            //            cursorTop--;
            //            break;
            //        case ConsoleKey.DownArrow:
            //            cursorTop++;
            //            break;
            //        case ConsoleKey.LeftArrow:
            //            cursorLeft--;
            //            break;
            //        case ConsoleKey.RightArrow:
            //            cursorLeft++;
            //            break;
            //        case ConsoleKey.Escape:
            //            return;
            //    }
            //    if (key.Key == ConsoleKey.Enter) break;
            //    cursorLeft = Clamp(cursorLeft, 0, Console.WindowWidth - 1);
            //    cursorTop = Clamp(cursorTop, 0, Console.WindowHeight - 1);

            //} 
            #endregion
            #region Kalkulator
            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("Введите первое число:");
            //        double num1 = double.Parse(Console.ReadLine());

            //        Console.WriteLine("Введите операцию (+, -, *, /):");
            //        string operation = Console.ReadLine();

            //        Console.WriteLine("Введите второе число:");
            //        double num2 = double.Parse(Console.ReadLine());

            //        double result = Calculate(num1, operation, num2);
            //        Console.WriteLine($"Результат: {result}");

            //        Console.WriteLine("Хотите продолжить? (да/нет)");
            //        string continueChoice = Console.ReadLine();

            //        if (continueChoice.ToLower() != "да")
            //        {
            //            break;
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("Ошибка: " + ex.Message);
            //    }
            //} 
            #endregion


        }

        static double Calculate(double num1, string operation, double num2)
        {
            switch (operation)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "/":
                    if (num2 == 0)
                    {
                        throw new DivideByZeroException("Деление на ноль!");
                    }
                    return num1 / num2;
                default:
                    throw new ArgumentException("Неверная операция!");
            }
        }
    }
    
}
