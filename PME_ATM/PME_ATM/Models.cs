using System;
using System.Collections.Generic;
using System.Text;

namespace PME_ATM
{
    public class Models
    {
        public static String cur = "NG ";
        public static double latestAccount_bal = 5000;
        //Making an interface window...lol
        public static void showMenu1()
        {
            Console.WriteLine("|<<<<<---#################--->>>>>>|");
            Console.WriteLine("|                                  | ");
            Console.WriteLine("|    PME Micro Finance Bank ATM    |");
            Console.WriteLine("|                                  |");
            Console.WriteLine("|     1. Insert Your ATM Card      |");
            Console.WriteLine("|     2. Exist                     |");
            Console.WriteLine("|                                  |");
            Console.WriteLine("----------#############-------------");
            Console.Write("Please Enter your option ");
        }

        public static void showMenu2()
        {
            Console.WriteLine("|<<<<<---#################--->>>>>>|");
            Console.WriteLine("|                                  | ");
            Console.WriteLine("|    PME Micro Finance Bank ATM    |");
            Console.WriteLine("|                                  |");
            Console.WriteLine("|     1. Check balance             |");
            Console.WriteLine("|     2. Make Deposit              |");
            Console.WriteLine("|     3. Withdraw Cash             |");
            Console.WriteLine("|     4. Logout                    |");
            Console.WriteLine("|                                  |");
            Console.WriteLine("---------#############--------------");
            Console.Write("Please Enter your option ");
        }


        //Logic from user entries
        public static void mainOperation()
        {

            string menu0 = "";
            int menu1 = 0;
            int menu2 = 0;
            int cardNo = 0;
            int pin = 0;
            int tries = 0;
            int maxTries = 3;

            //DateTime xDate = DateTime.Now;

          do
            {
                showMenu1();
                menu0 = Console.ReadLine();
                if (!Transaction.validateInput(menu0))
                {
                    Console.WriteLine("Invalid Option Entered.");
                }
                else
                {
                    menu1 = Convert.ToInt32(menu0);
                    switch (menu1)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Enter ATM Card Number: ");
                            cardNo = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter 6 Digit PIN: ");
                            pin = Convert.ToInt32(Console.ReadLine());


                            if (Validation.checkCardNoPassword(cardNo, pin))
                            {

                                do
                                {

                                    showMenu2();
                                    menu0 = Console.ReadLine();
                                    if (!Transaction.validateInput(menu0))
                                    {
                                        Console.WriteLine("Invalid Option Entered. ");
                                    }
                                    else
                                    {
                                        menu2 = Convert.ToInt32(menu0);
                                        switch (menu2)
                                        {
                                            case 1:
                                                Transaction.printNewBalance(latestAccount_bal);
                                                break;
                                            case 2:
                                                Transaction.deposit();
                                                break;
                                            case 3:
                                                Transaction.Withdraw();
                                                break;
                                            case 4:
                                                Console.WriteLine("You have successfully logout. ");
                                                break;
                                            default:
                                                Console.WriteLine("Invalid Option Entered. ");
                                                break;
                                        }
                                    }
                                }
                                while (menu2 != 4);
                            }
                            else
                            {
                                tries++;

                                if (tries >= maxTries)
                                {
                                    Console.WriteLine("Account locked. Please go to the nearest PME Microfinance Bank to rest your PIN.");
                                    Console.WriteLine("Thank you for using PME Microfinance");
                                    System.Environment.Exit(1);
                                }

                                Console.WriteLine("Invalid PIN.");
                            }

                            break;

                        case 2:
                            break;
                        default:
                            Console.WriteLine("Invalid Option Entered");
                            break;
                    }
                }
            }
            while (menu1 != 2);
            Console.WriteLine("Thank you for using PME Microfinance Bank");
        }
    }
}
