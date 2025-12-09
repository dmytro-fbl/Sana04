using ProductTask;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        

        try
        {
            Currency currency1 = new Currency("Долар", 42.3);
            Product product1 = new Product("Крісло", 50, currency1, 20, "КіберТех", 10);
            Product product2 = new Product("Ліжко", 200, currency1, 10, "КіберТех", 40);

            Console.WriteLine($"Ціна товару ({product1.Name}) в грн: {product1.GetPriceInUAH()} грн");
            Console.WriteLine($"Ціна всього товару ({product1.Name}) на складі: {product1.GetTotalPriceInUAH()} грн");
            Console.WriteLine($"Вага всього товару ({product1.Name}) на складі: {product1.GetTotalWeight()} кг");

            Console.WriteLine($"Ціна товару ({product2.Name}) в грн: {product2.GetPriceInUAH()} грн");
            Console.WriteLine($"Ціна всього товару ({product2.Name}) на складі: {product2.GetTotalPriceInUAH()} грн");
            Console.WriteLine($"Вага всього товару ({product2.Name}) на складі: {product2.GetTotalWeight()} кг");
        }
        catch ( Exception ex )
        {
            Console.WriteLine( ex.Message); 
        }
    }
}