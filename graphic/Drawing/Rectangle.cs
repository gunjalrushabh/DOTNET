namespace Drawing;

public class Rectangle:Shape,Iprintable{

private Point Startpoint{get;set;}
private Point Endpoint{get;set;}

public Rectangle()
{
    this.Startpoint=new Point(10,10);
    this.Endpoint=new Point(20,20);
}
public Rectangle(Point p1,Point p2)
{
    this.Startpoint=p1;
    this.Endpoint=p2;


}
    public override void Draw()
    {
        Type t= this.GetType();
    Console.WriteLine("( "+this.Startpoint+" )"+" ( "+this.Endpoint+" )"+", "+this.Color+" , "+t.Name);
    }

    public void Print()
    {
        Type t= this.GetType();
        Console.WriteLine("Shape: "+t.Name);
        Console.WriteLine("( "+this.Startpoint+" )"+" ( "+this.Endpoint+" )"+", "+this.Color);
    }
}