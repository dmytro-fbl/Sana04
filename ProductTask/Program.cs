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


            Console.WriteLine("Завдання2");
            MyDate dateStart = new MyDate(2025, 12, 08, 12, 12);
            MyDate dateFinish = new MyDate(2025, 12, 08, 20, 12);
            Airplane booking1 = new Airplane("Київ", "Житомир", dateStart, dateFinish);
            Console.WriteLine($"Кількість хвилин: {booking1.GetTotalTime()} хв");
            Console.WriteLine($"Відправлення і прибуття в один день: {booking1.IsArrivingToday()}");
        }
        catch ( Exception ex )
        {
            Console.WriteLine( ex.Message); 
        }
    }
}