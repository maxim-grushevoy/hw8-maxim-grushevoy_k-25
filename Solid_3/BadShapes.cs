namespace Solid_3;

// Початковий код, який ПОРУШУЄ принцип підстановки Лісков (LSP).
// Залишено для демонстрації проблеми.
//
// Код, що працює з Rectangle, очікує: після Width = 5 і Height = 10
// площа буде 50. Але Square у сеттерах змінює обидві сторони, тому
// отримуємо 100. Нащадок не можна підставити замість предка без зміни поведінки.
public class BadRectangle
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }

    public int GetRectangleArea()
    {
        return Width * Height;
    }
}

// Квадрат наслідується від прямокутника
public class BadSquare : BadRectangle
{
    public override int Width
    {
        get { return base.Width; }
        set
        {
            base.Height = value;
            base.Width = value;
        }
    }

    public override int Height
    {
        get { return base.Height; }
        set
        {
            base.Height = value;
            base.Width = value;
        }
    }
}
