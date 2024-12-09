namespace Bankapplikation
{
    public class User
    {
        public string Name { get; set; }

        PersonalAccount PersonalAccount { get; set; }

        SavingsAccount SavingsAccount { get; set; }
        InvestmentAccount InvestmentAccount { get; set; }
    

        public User(string name) 
        {
            Name = name;
            PersonalAccount = new PersonalAccount(name, 3, 40000);
            SavingsAccount  = new SavingsAccount(name, 4, 40000);
            InvestmentAccount = new InvestmentAccount(name, 5, 40000);

        }

        public void TransferMoney(int amountToTransfer)
        {
            Console.WriteLine("Konto från att skicka pengar till");
            Bankkonto bankKontoFrån = VäljEttKonto();
            bankKontoFrån.Draw(amountToTransfer);

            Console.WriteLine("Konto från att skicka pengar till");
            Bankkonto bankKontoTill = VäljEttKonto();
            bankKontoFrån.Deposit(amountToTransfer);

        }
        public Bankkonto VäljEttKonto() 
        {
            Console.WriteLine("Var god och välj ett konto");
            Console.WriteLine("3- Personal, 4- Savings, 5-Investment");
            string valdKonto = Console.ReadLine()!;

            switch (valdKonto) 
            {
                case "3":
                    return PersonalAccount;
                case "4":
                    return SavingsAccount;
                case "5": 
                    return InvestmentAccount;
                default:
                    Console.WriteLine("Inget tillgängligt konto");
                    return null;
            
            }
        }
    }

}
