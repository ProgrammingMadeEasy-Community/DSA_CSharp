using System;
using System.Collections.Generic;
using System.Linq;

namespace MethodOverloading_AssessmentTwo
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter 3 digits: ");
                string input = Convert.ToInt32(Console.ReadLine()).ToString();
                Dictionary<string, int> daysDictionary;
                if (input.Length == 2)
                    daysDictionary = Week.DaysOfTheWeek((input[0] - '0'), (input[1] - '0'));
                else
                    daysDictionary = Week.DaysOfTheWeek((input[0] - '0'), (input[1] - '0'), (input[2] - '0'));
                foreach (KeyValuePair<string, int> kvp in daysDictionary)
                {
                    Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Each digit should be from 1-7 " + e.Message.ToString());
            }
        }
    }
}
