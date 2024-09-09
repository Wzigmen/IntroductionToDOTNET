#define NUMERIC_TYPES
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Urok
    {
        static readonly string delimiter1 = "\n------------------------------------------\n";
        static readonly string delimiter2 = "\n==========================================\n";
        static void Main(string[] args)
        {
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
            int a = int.MaxValue;
            uint b = uint.MaxValue;
            Console.WriteLine(a);
            Console.WriteLine(b);
            long c = long.MaxValue;
            Console.WriteLine(b + c);
            Console.WriteLine((b + c).GetType()); 
            #endregion




        }
    }
}
