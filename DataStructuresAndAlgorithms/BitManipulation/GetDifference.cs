using System;

class Program
{

    public static readonly int[] arr1 = { 1, 2, 4 };
    public static readonly int[] arr2 = { 1, 5, 2, 4 };

    public static void Main(string[] args)
    {
        Console.WriteLine(GetDiff(arr1, arr2));

    }

    public static int GetDiff(int[] arr1, int[] arr2)
    {
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