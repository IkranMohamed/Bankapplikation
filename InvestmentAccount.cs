namespace Bankapplikation
{
    internal class InvestmentAccount : Bankkonto
    {
        public InvestmentAccount(string accountUserName, int accountNumber, double balance) : base(accountUserName, accountNumber, balance)
        {
        }
    }
}
