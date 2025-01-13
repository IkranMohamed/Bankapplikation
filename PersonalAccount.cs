﻿namespace Bankapplikation
{

    public class PersonalAccount : Bankkonto
    {
        public string AccountHolderName;
        public int AccountNumber;
        public int Balance;

        public PersonalAccount(string accountUserName, int accountNumber, double balance) : base(accountUserName, accountNumber, balance)
        {
        }





        public class Bankkonto
        {
            public string AccountHolderName;
            public int AccountNumber;
            public int Balance;

        }

            public int CheckBalance() 
        {
         return this.Balance;
        }

        public void Draw(int pengar) 
        {
         this.Balance = this.Balance - pengar;
        }

        public void Deposit(int pengar) 
        {
         this.Balance = this.Balance + pengar;
        }
    }

} 