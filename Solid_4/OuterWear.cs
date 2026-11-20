namespace Solid_4;

// Верхній одяг: колір, розмір, ціна, знижка
public class OuterWear : IPriced, IDiscountable, IColorable, ISizable
{
    public double Price { get; private set; }
    public string Discount { get; private set; }
    public byte Color { get; private set; }
    public byte Size { get; private set; }

    public void SetPrice(double price)
    {
        Price = price;
    }

    public void ApplyDiscount(string discount)
    {
        Discount = discount;
    }

    public void SetColor(byte color)
    {
        Color = color;
    }

    public void SetSize(byte size)
    {
        Size = size;
    }

    public override string ToString()
    {
        return "Верхній одяг: ціна " + Price + ", знижка " + Discount
            + ", колір " + Color + ", розмір " + Size;
    }
}
