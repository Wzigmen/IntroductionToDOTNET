using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashki
{
    class Fraction
    {
        public int Integer { get; set; }   
        public int Numerator { get; set; }
        int denominator;
        public int Denominator
        {
            get => denominator;
            set => denominator = value == 0 ? 1 : value;
        }

        //			  Constructors:
        public Fraction()
        {
            Console.WriteLine($"DefConstructor{GetHashCode()}");
        }
        public Fraction(int integer)
        {
            this.Integer = integer;
            Console.WriteLine($"1ArgConstructor:{GetHashCode()}");
        }
        public Fraction(int numerator, int denominator)
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
            Console.WriteLine($"1ArgConstructor:{GetHashCode()}");
        }
        public Fraction(int integer, int numerator, int denominator)
        {
            this.Integer = integer;
            this.Numerator = numerator;
            this.denominator = denominator;

        }
        public Fraction(Fraction other)
        {
            this.Integer = other.Integer;
            this.Numerator = other.Numerator;
            this.Denominator = other.Denominator;
            Console.WriteLine($"CopyConstructor:\t{GetHashCode()}");
        }
        ~Fraction()
        {
            Console.WriteLine($"Destructor:{GetHashCode()}");
        }

        //				Operators:
        // Составные присваивания: +=, -=, *=, /=
        public static Fraction operator *(Fraction a, Fraction b)
        {
            Fraction a1 = a.Improper();
            Fraction b1 = b.Improper();
            Fraction res = new Fraction(a1.Numerator * b1.Numerator, a1.Denominator * b1.Denominator);
            return res;
        }
        public static Fraction operator /(Fraction a, Fraction b)
        {
            Fraction a1 = a.Improper();
            Fraction b1 = b.Improper();
            Fraction res = new Fraction(a1.Numerator * b1.Denominator, a1.Denominator * b1.Numerator);
            return res;
        }
        public static Fraction operator +(Fraction a, Fraction b)
        {
            Fraction a1 = a.Improper();
            Fraction b1 = b.Improper();
            return new Fraction(a1.Numerator * a1.Denominator + b1.Numerator * b1.Denominator, a1.Denominator * b1.Denominator);
        }
        public static Fraction operator -(Fraction a, Fraction b)
        {
            Fraction a1 = a.Improper();
            Fraction b1 = b.Improper();
            Fraction res = new Fraction(a1.Numerator * a1.Denominator - b1.Numerator * b1.Denominator, a1.Denominator * b1.Denominator);
            return res;
        }
        //              Increment/Decrement ++/--
        public static Fraction operator ++(Fraction a)
        {
            a.Integer++;
            return a;
        }
        public static Fraction operator --(Fraction a)
        {
            a.Integer--;
            return a;
        }
        // Операторы сравнения ==, !=, >, <, >=, <=
        public static bool operator ==(Fraction a, Fraction b) 
            => (a == b);
        public static bool operator !=(Fraction a, Fraction b) 
            => (a != b);
        public static bool operator >(Fraction a, Fraction b) 
            => (a > b);
        public static bool operator <(Fraction a, Fraction b) 
            => (a < b);
        public static bool operator >=(Fraction a, Fraction b) 
            => (a > b || a == b);
        public static bool operator <=(Fraction a, Fraction b) 
            => (a < b || a == b);
        Fraction Proper()
        {
            Fraction copy = new Fraction(this);
            copy.Integer += copy.Numerator / copy.Denominator;
            copy.Numerator %= copy.Denominator;
            return copy;
        }
        Fraction Improper()
        {
            Fraction copy = new Fraction(this);
            copy.Numerator += copy.Integer * copy.Denominator;
            copy.Integer = 0;
            return copy;
        }
        public void Print()
        {
            if (Integer != 0) Console.Write(Integer);
            if (Numerator != 0)
            {
                if (Integer != 0) Console.Write("(");
                Console.Write($"{Numerator}/{Denominator}");
                if (Integer != 0) Console.Write(")");
            }
            else if (Integer == 0) Console.Write(0);
            Console.WriteLine();
        }
        public override string ToString()
        {
            string print = "";
            if (Integer != 0) print += Integer;
            if (Numerator != 0)
            {
                if (Integer != 0) print += "(";
                print += $"{Numerator}/{Denominator}";
                if (Integer != 0) print += ")";
            }
            else if (Integer == 0) print += 0;
            Console.WriteLine();
            return print;
        }
    }
}