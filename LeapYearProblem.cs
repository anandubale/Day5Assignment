using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5Probems
{
    class LeapYearProblem
    {
        //Field
        int YearToRead; //---> Declaration of Fields

        //Constructor -To initialize Fields
        public LeapYearProblem( int YEARTOREAD)
        {
            this.YearToRead = YEARTOREAD;
            //int YearToRead = YEARTOREAD;
        }



        //method - to check wheather year is leap or not.
        public string MethodToCheckLeapYear()
        {
            //int remainder1 = YearToCheck % 400;
            string YesItIs = " is leap year";

            //if (remainder1 == 0)
              //  {
                //return YesItIs;

                //}

            //else { 
                int remainder2 = YearToRead % 4;
                if (remainder2 == 0)
                {
                    
                return YesItIs;
                }
                else
                {
                    string NoItIsNot = " is not Leap Year";
                return NoItIsNot;
                }
            //}
        }

    }
}
//Leap Year
//a. I/P -> Year, ensure it is a 4 digit number.
//b. Logic -> Determine if it is a Leap Year.
//c. O/P -> Print the year is a Leap Year or not.

 