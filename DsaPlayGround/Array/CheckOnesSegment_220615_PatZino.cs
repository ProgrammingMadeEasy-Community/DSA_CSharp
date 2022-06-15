namespace DsaPlayGround.Array
{
    public static class CheckOnesSegment_220615_PatZino
    {
        /***
        * Find question description in the AllImages folder with the same 
        * name as the class excluding Date and Github UserName (CheckOnesSegment.png)
        * Link to the question: https://leetcode.com/problems/check-if-binary-string-has-at-most-one-segment-of-ones/
        */

        public static bool CheckOnesSegment(string s)
        {
            if (s.Length == 1) return true;
            var isZero = false;

            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] == '0')
                {
                    isZero = true;
                }

                if (isZero && s[i] == '1')
                    return false;
            }

            return true;
        }
    }
}
