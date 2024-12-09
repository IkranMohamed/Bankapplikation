namespace Bankapplikation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bankkonto ikran = new Bankkonto("Ikrans konto", 4, 40000);

 
            bool programIsRunning = true;
            while (programIsRunning)
            {
                PrintOutFirstMeny();
                Console.WriteLine("Välj ett alternativ 3 eller 4");
                string valdAlternativ = Console.ReadLine()!;

                bool running = true;

                switch (valdAlternativ)
                {
                    case "1":

                        int amountOfMoney = HandleMoneyInput();

                        ikran.TransferMoney(amountOfMoney);

                        break;
                    case "3":
                        while (running)
                        {
                            Bankkonto valdKonto = ikran.VäljEttKonto();
                            PrintOutAccountMeny();
                            string kontotAlternativ = Console.ReadLine()!;


                            switch (kontotAlternativ)
                            {

                                case "1":
                                    valdKonto.CheckBalance();
                                    break;
                                case "2":
                                    int amountOfMoneyToDraw = HandleMoneyInput();
                                    valdKonto.Draw(amountOfMoneyToDraw);
                                    break;

                                case "3":
                                    int amountOfMoneyToDeposit = HandleMoneyInput();
                                    valdKonto.Deposit(amountOfMoneyToDeposit);
                                    break;
                                default:
                                    running = false;
                                    break;
                            }
                        } 
                       break;
                    case "4":
                        programIsRunning = false;
                        break;
                    default:
                        Console.WriteLine("Något verkar vara fel, var vänlig och försök igen!");
                        break;
                }

            }

        }

        private static int HandleMoneyInput()
        {
            Console.WriteLine("Hur mycket pengar vill du överföra?");
            int amountOfMoney = Convert.ToInt32(Console.ReadLine());
            return amountOfMoney;
        }

        private static void PrintOutAccountMeny()
        {
            Console.WriteLine("Du kan nu :");
            Console.WriteLine("1- Check Balance");
            Console.WriteLine("2- Draw");
            Console.WriteLine("3- Deposit");

            Console.WriteLine("Välj ett alternativ");
        }

        private static void PrintOutFirstMeny()
        {
            Console.WriteLine("Välkomen till mitt bankkonto");
            Console.WriteLine("3-- Överför pengar");
            Console.WriteLine("4-- Exit");
        }
    }
}
