using System.Globalization;

namespace Solid_1;

// Відповідальність 2: збереження та завантаження замовлення
public class OrderRepository
{
    public void Save(Order order, string path)
    {
        var lines = order.GetItems()
            .Select(i => i.Name + ";" + i.Price.ToString(CultureInfo.InvariantCulture));
        File.WriteAllLines(path, lines);
    }

    public Order Load(string path)
    {
        var order = new Order();

        foreach (string line in File.ReadAllLines(path))
        {
            string[] parts = line.Split(';');
            order.AddItem(new Item(parts[0], decimal.Parse(parts[1], CultureInfo.InvariantCulture)));
        }

        return order;
    }

    public void Update(Order order, string path)
    {
        Save(order, path);
    }

    public void Delete(string path)
    {
        if (File.Exists(path))
        {
            File.Delete(path);
        }
    }
}
