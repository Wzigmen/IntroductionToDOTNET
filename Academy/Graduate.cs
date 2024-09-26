using Domashki;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    class Graduate : Student
    {
        public string ThesisTopic { get; set; }
        public Graduate(Human numan, string speciality, string group, double rating, double attendance, string thesisTopic) : base(numan, speciality, group, rating, attendance) // Constructor
        {
            ThesisTopic = thesisTopic;
        }
        public Graduate(Student student, string thesisTopic) 
            : base(student.LastName,student.FirstName,student.Age,student.Speciality,student.Group,student.Rating,student.Attendance)
        {
            ThesisTopic = thesisTopic;
        }
        ~Graduate() { }
        public override string ToString()
        {
            return base.ToString() + $"\t{ThesisTopic}";
        }
    }
}
