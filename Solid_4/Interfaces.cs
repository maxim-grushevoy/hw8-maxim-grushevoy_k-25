namespace Solid_4;

// Порушено принцип розділення інтерфейсу (ISP): початковий IItem містив
// ApplyDiscount, ApplyPromocode, SetColor, SetSize, SetPrice. Клас "Книга" не
// має кольору й розміру, але був би змушений реалізовувати ці методи.
//
// Виправлення: інтерфейс розбито на малі, кожен клас бере лише потрібні.

public interface IPriced
{
    void SetPrice(double price);
}

public interface IDiscountable
{
    void ApplyDiscount(string discount);
}

public interface IPromocodable
{
    void ApplyPromocode(string promocode);
}

public interface IColorable
{
    void SetColor(byte color);
}

public interface ISizable
{
    void SetSize(byte size);
}
