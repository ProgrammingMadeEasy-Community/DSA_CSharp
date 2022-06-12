namespace DsaPlayGround.Array
{
    public static class RunningSumOf1dArray
    {
        /***
       * Find question description in the AllImages folder with the same 
       * name as the class (RunningSumOf1dArray.png)
       */

        public static int[] RunningSum(int[] nums)
        {
            for (var i = 1; i < nums.Length; i++)
            {
                nums[i] += nums[i - 1];
            }

            return nums;
        }
    }
}
