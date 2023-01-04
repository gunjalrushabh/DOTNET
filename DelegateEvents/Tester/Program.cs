using EGovernment;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


CentralGovernment cobj =new CentralGovernment();

GeneratTaxOperation deleobj= new GeneratTaxOperation(cobj.Incometax);
GeneratTaxOperation deleobj1=new GeneratTaxOperation(cobj.Professionaltax);
GeneratTaxOperation deleobj2=new GeneratTaxOperation(cobj.ServiceTax);


deleobj();
deleobj1();
deleobj2();

