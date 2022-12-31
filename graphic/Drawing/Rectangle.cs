namespace Drawing;

public class Rectangle:Shape{

private Point Startpoint{get;set;}
private Point Endpoint{get;set;}

public Rectangle()
{
    this.Startpoint=new Point(10,10);
    this.Endpoint=new Point(20,20);
}

    public override void Draw()
    {
        throw new NotImplementedException();
    }
}