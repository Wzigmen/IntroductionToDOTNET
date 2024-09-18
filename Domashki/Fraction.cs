using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractions
{
    public class Fraction
    {
        public int Integer { get; set; }
        public int Numerator { get; set; }
        int denominator;

        public int Denominator
        {
            get => denominator;
            set => denominator = value == 0 ? 1 : value;
        }
        public Fraction(int integer) 
        {
            this.Integer = integer;
            Console.WriteLine($"1ArgConstructor:{GetHashCode()}");
        }
        public Fraction(int integer = 0, int denominator = 0, int numenator = 0)
        {
            this.Integer = integer;
            this.denominator = denominator;
            this.Numerator = numenator;
        }
        ~Fraction()
        {
            Console.WriteLine($"1ArgConstructor:{GetHashCode()}");
        }
        public void Print()
        {
            if (Integer != 0) Console.Write(Integer);
            if(Denominator != 0)
            {
                Console.Write("(");
                Console.Write($"{Numerator}/{Denominator}");
                Console.Write(")");
            } else if (Integer == 0) Console.Write(0);
            Console.WriteLine();
        }
    }
}
