namespace Solid_4;

// Книга: розмір і колір не потрібні, потрібні ціна та знижки
public class Book : IPriced, IDiscountable
{
    public double Price { get; private set; }
    public string Discount { get; private set; }

    public void SetPrice(double price)
    {
        Price = price;
    }

    public void ApplyDiscount(string discount)
    {
        Discount = discount;
    }

    public override string ToString()
    {
        return "Книга: ціна " + Price + ", знижка " + Discount;
    }
}
