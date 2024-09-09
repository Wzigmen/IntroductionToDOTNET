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
        static int l = 0;
        static void Main(string[] args)
        {
            print("квадрат", '*', 5);
            print("треугольник 1", '*', 5);
            print("треугольник 2", '*', 5);
            print("треугольник 3", '*', 5);
            print("треугольник 4", '*', 5);
            print("ромб", '*', 5);
            print("шахматная доска", '*', 5);
            print("шахматная доска красивая", '*', 8);
            Console.WriteLine("Введите число: ");
            int chislo = Convert.ToInt32(Console.ReadLine());
            print("шахматная доска на заданное количество", '*', chislo);
        }
        static void print(string shap, char star, int size)
        {
            Console.WriteLine();
            Console.WriteLine($"{l})");
            if (shap == "ромб")
            {
                for (int i = 0; i < 2 * size; i++)
                {
                    int row = i < size ? i : 2 * size - 1 - i; //не сам додумался

                    for (int j = 0; j < size - row - 1; j++)
                        Console.Write(" ");

                    if (i < size)
                        Console.Write("/");
                    else
                        Console.Write("\\");

                    for (int j = 0; j < row * 2; j++)
                        Console.Write(" ");

                    if (i < size)
                        Console.Write("\\");
                    else
                        Console.Write("/");

                    Console.WriteLine();
                }
                l++;
                return;
            }
            if (shap == "шахматная доска красивая")
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if ((i + j) % 2 == 0)
                            Console.Write(new string(' ', 2));
                        else
                            Console.Write(new string('█', 2));
                    }
                    Console.WriteLine();
                }
                l++;
                return;
            }
            if (shap == "шахматная доска на заданное количество")
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if ((i + j) % 2 == 0)
                        {
                            for (int k = 0; k < size; k++)
                            {
                                if ((k + i) % 2 == 0)
                                {
                                    Console.Write(new string(' ', size));
                                }
                                else
                                {
                                    Console.Write(new string(star, size));
                                }
                            }
                            Console.WriteLine();
                        }
                        else
                        {
                            for (int k = 0; k < size; k++)
                            {
                                if ((k + i) % 2 == 0)
                                {
                                    Console.Write(new string(' ', size));
                                }
                                else
                                {
                                    Console.Write(new string(star, size));
                                }
                            }
                            Console.WriteLine();
                        }
                    }
                }
                l++;
                return;
            }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (shap == "квадрат")
                        Console.Write(star);
                    if (shap == "треугольник 1")
                        if (i >= j) Console.Write(star);
                    if (shap == "треугольник 2")
                        if (i <= j) Console.Write(star);
                    if (shap == "треугольник 3")
                    {
                        if (i <= j) Console.Write(star);
                        else Console.Write(" ");
                    }
                    if (shap == "треугольник 4")
                    {
                        if (i + 1 >= size - j) Console.Write(star);
                        else Console.Write(" ");
                    }
                    if (shap == "шахматная доска")
                    {
                        if ((i + j) % 2 == 0)
                            Console.Write("+");
                        else
                            Console.Write("-");
                    }

                }
                Console.WriteLine();
            }
            l++;
        }
    }
}
