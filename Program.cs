namespace Bankapplikation
{
    internal class Program
    {
        private static double amountToDeposit;

        static void Main(string[] args)
        {
            //Bankkonto ikran = new Bankkonto("Ikrans konto", 4, 40000);
            User ikran = new User("Ikran");

            bool programIsRunning = true;
            while (programIsRunning)
            {
                PrintOutFirstMeny();
                string selectedOption = Console.ReadLine()!;
                // Console.WriteLine("Välj ett alternativ 3 eller 4");
                //  string valdAlternativ = Console.ReadLine()!;

                // bool running = true;

                switch (selectedOption)
                {
                    case "1":

                        double amountToTransfer = HandleMoneyInput();
                        ikran.TransferMoney(amountToTransfer);
                        break;

                    case "3":
                        Bankkonto selectedAccount = ikran.PersonalAccount; // Default to Personal Account
                        PrintOutAccountMeny();
                        string accountOption = Console.ReadLine()!;


                        switch (accountOption)
                        {

                                case "1":
                                selectedAccount.CheckBalance();
                                break;

                                case "2":
                                double amountToDraw = HandleMoneyInput();
                                selectedAccount.Draw(amountToDraw);
                                break;
               
                                case "3":
                                    double amountOfMoneyToDeposit = HandleMoneyInput();
                                    selectedAccount.Deposit(amountToDeposit);
                                break;
                            default:

                                    break;
                            }


                       break;
                    case "4":
                        programIsRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again."); 
                        break;
                }

            }

        }

        private static double HandleMoneyInput()
        {
            Console.WriteLine("Enter the amount of money:");
            return Convert.ToDouble(Console.ReadLine());

        }

        private static void PrintOutAccountMeny()
        {
            Console.WriteLine("You can now:");
            Console.WriteLine("1- Check Balance");
            Console.WriteLine("2- Draw");
            Console.WriteLine("3- Deposit");

            Console.WriteLine("Select an option:");
        }

        private static void PrintOutFirstMeny()
        {
            Console.WriteLine("Welcome to the bank system");
            Console.WriteLine("1- Transfer Money");
            Console.WriteLine("3- Manage Account");
            Console.WriteLine("4- Exit");
        }
    }
}
