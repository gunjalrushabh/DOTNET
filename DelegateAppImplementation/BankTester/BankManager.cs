namespace BankManagerNameSpace;

public delegate void BankOperations();
public class BankManager{
 
 public BankManager(){}
    public void BlockAccout(){
        Console.WriteLine("Block Account");
    }
      public void SendMessge(){
        Console.WriteLine("Send Messege");
    }
      public void SendMail(){
        Console.WriteLine("Send Mail");
    }
}
