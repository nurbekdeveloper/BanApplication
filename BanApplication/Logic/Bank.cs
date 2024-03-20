using BanApplication.Models;

namespace BanApplication.Logic
{
    public class Bank
    {

        private List<Customer> customers = new List<Customer>();
        public void OpenAccount(Customer customer)
        {
            customers.Add(customer);
            Console.WriteLine($"{customer.Name} uchun yangi hisob ochildi.");
        }

        public void CloseAccount(Customer customer)
        {
            customers.Remove(customer);
            Console.WriteLine($"{customer.Name}ning hisobi yopildi.");
        }

        public void Transfer(Customer sender, Customer receiver, double amount)
        {
            if (sender.Account.Balances >= amount)
            {
                sender.Account.GetMoney(amount);
                receiver.Account.AddMoney(amount);
                Console.WriteLine($"{sender.Name}ning hisobidan {receiver.Name}ning hisobiga {amount} sum pul o'tkazildi.");
            }
            else
            {
                Console.WriteLine("Noto'g'ri amal! Balans yetarli emas.");
            }
        }
    }
}
