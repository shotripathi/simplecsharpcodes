using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainNameSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            //PerfectSquare.PSChecker sqCheckerObj = new PerfectSquare.PSChecker();
            //Console.WriteLine(sqCheckerObj.IsPerfectSquare(-144));

            //Palindrome.PalindromeChecker palindromeCheckerobj = new Palindrome.PalindromeChecker();
            //Console.WriteLine(palindromeCheckerobj.IsPalindrome("ABcba"));

            int[] x = { 3, 1, 5, 7, 5, 9 };
            int target = 10;
            SumAndIndices.IndicesFinder indicesFinderObj = new SumAndIndices.IndicesFinder();
            foreach(SumAndIndices.IndexPair pair in indicesFinderObj.FindIndices(x,target))
            {
                pair.DisplayPair();
            }

            //Hodling the Screen for output
            Console.ReadKey();
        }

    }
}
