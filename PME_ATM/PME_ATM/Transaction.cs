using System;
using System.Collections.Generic;
using System.Text;



namespace PME_ATM
{
    public class Transaction
    {
        private static readonly string cur;

        //Method to print avaliable balance
        public static void printNewBalance(double newBalance)
        {
            Console.WriteLine("Balance is: NG " + newBalance.ToString("N"));
            Console.WriteLine();
        }

        //Method to validate user menu selection
        public static bool validateInput(string input)
        {
            bool passValidation = false;
            int myInt = 0;
            if (!string.IsNullOrWhiteSpace(input))
            {
                if (int.TryParse(input, out myInt))
                    passValidation = true;
            }
            return passValidation;

        }

        //Method to handle deposit
        public static void deposit()
        {
            double deposit_amt = 0;
            Console.Write("Enter your deposit amount: " + cur);
            deposit_amt = Convert.ToDouble(Console.ReadLine());

            if (deposit_amt > 0)
            {
                Program.latestAccount_bal = Program.latestAccount_bal + deposit_amt;

                Console.WriteLine("You have successfully deposited " + cur + deposit_amt);
                printNewBalance(Program.latestAccount_bal);
            }
            else
            {
                Console.WriteLine("Invalid deposit amount. Try again");
            }
        }

        //Method to withdraw
        public static void Withdraw()
        {
            double withdraw_amt = 0;
            double minimum_kept_amt = 20;

            Console.Write("Enter your withdraw amount: " + cur);
            withdraw_amt = Convert.ToDouble(Console.ReadLine());

            if (withdraw_amt > 0)
            {
                if (withdraw_amt > Program.latestAccount_bal)
                {
                    Console.WriteLine("Withdrawal failed. You do not have enough fund to withdraw " + cur + withdraw_amt);
                }
                else if ((Program.latestAccount_bal - withdraw_amt) < minimum_kept_amt)
                {
                    Console.WriteLine("Withdrawal failed. Your account needs to have minimum " + cur + minimum_kept_amt);
                }
                else
                {
                    Program.latestAccount_bal = Program.latestAccount_bal - withdraw_amt;
                    Console.WriteLine("Please collect your money. You have successfully withdraw " + cur + withdraw_amt);
                    Console.WriteLine("Please collect your receipt");
                    printNewBalance(Program.latestAccount_bal);
                }
            }
            else
            {
                Console.WriteLine("Invalid withdraw amoun. Try again. (above zero)" + cur);
            }
        }

        internal static void printNewBalance()
        {
            throw new NotImplementedException();
        }
    }
}
