using AirplaneTask;

public class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        try
        {
            MyDate dateStart = new MyDate(2025, 12, 08, 12, 12);
            MyDate dateFinish = new MyDate(2025, 12, 08, 20, 12);
            Airplane booking1 = new Airplane("Київ", "Житомир", dateStart, dateFinish);
            Console.WriteLine($"Кількість хвилин: {booking1.GetTotalTime()} хв");
            Console.WriteLine($"Відправлення і прибуття в один день: {booking1.IsArrivingToday()}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        

        
        
    }
}