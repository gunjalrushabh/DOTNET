namespace Drawing;

public class Rectangle:Shape
{
     public Point StartPoint { get; set; }

    public Point EndPoint { get; set; }

    public Line(Point startPoint, Point endPoint){
        this.StartPoint=startPoint;
        this.EndPoint=endPoint;
    }

    public override string ToString()
    {
        return (this.StartPoint+" , "+this.EndPoint);
    }
}