namespace Drawing;
public class Circle:Shape
{
    public Point Center { get; set; }
    public int Radius { get; set; }

    public Circle(Point center, int radius)
    {
        this.Center = center;
        this.Radius = radius;
    }

    public override string ToString()
    {
        return ("Center of Circle :"+this.Center+" Radius of Circle : "+this.Radius);
    }
}