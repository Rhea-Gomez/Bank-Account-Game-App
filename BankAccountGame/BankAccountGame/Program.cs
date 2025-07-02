namespace BankAccountGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int round = 1;
            BankAccount bankaccount1 = new BankAccount("Rhea", 5000);
            BankAccount bankaccount2 = new BankAccount("Sanjana", 7000);

            do
            {
                Console.WriteLine("Round: " + round);
                Console.Write("Account1 Withdraw or Deposit (w/d): ");
                string choice = Console.ReadLine();
                if (choice == "w" || choice == "W")
                {
                    Console.Write("Amount to Withdraw: ");
                    double amount = double.Parse(Console.ReadLine());
                    bankaccount1.WithDraw(amount);
                }
                else if (choice == "d" || choice == "D")
                {
                    Console.Write("Amount to Deposit: ");
                    double amount = double.Parse(Console.ReadLine());
                    bankaccount1.Deposit(amount);
                }

                Console.Write("Account2 Withdraw or Deposit (w/d): ");
                choice = Console.ReadLine();
                if (choice == "w" || choice == "W")
                {
                    Console.Write("Amount to Withdraw: ");
                    double amount = double.Parse(Console.ReadLine());
                    bankaccount2.WithDraw(amount);
                }
                else if (choice == "d" || choice == "D")
                {
                    Console.Write("Amount to Deposit: ");
                    double amount = double.Parse(Console.ReadLine());
                    bankaccount2.Deposit(amount);
                }
                round++;
            } while (round != 4);

            if(bankaccount1.Balance >  bankaccount2.Balance)
            {
                Console.WriteLine($"Congratulations {bankaccount1.AccountHolder} won the game!");
                Console.WriteLine("Total Balance: " + bankaccount1.Balance);
            }
            else
            {
                Console.WriteLine($"Congratulations {bankaccount2.AccountHolder} won the game!");
                Console.WriteLine("Total Balance: " + bankaccount2.Balance);
            }
        }
    }
}
