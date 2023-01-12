using BankAccountnamespace;
using Governmentnamespace;
using BankManagernamespace;
using System.Threading;

Thread primarythread=Thread.CurrentThread;
Console.WriteLine("thread id: "+primarythread.ManagedThreadId);
BankAccount bobj=new BankAccount();
Government gobj=new Government();
BankManager bbobj=new BankManager();

Tax delegateobj=new Tax(gobj.DeductProfessionalTax);
bankside delegate2=new bankside(bbobj.SendMessage);

bobj.overbalance+=delegateobj;
bobj.underbalce+=delegate2;

bobj.DepositeMoney(500000);
Console.WriteLine(bobj);

bobj.WithDrawMoney(90000);
Console.WriteLine(bobj);