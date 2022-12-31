namespace Drawing;

    public enum Color{ RED, BLACK, WHITE};
public class Shape
{
    protected int Width{get;set;}
    protected Color Color{get;set;}
    public abstract void Draw();

}

