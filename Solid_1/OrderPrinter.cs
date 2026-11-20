namespace Solid_1;

// Відповідальність 3: відображення та друк замовлення
public class OrderPrinter
{
    public void Print(Order order)
    {
        Console.WriteLine("=== Замовлення ===");

        foreach (Item item in order.GetItems())
        {
            Console.WriteLine("{0,-15} {1,8:F2}", item.Name, item.Price);
        }

        Console.WriteLine("Разом: {0:F2}", order.CalculateTotalSum());
    }

    public void Show(Order order)
    {
        Console.WriteLine("Товарів у замовленні: {0}, на суму {1:F2}",
            order.GetItemCount(), order.CalculateTotalSum());
    }
}
