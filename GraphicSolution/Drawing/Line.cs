namespace Drawing;
public class Line:Shape
{

    public Point StartPoint { get; set; }

    public Point EndPoint { get; set; }

    public Line(Point startPoint, Point endPoint){
        this.StartPoint=startPoint;
        this.EndPoint=endPoint;
    }

    public override string ToString()
    {
        return ("StartPont : "+this.StartPoint+" EndPoint : "+this.EndPoint);
    }
}