#define OUTPUT_TO_SCREEN
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IntroductionToDOTNET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region CodeShippet
            //Console.BackgroundColor = ConsoleColor.Green;
            //Console.SetWindowPosition(10, 10);
            Console.SetWindowSize(Console.WindowWidth, Console.WindowHeight); 


            Console.WindowHeight = 20;
            Console.WindowWidth = 60;

            //Console.WindowLeft = 10;
            //Console.WindowTop = 10;
            #endregion

#if OUTPUT_TO_SCREEN
            //int a;
            //IndexOutOfRangeException indexOutOfRangeException;
#endif

            #region Short
            //Console.Write($"Переменая типа 'short' занимает {sizeof(short)} байта");
            //Console.WriteLine($" и принимает значения в диапозоне: {short.MinValue} ... {short.MaxValue}");
            //Console.WriteLine(delimiter1);
            //Console.Write($"Переменая типа 'ushort' занимает {sizeof(ushort)} байта");
            //Console.WriteLine($"Диапозон принимаемых значений 'ushort': {ushort.MinValue} ... {ushort.MaxValue}");
            #endregion
            #region Int
            //Console.WriteLine(delimiter2);

            //Console.Write($"Переменая типа 'int' занимает {sizeof(int)} байта");
            //Console.WriteLine($" и принимает значения в диапозоне: {int.MinValue} ... {int.MaxValue}");
            //Console.WriteLine(delimiter1);
            //Console.Write($"Переменая типа 'Int16' занимает {sizeof(Int16)} байта");
            //Console.WriteLine($"Диапозон принимаемых значений 'Int16': {Int16.MinValue} ... {Int16.MaxValue}");

            //Console.WriteLine(delimiter2);  
            #endregion
#if NUMERIC_TYPES

            //Console.Write($"Переменая типа 'Single' занимает {sizeof(Single)} байта");
            //Console.WriteLine($" и принимает значения в диапозоне: {Single.MinValue} ... {Single.MaxValue}");
            //Console.WriteLine(delimiter1);
            //Console.Write($"Переменая типа 'double' занимает {sizeof(double)} байта");
            //Console.WriteLine($" и принимает значения в диапозоне: {double.MinValue} ... {double.MaxValue}");
            //Console.WriteLine(delimiter1);
            //Console.Write($"Переменая типа 'decimal' занимает {sizeof(decimal)} байта");
            //Console.WriteLine($"Диапозон принимаемых значений 'Int16': {decimal.MinValue} ... {decimal.MaxValue}");

#endif
            #region GetType_
            //Console.WriteLine(123.GetType());   // int
            //Console.WriteLine(123.4.GetType()); // double1
            //Console.WriteLine(123f.GetType());  // float
            //Console.WriteLine(123m.GetType());  // decimal
            //Console.WriteLine('-'.GetType());   // char
            //Console.WriteLine("few".GetType()); // string
            //Console.WriteLine(((byte)5).GetType()); // преобразование
            //C-like notation: (type)value;
            #endregion
            #region Exp
            //int a = int.MaxValue;
            //uint b = uint.MaxValue;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //long c = long.MaxValue;
            //Console.WriteLine(b + c);
            //Console.WriteLine((b + c).GetType());
            #endregion
            #region Factorial
            //try
            //{
            //    int a = int.Parse(Console.ReadLine());
            //    BigInteger f = 1;
            //    for (int i = 1; i <= a; i++)
            //    {
            //        f *= i;
            //        Console.WriteLine($"{i}! = {f}");
            //    }

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex);
            //}
            #endregion


        }
    }
}

