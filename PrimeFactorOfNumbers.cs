using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5Probems
{
    class PrimeFactorOfNumbers
    {

        //fields
        int Factor;
        int Number;

        public PrimeFactorOfNumbers(int NUMBER)
        {
            this.Number = NUMBER;
        }

        public void PrimeFactors()
        {


            for (Factor = 2; Number > 1; Factor++) //Start dividing the number by the smallest prime number i.e., 2, followed by 3, 5, and so on 
                if (Number % Factor == 0) //if it get devided by that factor then 
                {
                    int Times = 0;
                    while (Number % Factor == 0) //calculate Number of Times we use same factor
                    {
                        Number = Number / Factor;
                        Times++; //for every possible division we increment that facot Number to get How many times we can factor it with this nummber
                    }
                     Console.WriteLine(Factor + " is a prime factor " + Times + " times! ");
                }
            
        } 

    }
}
