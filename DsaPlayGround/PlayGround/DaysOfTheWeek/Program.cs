using System;
using System.Collections.Generic;


namespace DayOfTheWeek
{
    public enum Days
    {
        Moday = 1, Tuesday = 2, Wednesday = 3, Thursday = 4, Friday = 5, Saturday = 6, Sunday = 7,
    }
    internal class Program
    {
        static void Main(string[] args)
        {    
            try
            {
                DaysOfTheWeek(44,44);
            }
            catch (Exception ex)
            { Console.Write(ex.ToString()); }   
        }
        private static void DaysOfTheWeek(params int [] inputDays)
        {
            try
            {
                Dictionary<int, int> daysDictionary = new Dictionary<int, int>();
                foreach (int day in inputDays)
                {
                    if (daysDictionary.ContainsKey(day))
                    {
                        daysDictionary[day]++;
                        continue;
                    }
                    daysDictionary.Add(day, 1);
                }
                foreach (var item in daysDictionary.Keys)
                {
                    int freg = daysDictionary[item];
                    Days eachDay = (Days)item;
                    bool isValidArgument = Enum.IsDefined(typeof(Days), eachDay);
                    if (!isValidArgument)
                        throw new ArgumentException("One of your input is of the wrong format");

                    else
                        Console.WriteLine("Day:{0}, frequency={1}", eachDay, freg);
                }
                DaysOfTheWeek(inputDays[1]);
            }
            catch (Exception ex)
            { Console.WriteLine(ex.ToString()); }
        }
        private static void DaysOfTheWeek(int day)
        {
               Days inputDay = (Days)day;
                bool validArgument = Enum.IsDefined(typeof(Days), inputDay);
            if (validArgument)
                Console.WriteLine(inputDay);
            else
                throw new ArgumentException("Invalid input");
                  
        }
    }
}
