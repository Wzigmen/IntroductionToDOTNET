//#define INHERITENCE_1
//#define INHERITENCE_2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domashki;

namespace Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {

#if INHERITENCE_1
            Human human = new Human("Иван", "Иванов", 30);
            Console.WriteLine(human);

            Student student = new Student("Иван", "Иванович", 22, "Chemistry", "ww_220", 99, 33);
            Console.WriteLine(student);

            Teacher teacher = new Teacher("White", "Walter", 50, "Chemistry", 25);
            Console.WriteLine(teacher); 
#endif

#if INHERITENCE_2
            Human tommy = new Human("Factor", "Tommy", 22);
            Console.WriteLine(tommy);

            Student student_tommy = new Student(tommy, "Thefr", "Vice", 95, 98);
            Console.WriteLine(student_tommy);

            Human ricardo = new Human("Jojo", "Ricardo", 42);
            Console.WriteLine(ricardo);

            Teacher teacher_ricardo = new Teacher(ricardo, "Weapons", 20);
            Console.WriteLine(teacher_ricardo); 
#endif
            Human[] group = new Human[]
                {
                     new Student("Factor", "Tommy", 22, "Thefr", "Vice", 95, 98),
                     new Human("Jojo", "Ricardo", 42),
                     new Teacher("Lolic", "Rico", 36, "Weapons", 20)
                };


        }
    }
}
