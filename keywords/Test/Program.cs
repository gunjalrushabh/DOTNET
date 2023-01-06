using useconst;
using personal;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var obj=new Sample(10,50);
Console.WriteLine(obj.x+"  "+obj.y+"  "+Sample.c1+" "+Sample.c2);
Console.WriteLine($"x: {obj.x},y: {obj.y}");
Console.WriteLine($"const c1: {Sample.c1}, const c2: {Sample.c2}");
var obj1=new personal();
Console.WriteLine(obj1);
