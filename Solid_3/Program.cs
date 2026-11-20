namespace Solid_3;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        // Було (порушення LSP)
        BadRectangle rect = new BadSquare();
        rect.Width = 5;
        rect.Height = 10;
        Console.WriteLine("Було: очікували 50, отримали " + rect.GetRectangleArea());

        // Стало
        Console.WriteLine("Стало:");
        Shape[] shapes =
        {
            new Rectangle(5, 10),
            new Square(10)
        };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine("{0}: площа {1}", shape.GetType().Name, shape.GetArea());
        }

        Console.ReadKey();
    }
}
