using System.Reflection.Metadata;

namespace Bankapplikation
{
     public class Bankkonto
    {
        public string AccountUserName { get; set; }

        public int AccountNumber { get; set; }

        public double Balance {  get; set; }

       
        //TransaktionHistorik

        ///Constructor

        public Bankkonto(string accountUserName, int accountNumber, double balance) 
        {
            AccountUserName = accountUserName;
            AccountNumber = accountNumber;
            Balance = balance;
        
        
        }
        public void Deposit(int amountToDeposit)
        {
            Balance = Balance + amountToDeposit;
            Console.WriteLine("$ Your Balance is {Balance}");
        }

        public void Draw(int amountToDraw)
        {
            Balance = Balance - amountToDraw;
            Console.WriteLine("$ Your Balance is {Balance}");
        }

        public void CheckBalance()
        {
            Console.WriteLine("$ Your Balance is {Balance}");
        }

        public void TransferMoney(int amountOfMoney)
        {
            throw new NotImplementedException();

        }

        internal Bankkonto VäljEttKonto()
        {
            throw new NotImplementedException();
        }    
        
    }
}
