using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaMethod
{
    public struct Fraction
    {
        private readonly int numerator;
        private readonly int denominator;
        public Fraction(int numerator,int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public static Fraction operator +(Fraction a, Fraction b)
            => new Fraction(a.numerator * b.denominator + b.numerator * a.denominator, a.denominator * b.denominator);
        public static Fraction operator -(Fraction a, Fraction b) => new Fraction
            (a.numerator * b.denominator - b.numerator * a.denominator, a.denominator * b.denominator);

        public override string ToString()=> ($"{numerator}/{denominator}");
        

    }
}
