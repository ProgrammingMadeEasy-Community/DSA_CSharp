using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsaPlayGround.Array
{
    public static class SquaresOfASortedArray
    {
        /***
      * Find question description in the AllImages folder with the  
      * name (Squares Of A Sorted Array.jpg)
      */
        public static int[] SortedSquares(int[] nums)
        {
            int i = 0;
            int k = nums.Length - 1;
            int j = nums.Length - 1;

            int[] result = new int[nums.Length];
            while (i <= j)
            {
                var posI = Math.Abs(nums[i]);
                var posJ = Math.Abs(nums[j]);
                if (posI >= posJ)
                {
                    result[k] = posI * posI;
                    i++;
                }
                else
                {
                    result[k] = posJ * posJ;
                    j--;
                }
                k--;
            }

            return result;
        }
    }
}
