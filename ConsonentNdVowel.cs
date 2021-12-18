using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5Probems
{
    class ConsonentNdVowel
    {
        string Alphabet;
        String alpha;

        public ConsonentNdVowel(string ALPHABET)
        {
            this.Alphabet = ALPHABET;
        }

        public void Check()
        {
            string alpha =Alphabet.ToUpper();
            if(alpha == "A"|| alpha == "E" || alpha == "I" || alpha == "O" || alpha == "U")
            {
                Console.WriteLine("This is Vowel");
            }
            else
            {
                Console.WriteLine("This is Consonant");

            }
        }

    }//C# Program to Check Whether an Alphabet is Vowel or Consonant
}
