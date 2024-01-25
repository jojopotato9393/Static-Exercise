namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            double c = 50;
            double f = 50;
            TempConverter.CelsiusToFahrenheit(c);
            TempConverter.FahrenheitToCelsius(f);
            double celsius = TempConverter.FahrenheitToCelsius(f);
            Console.WriteLine($"{f}°F is equivalent to {celsius}°C");
            f = TempConverter.CelsiusToFahrenheit(c);
            Console.WriteLine($"{c}°C is equivalent to {f}°F");

        }
    }
}
