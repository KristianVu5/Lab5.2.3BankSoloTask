using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._2._3BankSoloTask
{
     class Account
    {
        private int debit = 0;
        private int credit = 0;
        private int balance = 0;
        private int sum = 0;
        private int result = 0;


        public Account()
        {
       
        }

        public void putMoney(int amount)
        {
            sum = amount;
            debit = 0;
            credit = 0;

            if(amount > 0)
            {
                credit = amount;
                balance += credit;
                result = 1;
            }
            else
            {
                result = -1;
            }
            
        }

        public void getMoney(int amount)
        {
            sum = amount;
            credit = 0;
            debit = 0;

            if(amount > 0 && amount <= balance)
            {
                debit = amount;
                balance -= debit;
                result = 2;
            }
            else
            {
                result = -1;
            }
        }


        public void Mes()
        {
            Console.WriteLine("Operation amount: " + sum);
            Console.WriteLine("Balance " + balance);

            if (result == 1)
                Console.WriteLine("Status: Succsessful deposit");
            else if (result == 2)
                Console.WriteLine("Status: Succsessful withdraw");
            else if (result == -1 && sum <= 0)
                Console.WriteLine("Status: Failed deposit (amount must be greater than 0)");
            else if (result == -1)
                Console.WriteLine("Status: Failed withdrawal (invalid amount or insufficient balance)");
            else
                Console.WriteLine("Status: No operation performed");

        }
    }
}
