using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace PME_ATM
{
    public class Validation
    {
        public string expiringDate { get; set; }
        private static bool inputValid;

        public static bool checkCardNoPassword(int cardNo, int pwd)
        {

            bool pass = false;

            //dictionary for customers list
            Dictionary<int, Program> customerList = new Dictionary<int, Program>()
                {

                    {101, new Program(){ cardNo = 101, pwd= 098765, Name = "Golden Idikibiebuma" } },
                    {102, new Program(){ cardNo = 102, pwd = 123456, Name = "Pat Zino"} },
                    {103, new Program(){ cardNo = 103, pwd = 654321, Name = "Effiong Ubokobong"} },
                    {104, new Program(){ cardNo = 104, pwd = 004321, Name = "Precious Joseph"} },
                    {105, new Program(){ cardNo = 105, pwd = 123400, Name = "Parker Yusuf"} },
                    {106, new Program(){ cardNo = 106, pwd = 111111, Name = "Hemie Rasheedah"} }
                };


            foreach (KeyValuePair<int, Program> customer in customerList)

            {

                if ((customer.Key == cardNo && customer.Value.pwd == pwd) && CheckDateFormat() && ValDate(expiringDate:""))
                {
                    
                    Console.WriteLine("------------###############################################-------------");
                    Console.WriteLine("-");
                    Console.WriteLine("[]        WELCOME TO PME ATM :  - - " + customer.Value.Name + "       []");
                    Console.WriteLine("-");
                    Console.WriteLine(">>>>>>>                                                     <<<<<<<<<<<<");
                    Console.WriteLine("           <<<<<< Click any key to continue >>>>>>>");
                    Console.WriteLine("                                    ");
                    Console.WriteLine("---------#####################################################----------");
                    Console.ReadKey();
                    Console.WriteLine("                   NAME :  - - " + customer.Value.Name);
                    Console.WriteLine("                                    ");

                    pass = true;
                }


            }
            return pass;

        }

        //Method to check card enteries
        public static bool CheckDateFormat()
        {
            
            Console.WriteLine("Enter card expiring date, following your system date format ");
            string expiringDate = Console.ReadLine();
            var dateFormats = new[] { "dd/MM/yyyy", "dd-MM-yyyy", "dd.MM.yyyy" };
            DateTime d;
            bool inputValid = DateTime.TryParseExact(expiringDate, dateFormats, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out d);
  
            while (true)
            {
          
                if (!inputValid)
                {               
                        Console.WriteLine("Invalid Date detected");

                    return inputValid;            
                }
              
                else
                {

                    Console.WriteLine("Correct!!");
                    return inputValid;
                }
            }
            
            
        }
        public static bool ValDate(string expiringDate)
        {
            
            int i = 0;
            DateTime convertStringToDate;

            bool validDate = DateTime.TryParse(expiringDate, out convertStringToDate);
            do
            {
                if (convertStringToDate >= DateTime.Now)
                {
                    Console.WriteLine("Correct and Valid Card!!! ");
                    return validDate;
                }
                else

                {
                    Console.WriteLine("|<<<<<---#########***************########--->>>>>>|");
                    Console.WriteLine("|                                                 |");
                    Console.WriteLine("|          PME Micro Finance Bank ATM             |");
                    Console.WriteLine("|                                                 |");
                    Console.WriteLine("| Your Card has expired or invalid expiring date  |");
                    Console.WriteLine("| Remove take your card and Try again             |");
                    Console.WriteLine("| Thanks for banking with us                      |");
                    Console.WriteLine("|                                                 |");
                    Console.WriteLine("|-----------#########################-------------|");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    //use the below code line if you need to exist the user at this point
                    //System.Environment.Exit(1);

                    Console.WriteLine("|-----------Click any Key to try again-------------|");
                    Console.ReadKey();
                    

                }
                return validDate;
            } while (i > 3);
           
        }



    }
}
