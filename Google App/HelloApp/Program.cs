using HR;
using System.Collections.Generic;


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var emp = new { Id=22 , Name="Hrithik" };


List<Employee> emplist=new List<Employee>();
emplist.Add(new Employee (){ Empid=10,Name="Rushabh",MobileNo="987654321"});
emplist.Add(new Employee (){ Empid=10,Name="Nachiket",MobileNo="98554321"});
emplist.Add(new Employee (){ Empid=10,Name="Akshay",MobileNo="98754321"});
emplist.Add(new Employee (){ Empid=10,Name="Nilesh",MobileNo="98354321"});


app.MapGet("/", () => "Hello World!");
app.MapGet("/api/home",()=>emplist); // o/p: {"id":22,"name":"Hrithik"}


app.Run();
