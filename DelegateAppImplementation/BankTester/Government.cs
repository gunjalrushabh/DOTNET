namespace Banktester;

public delegate void TaxOperation(double amount);
public class Government{

    public void Deduction(double amount){
        Console.WriteLine("15% deductions from your salary");
    }
    public  void IncomeTax (double amount){
        Console.WriteLine("20% tax for your slab");
    }

    public void PersonalTax(double amount){
        Console.WriteLine("30% tax form salary");
    } 
}