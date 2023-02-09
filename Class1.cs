﻿namespace ClassLibrary5
{
    public class Binomial
    {

        public int a { get; set; }
        public int b { get; set; }
        public double this[double index]
        {
            get
            {
                return pwr(index);
            }

        }
        double pwr(double p)
        {
            return (a * p) + b;
        }

        public Binomial()
        {
        }
        public Binomial(int a, int b)
        {
            this.a = a;
            this.b = b;

        }

        public override bool Equals(object obj)
        {
            return obj is Binomial binomial &&
                   a == binomial.a &&
                   b == binomial.b;
        }

        public override int GetHashCode()
        {
            int hashCode = 2118541809;
            hashCode = hashCode * -1521134295 + a.GetHashCode();
            hashCode = hashCode * -1521134295 + b.GetHashCode();
            return hashCode;
        }

        public static explicit operator Binomial(int s)
        {

            return new Binomial(s, s);
        }

        public static implicit operator double(Binomial number)
        {
            return number.b;
        }

        public static Binomial operator +(Binomial value1, Binomial value2)
        {
            return new Binomial(value1.a + value2.a, value1.b + value2.b);
        }
        public static Binomial operator +(Binomial value1, int value2)
        {
            return new Binomial(value1.a, value1.b + value2);
        }

        public static Binomial operator -(Binomial value1, Binomial value2)
        {
            return new Binomial(value1.a - value2.a, value1.b - value2.b);
        }
        public static Binomial operator -(Binomial value1, int value2)
        {
            return new Binomial(value1.a, value1.b - value2);
        }


        public static Binomial operator *(Binomial value1, int value2)
        {
            return new Binomial(value1.a * value2, value1.b * value2);
        }

        public static bool operator ==(Binomial value1, Binomial value2)
        {
            if ((value1.b == value2.b) && (value1.a == value2.a))
            {
                return true;
            }
            else return false;
        }
        public static bool operator !=(Binomial value1, Binomial value2)
        {
            if ((value1.b != value2.b) || (value1.a != value2.a))
            {
                return false;
            }
            else return true;
        }
        public static bool operator true(Binomial value)
        {

            if ((value.b != 0) && (value.a != 0))
            {
                return true;
            }
            else return false;
        }
        public static bool operator false(Binomial value)
        {
            if ((value.b == 0) || (value.a == 0))
            {
                return true;
            }
            else return false;
        }
        public override string ToString()
        {
            return a.ToString() + "x" + "+" + b.ToString();
        }


    }
}