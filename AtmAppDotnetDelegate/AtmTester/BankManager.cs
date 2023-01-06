namespace BankManagernamespace;

public delegate void bankside(); 
public class BankManager{

    public void blockAcount()
    {
        Console.WriteLine("inside Block Acocunt");
    }

    public void sendEmail()
    {
Console.WriteLine("Sending an Email...");
    }
    public void SendMessage()
    {
Console.WriteLine("Sending Message;");
    }
}