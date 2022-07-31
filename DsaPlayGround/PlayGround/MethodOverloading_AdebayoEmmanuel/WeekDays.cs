using System;
using System.Collections.Generic;
using System.Text;

namespace MethodOverloading_AssessmentTwo
{
    class Week
    {
        public static string DaysOfTheWeek(int input)
        {
            string day = Enum.GetName(typeof(Days), input);
            return day;
        }

        public static Dictionary<string, int> DaysOfTheWeek(int input, int input1, int input2 = 0)
        {
            Dictionary<string, int> weekDaysDict = new Dictionary<string, int>();
            int lenght = 2;
            if (input2 != 0)
            {
                lenght = 3;
            }
            string[] days = new string[lenght];
            days[0] = DaysOfTheWeek(input);
            days[1] = DaysOfTheWeek(input);
            if (input2 != 0)
            {
                days[2] = DaysOfTheWeek(input2);
            }
            foreach (string day in days)
            {
                try
                {
                    if (!weekDaysDict.ContainsKey(day))
                    {
                        weekDaysDict.Add(day, 1);
                    }
                    else
                    {
                        weekDaysDict[day]++;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("One or more of your input is/are out of range, kindly pass 1-7 " + e.Message.ToString());
                }
            }
            return weekDaysDict;
        }
        private enum Days { Sunday = 1, Monday = 2, Tuesday = 3, Wednesday = 4, Thursday = 5, Friday = 6, Saturday = 7 };
    }
}
