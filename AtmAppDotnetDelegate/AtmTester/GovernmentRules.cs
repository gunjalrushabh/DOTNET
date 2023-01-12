namespace Governmentnamespace;


public delegate void Tax(); 

public class Government
{
    public void DeductTax()
    {
        Thread primarythread=Thread.CurrentThread;
Console.WriteLine("thread id: "+primarythread.ManagedThreadId);
        Console.WriteLine("10% deduct");
    }
public void DeductProfessionalTax()
{
    Thread primarythread=Thread.CurrentThread;
Console.WriteLine("thread id: "+primarythread.ManagedThreadId);
    Console.WriteLine("15% deduct");
}

public void DeductSalesTax()
{
    Thread primarythread=Thread.CurrentThread;
Console.WriteLine("thread id: "+primarythread.ManagedThreadId);
    Console.WriteLine("25% deduct");
}

}