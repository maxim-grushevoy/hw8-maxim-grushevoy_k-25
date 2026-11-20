namespace Solid_3;

// Виправлення: квадрат не є підтипом прямокутника за поведінкою,
// тому обидві фігури успадковуються від спільної абстракції Shape.
public abstract class Shape
{
    public abstract int GetArea();
}

public class Rectangle : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public override int GetArea()
    {
        return Width * Height;
    }
}

public class Square : Shape
{
    public int Side { get; set; }

    public Square(int side)
    {
        Side = side;
    }

    public override int GetArea()
    {
        return Side * Side;
    }
}
