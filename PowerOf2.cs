using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5Probems
{
    class TableOfPowerOf2
    {
        int n;
        int result;
        public TableOfPowerOf2( int N )
        {
            this.n = N;

        }
            
       public void TableOf2()
        {
          for (int i = 1; i < n ;i++)
            {
                double result = Math.Pow(2, i);
                Console.WriteLine(result);
            }
        }
         


    }
}
//Power of 2
//a.Desc->This program takes a command-line argument N and prints a table of the
//powers of 2 that are less than or equal to 2^N.
//b. I/P -> The Power Value N. Only works if 0 <= N < 31 since 2^31 overflows an int
//c. Logic -> repeat until i equals N.
//d. O/P -> Print the year is a Leap Year or not.