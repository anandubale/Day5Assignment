using System;

namespace Assignment5Probems
{
    class Program
    {

        static void Main(string[] args)
        {
            /*
            // 2.Lear Year Problem
            Console.WriteLine("enter year you want to check wheather leap year or not");
            int yeartoread = int.Parse(Console.ReadLine()); //saved year in yeartoread using console.readline and cpnvert it into int using int.parse()method
            LeapYearProblem l1 = new LeapYearProblem(yeartoread);
            Console.WriteLine(yeartoread + l1.MethodToCheckLeapYear());
            */

            /*
             
            //3.PowerOf2
            Console.WriteLine("Enter Number");
            int n = int.Parse(Console.ReadLine());
            TableOfPowerOf2 t1 = new TableOfPowerOf2(n);
            t1.TableOf2();


            */
            /*we have to look for it 
            h1.HarmonicSeries();

            //4. Harmonic Porblem solution
            Console.WriteLine("Enter Number");
            int n = int.Parse(Console.ReadLine());
            HarmonicPoblem h1 = new HarmonicPoblem(n);
            */

            /*

            //5. prime factor Number
            Console.WriteLine("Please enter your integer: ");
            int Number = int.Parse(Console.ReadLine());
            PrimeFactorOfNumbers p1 = new PrimeFactorOfNumbers(Number);
            p1.PrimeFactors();
            
            */

            /*
            //6. CAlculate Quotient and Remainder
            Console.WriteLine("Please Number: ");
            int Number = int.Parse(Console.ReadLine());
            Console.WriteLine("Please By which you want to Divide: ");
            int  By = int.Parse(Console.ReadLine());

            QuotientNdRemainder Q1 = new QuotientNdRemainder(Number, By);
            Q1.Calculate();

            */












            /*
            //9. Vowel Or Consonant
            Console.WriteLine("Please enter Any Alphabet: ");
            string Alphabet = Console.ReadLine();
            ConsonentNdVowel c1 = new ConsonentNdVowel(Alphabet);
            c1.Check();

            */
            /*
            //10. Largest of All

            Console.WriteLine("Enter Number 1");
            int Num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number 2");
            int Num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number 3");
            int Num3 = int.Parse(Console.ReadLine());
            CalculateLargest l1 = new CalculateLargest(Num1, Num2, Num3);
            l1.Largest();

            */
            Console.WriteLine("Enter Number ");
            int Number = int.Parse(Console.ReadLine());
            EvenOrOdd E1 = new EvenOrOdd(Number);
            Console.WriteLine(E1.Check());

        }
    }
}
