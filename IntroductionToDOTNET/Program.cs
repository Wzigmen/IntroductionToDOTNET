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

            Console.WriteLine("Введите имя: ");
            string first_name = Console.ReadLine();

            Console.WriteLine("Введите фамилию: ");
            string last_name = Console.ReadLine();

            Console.WriteLine("Введите возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());
            // Конкатенация
            Console.WriteLine(last_name + " " + first_name + " " + age);
            // Форматирование
            Console.WriteLine(String.Format("{0} {2} {1} ", last_name, first_name, age));
            // Интерполяция 
            Console.WriteLine($"{last_name} {first_name} {age} ");
            

        }
    }
}

