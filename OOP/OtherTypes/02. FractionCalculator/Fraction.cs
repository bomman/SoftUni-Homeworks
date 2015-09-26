using System;

namespace _02.FractionCalculator
{
    public struct Fraction
    {
        private long numerator;
        private long denominator;

        public Fraction(long numerator, long denumerator)
            : this()
        {
            this.Denominator = denumerator;
            this.Numerator = numerator;
        }

        public long Numerator
        {
            get { return this.numerator; }
            set
            {
                if (value > 9223372036854775807 || value < -9223372036854775807)
                {
                    throw new OverflowException("The number is bigger than long.Max or lower than long.Min!");
                }
                this.numerator = value;
            }
        }

        public long Denominator
        {
            get { return this.denominator; }
            set
            {
                if (value > 9223372036854775807 || value < -9223372036854775807)
                {
                    throw new OverflowException("The number is bigger than long.Max or lower than long.Min!");
                }
                if (value == 0)
                {
                    throw new DivideByZeroException("To divide in zero is invalid operation");
                }
                this.denominator = value;
            }
        }

        public static Fraction operator +(Fraction firstFraction, Fraction secondFraction)
        {
            long commonNumerator = (firstFraction.Numerator*secondFraction.Denominator) + (firstFraction.Denominator*secondFraction.Numerator);
            long commonDenumarator = firstFraction.Denominator*secondFraction.Denominator;
            return new Fraction(commonNumerator, commonDenumarator);
        }

        public static Fraction operator -(Fraction firstFraction, Fraction secondFraction)
        {

            long commonNumerator = (firstFraction.Numerator * secondFraction.Denominator) - (firstFraction.Denominator * secondFraction.Numerator);
            long commonDenumarator = firstFraction.Denominator * secondFraction.Denominator;
            return new Fraction(commonNumerator, commonDenumarator);
        }

        public override string ToString()
        {
            double result = this.Numerator/this.Denominator;
            return result.ToString();
        }
    }
}