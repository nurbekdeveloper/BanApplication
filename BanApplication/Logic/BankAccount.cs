namespace BanApplication.Logic
{
    public  class BankAccount
    {
        public int AccountNumber { get; set; }
        public double Balances { get; set; }
        public BankAccount(int accountNumber, double Balance)
        {
            AccountNumber = accountNumber;
            Balances = Balance;
        }
        public void AddMoney(double amount)
        {
            Balances += amount;
            System.Console.WriteLine($"Siz {amount} miqdorda pul qo`shdingiz va yangi balansingiz {Balances}");

        }
        public void GetMoney(double amount)
        {
            if (Balances >= amount)
            {
                Balances -= amount;
                Console.WriteLine($"Siz {amount} miqdorda pul oldingiz  va qolgan  balans {Balances}");
            }
            else
            {
                Console.WriteLine("Siz noto`g`ri balans kiritdingiz ");
            }
        }
        public void GetBalances()
        {
            Console.WriteLine($"Sizning hozirda balansingiz {Balances} ga teng ");
        }




    }
}
