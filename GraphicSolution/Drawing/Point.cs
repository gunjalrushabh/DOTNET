namespace Drawing;
public struct Point:Shape
{
 public int X{get;set;}
 public int Y{get;set;}

 public Point()
 {
    this.X=0;
    this.Y=0;
 }

 public  Point(int x,int y)
 {
    this.X=x;
    this.Y=y;
 }
    public override string ToString()
    {
        return "( "+this.X+","+this.Y+" )";
    }

}
