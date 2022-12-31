namespace Drawing ;

public enum Color{RED,WHITE,BLACK}
public  abstract class Shape
{
  protected int Width{get;set;}
    protected Color Color{get;set;}

    public abstract void Draw();

}