namespace Solid_4;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Book book = new Book();
        book.SetPrice(250);
        book.ApplyDiscount("10%");
        Console.WriteLine(book);

        OuterWear jacket = new OuterWear();
        jacket.SetPrice(2500);
        jacket.ApplyDiscount("15%");
        jacket.SetColor(3);
        jacket.SetSize(48);
        Console.WriteLine(jacket);

        Console.ReadKey();
    }
}
