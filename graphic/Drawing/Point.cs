namespace Drawing;
public struct Point
{
private int X{get;set;}
private int Y{get;set;}

public Point(int x,int y)
{
    this.X=x;
    this.Y=y;
}
    public override string ToString()
    {
        return "( "+this.X+" , "+this.Y+" )";
    }
}
