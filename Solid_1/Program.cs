using System.Text;

namespace Solid_1;

internal class Program
{
    private static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Order order = new Order();
        Item book = new Item("Книга", 250m);
        order.AddItem(book);
        order.AddItem(new Item("Ручка", 15.5m));
        order.AddItem(new Item("Зошит", 30m));

        OrderPrinter printer = new OrderPrinter();
        printer.Print(order);
        printer.Show(order);

        order.DeleteItem(book);
        Console.WriteLine("Після видалення книги:");
        printer.Show(order);

        OrderRepository repository = new OrderRepository();
        string path = Path.Combine(Path.GetTempPath(), "solid_order.txt");

        repository.Save(order, path);
        Order loaded = repository.Load(path);
        Console.WriteLine("Завантажено з файлу:");
        printer.Show(loaded);

        repository.Delete(path);

        Console.ReadKey();
    }
}
