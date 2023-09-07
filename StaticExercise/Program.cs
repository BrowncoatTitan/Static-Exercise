namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"0 celsius is {TempConverter.CelsiusToFarenheit(0)} farenheit.");
            Console.WriteLine($"32 farenheit is {TempConverter.FarenheitToCelsius(32)} celsius.");
        }
    }
}
