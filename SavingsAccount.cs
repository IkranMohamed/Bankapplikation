using System.Security.Cryptography.X509Certificates;

namespace Bankapplikation
{
    public class SavingsAccount : Bankkonto
    {
        public SavingsAccount(string accountUserName, int accountNumber, double balance) : base(accountUserName, accountNumber, balance)
        {
        }
    }

}
