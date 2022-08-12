using System;
using System.Collections.Generic;
using System.Globalization;
using static PME_ATM.Program;


namespace PME_ATM
{
    class Program
    {       
        //Getting and assigning a value the following variables
        public static String cur = "NG ";
        public static double latestAccount_bal = 5000;
        public int cardNo { get; set; }
        public int pwd { get; set; }
        public string Name { get; set; }
      
        static void Main(string[] args)
        {
            Models.mainOperation();
        }

       

    }

    
}
