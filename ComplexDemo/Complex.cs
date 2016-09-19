using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexDemo
{
    class Complex
    {

        public int Imaginary { get; private set; }
        public int Real { get; private set; }
        public double argument;
        public double modulus;

        public double Argument
        {
            get { argument = 1 / (Math.Tan(Real/Imaginary));
                return argument; }
        }
        public double Modulus
        {
            get { modulus = Math.Sqrt(Real*Real  +  Imaginary*Imaginary); 
                return modulus; }
        }

        public Complex(int real = 0, int imaginary = 0)
        { Real = real; Imaginary = imaginary; }
        public override string ToString()
        {
            return string.Format("({0}, {1})", Real, Imaginary);
        }
        //we define that when we use + op e Complex-Objects on rightHandSide (rhs) & lhs, we should perform so&so operation.
        public static Complex operator +(Complex lhs, Complex rhs)
        {
            int real = lhs.Real + rhs.Real;
            int imaginary = lhs.Imaginary + rhs.Imaginary;
            return new Complex(real, imaginary);
        }
        public static Complex operator -(Complex lhs, Complex rhs)
        {
            int real = lhs.Real - rhs.Real;
            int imaginary = lhs.Imaginary - rhs.Imaginary;
            return new Complex(real, imaginary);
        }

        public static bool operator ==(Complex lhs, Complex rhs)
        {
            if (lhs.Real == rhs.Real && lhs.Imaginary == rhs.Imaginary)
                return true;
            else
                return false;
        }
        public static bool operator !=(Complex lhs, Complex rhs)
        {
            if (lhs.Real != rhs.Real || lhs.Imaginary != rhs.Imaginary)
                return true;
            else
                return false;
        }














    }
}
