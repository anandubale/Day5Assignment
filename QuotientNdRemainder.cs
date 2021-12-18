using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//C# Program to Compute Quotient and Remainder
namespace Assignment5Probems
{
    class QuotientNdRemainder
    {
        int Number;
        int By;

        public QuotientNdRemainder(int NUMBER, int DivideBy)
        {
            this.Number = NUMBER;
            this.By = DivideBy;

        }

        public void Calculate()
        {
            int Quotient;
            int Remainder;

            Quotient = Number / By;
            Remainder = Number % By;

            Console.WriteLine("Quotient " + Quotient);
            Console.WriteLine("Remainder " + Remainder);
        }
    }
}
