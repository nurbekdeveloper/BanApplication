using BanApplication.Logic;

namespace BanApplication.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public BankAccount Account { get; set; }

        public Customer(string name, BankAccount account)
        {
            Name = name;
            Account = account;
        }
    }
}
