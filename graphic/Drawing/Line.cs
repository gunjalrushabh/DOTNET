namespace Drawing;
public class Line:Shape,Iprintable{

private Point Startpoint{get;set;}
private Point Endpoint{get;set;}

public Line()
{
   this.Startpoint=new Point(0,0);
   this.Endpoint=new Point(10,10);
}
public Line(Point p1,Point p2)
{
    this.Startpoint=p1;
    this.Endpoint=p2;

}
    public override void Draw()
    {
        Color c=(Color)2;
        //this.Color=BLACK
       Console.WriteLine("("+this.Startpoint+" ,"+this.Endpoint+" )"+c);
        Type t=this.GetType();
        Console.WriteLine("Shape is : "+t.Name);
    }

    public void Print()
    {
        Type t= this.GetType();
        Console.WriteLine("Shape: "+t.Name);
         Console.WriteLine("("+this.Startpoint+" ,"+this.Endpoint+" )"+this.Color);
    }
}