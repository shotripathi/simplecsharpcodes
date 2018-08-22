using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectSquare
{
    class PSChecker
    {
        /*
         * Check if supplied parameter is a perfect square
         * @param number A number supplied by the user.
         * @retrun A boolean. 
        */
        public Boolean IsPerfectSquare(int number)
        {
            //Getting the absolute value of the supplied number
            if (number < 0)
            {
                number = number * -1;
            }
            if (System.Math.Sqrt(number) % 1 == 0)
            {
                return true;
            }
            return false; 
        }
    }
}
