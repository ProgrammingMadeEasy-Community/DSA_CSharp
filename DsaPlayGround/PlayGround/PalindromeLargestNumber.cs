using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsaPlayGround.PlayGround
{
    public static class PalindromeLargestNumber
    {
        /***
         * 
         * Find question description in the AllImages folder with the same 
         * name as the class (PalindromeLargestNumber.jpeg)
         * 
         */
        public static int LargestPalindrome(string nums)
        {
            if (string.IsNullOrEmpty(nums)) return 0;
            if (Convert.ToInt32(nums) == 0) return 0;
            if (nums.Length == 1) return Convert.ToInt32(nums);

            string left = string.Empty;
            string right = string.Empty;

            HashSet<int> oddDig = new HashSet<int>();

            int[] numFreq = new int[10];

            for (int i = 0; i < nums.Length; i++)
            {
                var index = nums[i] - 48;
                numFreq[index]++;
            }

            for (int i = 9; i >= 0; i--)
            {
                if (numFreq[i] % 2 == 0)
                {
                    var count = numFreq[i] / 2;
                    while (count > 0)
                    {
                        left += (char)(i + 48);
                        right = ((char)(i + 48)) + right;
                        count--;
                    }
                }
                else if (numFreq[i] > 2 && numFreq[i] % 2 == 1)
                {
                    oddDig.Add(i);
                    var count = numFreq[i] / 2;
                    while (count > 0)
                    {
                        left += (char)(i + 48);
                        right = ((char)(i + 48)) + right;
                        count--;
                    }
                }
                else
                {
                    oddDig.Add(i);
                }
            }

            var maxOddDig = (char)(oddDig.Max() + 48);
            var result = left + maxOddDig + right;

            return Convert.ToInt32(result);
        }
    }
}
