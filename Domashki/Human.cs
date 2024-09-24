using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashki
{
    internal class Human
    {
        public string LastName {  get; set; }
        public string FirstName { get; set; }
        public uint Age { get; set; }
        public Human(string lastName, string firstName, uint age)
        {
            LastName = lastName;
            FirstName = firstName;
            Age = age;
            Console.WriteLine($"HConstructor:\t{GetHashCode()}");
        }
        public Human(Human human)
        {
            LastName = human.LastName;
            FirstName = human.FirstName;
            Age = human.Age;
            Console.WriteLine($"HCopyConstructor:\t{GetHashCode()}");
        }
        ~Human() 
        {
            Console.WriteLine($"HDestructor:\t{GetHashCode()}");
        }
        public override string ToString() 
        {
            return base.ToString()+$"\t{LastName} {FirstName} {Age} y/o";
        }
    }
}
