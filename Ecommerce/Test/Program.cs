using Membership;
using HR;
Console.WriteLine("enter email");
string email=Console.ReadLine();
Console.WriteLine("enter password");
string password=Console.ReadLine();

if(Authentication.Validation(email,password)){
    Console.WriteLine("Welcome to Mohra");
    Console.WriteLine("Thanks for visiting Mohra Vehicles");
    Console.WriteLine("Enter your details...");
    Authentication.Registration(Console.ReadLine(),Console.ReadLine(),Console.ReadLine(),Console.ReadLine(),Console.ReadLine());

Employee emp=new SalesEmployee();
emp.DoWork();
Console.WriteLine(emp);
double salary=emp.ComputSalary();
    Console.WriteLine("Salary = "+ salary);
}
else{
    Console.WriteLine("Invalid user");
}


