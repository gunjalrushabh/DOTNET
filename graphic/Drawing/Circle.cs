namespace Drawing;
public class Circle:Shape{

private Point Center{get;set;}
private int Radii{get;set;}

public Circle()
{
    this.Center=new Point(0,0);
    this.Radii=1;
}
public Circle(Point p,int r)
{
    this.Center=p;
    this.Radii=r;

}
    public override void Draw()
    {
        Console.WriteLine("( "+this.Center+" )"+"Radius: " +this.Radii+"   ," +this.Color);
        Type t=this.GetType();
        Console.WriteLine("Shape is : "+t);
    }
}