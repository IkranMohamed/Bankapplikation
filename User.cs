namespace Bankapplikation
{
    public class User
    {
       public string Name { get; set; }

       public PersonalAccount PersonalAccount { get; set; }

       public SavingsAccount SavingsAccount { get; set; }
       public InvestmentAccount InvestmentAccount { get; set; }


    public User(string name) 
        {
            Name = name;
            PersonalAccount = new PersonalAccount(name, 3, 40000);
            SavingsAccount  = new SavingsAccount(name, 4, 40000);
            InvestmentAccount = new InvestmentAccount(name, 5, 40000);

        }

        public void TransferMoney(double amountToTransfer)
        {
            Console.WriteLine("Select the account to transfer from:");
            Bankkonto fromAccount = VäljEttKonto();

            Console.WriteLine("Select the account to transfer to:");
            Bankkonto toAccount = VäljEttKonto();

            fromAccount.TransferMoney(amountToTransfer, toAccount);

        }
        public Bankkonto VäljEttKonto() 
        {
            Console.WriteLine("Select an account: 3- Personal, 4- Savings, 5- Investment");
            string selectedAccount = Console.ReadLine()!;

            return selectedAccount switch
            {
                "3" => PersonalAccount,
                "4" => SavingsAccount,
                "5" => InvestmentAccount,

            };
            
        }
    }
}


