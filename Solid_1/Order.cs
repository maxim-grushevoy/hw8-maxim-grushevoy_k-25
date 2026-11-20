namespace Solid_1;

// Відповідальність 1: дані та бізнес-логіка замовлення.
//
// Порушено принцип єдиної відповідальності (SRP): початковий клас Order
// одночасно відповідав за
//   1) логіку замовлення (додати/видалити товар, порахувати суму),
//   2) збереження/завантаження (Load, Save, Update, Delete),
//   3) виведення на екран/друк (PrintOrder, ShowOrder).
// Тобто мав три причини для змін. Тепер кожна відповідальність у своєму класі.
public class Order
{
    private readonly List<Item> _itemList = new List<Item>();

    public IReadOnlyList<Item> GetItems()
    {
        return _itemList;
    }

    public int GetItemCount()
    {
        return _itemList.Count;
    }

    public void AddItem(Item item)
    {
        _itemList.Add(item);
    }

    public void DeleteItem(Item item)
    {
        _itemList.Remove(item);
    }

    public decimal CalculateTotalSum()
    {
        return _itemList.Sum(i => i.Price);
    }
}
