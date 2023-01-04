namespace Accounts;
using Banktester;
using BankManagerNameSpace;
public class Bank
{
    public event TaxOperation overbalance;
    public event BankOperations underBalance;
    public double Balance { get; set; }

    public Bank(double amount) //initial balance
    {
        this.Balance = amount;
    }
    public void Depoist(double amount)
    {
        if (Balance >= 250000)
        {
             this.Balance += amount;
            overbalance(this.Balance);
        }
        else
        {
            this.Balance += amount;
            Console.WriteLine("Money DEposited Successfully....");
        }
    }
    public void WithDrawal(double amount)
    {
        if ((this.Balance - amount) <= 5000 || this.Balance < 5000)
        {
              
            underBalance();
            return;
        }
        else
        {
            this.Balance -= amount;
            Console.WriteLine("Money WithDrawal Successfully....");
            }
    }
    public override string ToString()
    {
        return base.ToString() + "  Balance" + this.Balance;
    }


}