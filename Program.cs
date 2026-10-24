using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._2._3BankSoloTask
{
    internal class Program
    {
        static void Main()
        {
            Account account = new Account();

            account.putMoney(500);
            account.Mes();

            Console.WriteLine();

            account.getMoney(700);
            account.Mes();

            Console.WriteLine();

            account.putMoney(0);
            account.Mes();
        }
      
     
  
    }
}
