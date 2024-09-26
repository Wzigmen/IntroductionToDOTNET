using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashki
{
    class Student:Human
    {
        public string Speciality { get; set; }
        public string Group { get; set; }
        public double Rating { get; set; }
        public double Attendance { get; set; }
        public Student 
            (
            string lastName,string firstName,uint age,
            string speciality,string group,double rating,double attendance
            ): base(lastName,firstName,age) 
        {
            Speciality = speciality;
            Group = group;
            Rating = rating;
            Attendance = attendance;
            Console.WriteLine($"SConstructor:\t{GetHashCode()}");
        }
        public Student(Human human, string speciality, string group, double rating, double attendance) : base(human) // Constructor
        {
            Speciality= speciality;
            Group = group;
            Rating = rating;
            Attendance = attendance;
            Console.WriteLine($"SConstructor:\t{GetHashCode()}");
        }

        public Student(Student student) : base(student) // CopyConstructor
        {
            this.Speciality = student.Speciality;
            this.Group = student.Group;
            this.Rating = student.Rating;
            this.Attendance = student.Attendance;
            Console.WriteLine($"SCopyConstructor:\t{GetHashCode()}");
        }

        ~Student() 
        {
            Console.WriteLine($"SDestructor:\t{GetHashCode()}");
        }
        public override string ToString()
        {
            return base.ToString() + $" \t{Speciality}\t{Group}\t{Rating}\t{Attendance}";
        }
    }
}
