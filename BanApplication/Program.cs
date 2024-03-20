using BanApplication.Logic;
using BanApplication.Models;

namespace BanApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            Console.WriteLine("Assalomu alaykum ");
            Console.WriteLine("AccountNumber ni kiriting ");
            int AccountNumber= Convert.ToInt32(Console.ReadLine());      
            Console.WriteLine("Customer ismini kiriting ");
            string Name = Console.ReadLine();
            Console.WriteLine("Balance  kiriting ");
            double balans = Convert.ToDouble(Console.ReadLine());   

            // Mijozlar va ularning hisoblari
            BankAccount account1 = new BankAccount(AccountNumber, balans);
            BankAccount account2 = new BankAccount(AccountNumber, balans);
            Customer customer1 = new Customer(Name, account1);
            Customer customer2 = new Customer(Name, account2);

            // Hisob ochish
            bank.OpenAccount(customer1);
            bank.OpenAccount(customer2);

            // Pul o'tkazish
            bank.Transfer(customer1, customer2, 200);

            // Hisob balansini ko'rsatish
            customer1.Account.GetBalances();
            customer2.Account.GetBalances();

            Console.ReadLine();
        }



    }
}
