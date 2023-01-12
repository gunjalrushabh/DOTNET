using Drawing;
using System.Collections.Generic;
// See https://aka.ms/new-console-template for more information
 Console.WriteLine("Hello, World!");

Point p1=new Point(10,15);
Point p2=new Point(50,30);
Point p3=new Point(60,30);
Point p4=new Point(6,3);

Shape sobj1=new Rectangle(p3,p4);
Shape sobj=new Line(p1,p2);
Shape obj=new Circle(p1,45);

List<Shape> shapes=new List<Shape>();
shapes.Add(obj);
shapes.Add(sobj1);
shapes.Add(sobj);
foreach(Shape s in shapes)
{
    s.Draw();
    Iprintable iobj=(Iprintable)s;
    iobj.Print();
}
