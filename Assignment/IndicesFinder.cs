using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAndIndices
{
    class IndicesFinder
    {
        /*
         * Find the pairs which sum up to become the supplied target value.
         * @param numbers An array of numbers to be supplied by the user.
         * @param target A target value to be supplied by the user.
         * @return A list which contains the pairs
         */
        public List<IndexPair> FindIndices(int [] numbers,int target)
        {
            List<IndexPair> listOfPairs = new List<IndexPair>();
            for(int i = 0; i < numbers.Length; i++)
            {
                for(int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == target)
                    {
                        listOfPairs.Add(new IndexPair(i, j));
                    }
                }
            }
            return listOfPairs;
        }
    }
    class IndexPair
    {
        int Index1;
        int Index2;

        public IndexPair(int val1, int val2)
        {
            Index1 = val1;
            Index2 = val2;
        }

        /*
         * Display the pair in a format.
         */
        public void DisplayPair()
        {
            Console.WriteLine($"{Index1},{Index2}");
        }
    }
}
