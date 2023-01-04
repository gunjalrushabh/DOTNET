namespace EGovernment;

public delegate void GeneratTaxOperation();

public class CentralGovernment
{
    public void Incometax()
    {
        Console.WriteLine("15% deduction");
    }
 public void Professionaltax()
    {
        Console.WriteLine("25% deduction");
    }

 public void ServiceTax()
    {
        Console.WriteLine("35% deduction");
    }


}
