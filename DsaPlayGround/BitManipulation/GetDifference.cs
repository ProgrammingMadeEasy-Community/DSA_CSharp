using System;

public static class GetDifference
{
    public static int DifferenceOfTwoArrays(int[] arr1, int[] arr2)
    {
        if(arr1 == null || arr2 == null)
            return 0;

        var result = 0;

        for (int i = 0; i < arr1.Length; i++)
        {
            result ^= arr1[i];
        }

        for (int i = 0; i < arr2.Length; i++)
        {
            result ^= arr2[i];
        }

        return result;
    }
}