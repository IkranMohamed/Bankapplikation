using System.Reflection.Metadata;

namespace Bankapplikation
{
     public class Bankkonto
    {
        public string AccountUserName { get; set; }

        public int AccountNumber { get; set; }

        public double Balance {  get; set; }




        ///Constructor

        public Bankkonto(string accountUserName, int accountNumber, double balance) 
        {
            AccountUserName = accountUserName;
            AccountNumber = accountNumber;
            Balance = balance;
        
        
        }
        public void Deposit(double amountToDeposit)
        {
            Balance += amountToDeposit;
            Console.WriteLine($"Your Balance is {Balance:C}");
        }

        public void Draw(double amountToDraw)
        {
            if (amountToDraw > Balance) 
            {

                Console.WriteLine("Insufficient funds.");

            }
            else 
            {
                Balance -= amountToDraw;
                Console.WriteLine($"Your Balance is {Balance:C}");
            }
        }

        public void CheckBalance()
        {
            Console.WriteLine($"Your Balance is {Balance:C}");
        }

        public void TransferMoney(double amount, Bankkonto toAccount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds.");
            }
            else 
            {
                this.Draw(amount); // Withdraw from the current account
                toAccount.Deposit(amount); // Deposit to the target account
                Console.WriteLine($"Transferred {amount:C} to {toAccount.AccountUserName}'s account.");
            }

        }

        public Bankkonto VäljEttKonto()
        {
            return this; // In a real case scenario, this could allow the user to choose between multiple accounts
        }

        internal void Deposit(object amountToDeposit)
        {
            throw new NotImplementedException();
        }
    }

}
