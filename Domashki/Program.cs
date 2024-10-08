﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Домашняя_работа_СS
{
    internal class Domashki
    {
        static readonly string delimiter2 = "\n==========================================\n";
        static void Main(string[] args)
        {
#if false // Console
            int cursorLeft = 0;
            int cursorTop = 0;
            while (true)
            {
                Console.SetCursorPosition(cursorLeft, cursorTop);
                ConsoleKeyInfo key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.W:
                        cursorTop--;
                        break;
                    case ConsoleKey.S:
                        cursorTop++;
                        break;
                    case ConsoleKey.A:
                        cursorLeft--;
                        break;
                    case ConsoleKey.D:
                        cursorLeft++;
                        break;
                    case ConsoleKey.Escape:
                        return;
                }
                cursorLeft = cursorLeft < 0 ? 0 : Console.WindowWidth - 1 < cursorLeft ? Console.WindowWidth - 1 : cursorLeft;
                cursorTop = cursorTop < 0 ? 0 : Console.WindowHeight - 1 < cursorTop ? Console.WindowHeight - 1 : cursorTop;

            }  
#endif

#if false // Calculate
            while (true)
            {
                try
                {
                    Console.Write("Ввод: ");
                    string str = Console.ReadLine();
                    string[] tokens = Regex.Split(str, @"(?<=\+|\-|\*|\/)|(?=\+|\-|\*|\/)");
                    double num1 = 0, num2 = 0, res = 0;
                    if (!double.TryParse(tokens[0], out num1) || !double.TryParse(tokens[2], out num2))
                    {
                        Console.WriteLine("Неправильно набранно");
                    } else {
                        res = Calculate(num1, tokens[1], num2);
                    }
                    Console.WriteLine("Вывод: " + res);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } 
#endif
            Console.WriteLine(delimiter2);
            double[] DOUBLE1 = new double[] { 22.3, 41.42, 5.1, 8.1};
            int[] INT1 = new int[] { 2, 5, 78, 98, 1};
            string[] STRING1 = new string[] { "завтра", "бухаем", "наверное"};
            print(DOUBLE1);
            print(INT1);
            print(STRING1);
            Console.WriteLine(delimiter2);
            Console.WriteLine($"Array {DOUBLE1.ToString()}:\t sum {DOUBLE1.Sum()}\t min {DOUBLE1.Min()}\t max {DOUBLE1.Max()} ");
            Console.WriteLine($"Array {INT1.ToString()}:\t sum {INT1.Sum()}\t min {INT1.Min()}\t max {INT1.Max()} ");
            Console.WriteLine($"Array {STRING1.ToString()}:\t sum - \t\t min {STRING1.Min()}\t max {STRING1.Max()}");
            Console.WriteLine(delimiter2);

        }
        //public static T sum<T>(T[] args) 
        //{
        //    T sum = args[0];
        //    for (int i = 1; i < args.Length; i++)
        //    {
        //        sum += args[i];
        //    }
        //    return sum;
        //}
        public static void print<T>(T[] index)
        {
            Console.WriteLine( "Arrays " + index.ToString());
            for (int i = 0; i < index.Length; i++)
            {
                Console.Write(index[i] + " ");
            }
            Console.WriteLine("\n");
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
                        throw new DivideByZeroException("Деление на ноль нельзя!");
                    return num1 / num2;
                default:
                    throw new ArgumentException("Неверная операция!");
            }
        }
    }
}
