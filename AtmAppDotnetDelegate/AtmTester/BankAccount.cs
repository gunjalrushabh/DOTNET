namespace BankAccountnamespace;
using Governmentnamespace;
using BankManagernamespace;


public class BankAccount
   {
    public event bankside underbalce;
    public event Tax overbalance;

    public double Balance{get;set;}

 public BankAccount()
    { 
      this.Balance=5000;
    }
    public BankAccount(double amt)
    { 
      this.Balance=amt;
    }
    public void DepositeMoney(double amount)
    {
        if(this.Balance>250000 || this.Balance+amount>=250000)
        {
            this.Balance+=amount;
            overbalance();
        }
        else
        {
            this.Balance+=amount;
        }
        
    }

    public void WithDrawMoney(double amount)
    {
        if(this.Balance<=5000  || this.Balance-amount<=5000)
        {
            underbalce();
            return;
        }
        else{
            this.Balance-=amount;
        }
    }

  public override string ToString()
    {
        return base.ToString() + "Current Balance ="+ this.Balance;
    }
       }