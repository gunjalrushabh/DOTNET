using Banktester;
using Accounts;
using BankManagerNameSpace;



Government govobj = new Government();
BankManager bankMangOb = new BankManager();

TaxOperation deeleobj1 = new TaxOperation(govobj.Deduction);
TaxOperation deeleobj2 = new TaxOperation(govobj.IncomeTax);
TaxOperation deeleobj3 = new TaxOperation(govobj.PersonalTax);

BankOperations bops = new BankOperations(bankMangOb.BlockAccout);
BankOperations bops1 = new BankOperations(bankMangOb.SendMail);
BankOperations bops2 = new BankOperations(bankMangOb.SendMessge);


Bank bobj = new Bank(5000);

//multicasting Delegations
bobj.overbalance += deeleobj1;
bobj.overbalance += deeleobj2;
bobj.overbalance += deeleobj3;


//multicasting Delegations
bobj.underBalance += bops;
bobj.underBalance += bops1;
bobj.underBalance += bops2;

bool exit = false;
Console.WriteLine(".....................WELCOME TO RUSHABH's ATM SERVICE.....................");

while (!exit)
{

    Console.WriteLine("[1].Deposite Amount [2].WithDraw Amount [3].Show Balance [4].Exit");
    switch (int.Parse(Console.ReadLine()))
    {
        case 1:
        Console.WriteLine("Enter Amount to be Deposited");
            bobj.Depoist(double.Parse(Console.ReadLine()));
            break;
        case 2:
        Console.WriteLine("Enter amount to be WithDrawl");
            bobj.WithDrawal(double.Parse(Console.ReadLine()));
            break;
        case 3:
        Console.WriteLine("Your Current Balance is: ");
            Console.WriteLine(bobj);
            break;
        case 4:
            exit = true;
            Console.WriteLine("........Thank you.........");
            break;

    }

}




