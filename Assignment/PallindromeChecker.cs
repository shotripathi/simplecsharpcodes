using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class PalindromeChecker
    {

        /*
         * Check whether the supplied string is palindrome or not. 
         * @param word A string supplied by the user. 
         * @return A boolean.
        */
        public Boolean IsPalindrome(string word)
        {
            //checking if the supplied string is a single word
            if (word.Split().Length > 1)
            {
                Console.WriteLine("The supplied string contains spaces or is more than one word.");
                Console.ReadKey();
                Environment.Exit(1);
            }

            word = word.ToLower(); //avoiding the upper and lowercase difference

            //forming the reverse of the word
            string reverse="";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverse += word[i];
            }

            //checking if the reverse and the supplied word is same
            if (reverse == word)
            {
                return true;
            }

            return false;
        }
    }
}
