namespace Basic___Exercises
{
    internal class CelsiusToFahrenheitProgram
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the temperature in Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = ConvertedTemperature(celsius);
            if (fahrenheit != double.MinValue)
            {
                Console.WriteLine($"Temp is: {fahrenheit}°F");
            }
        }

        static double ConvertedTemperature(double celsius)
        {
            if (celsius < -273.15)
            {
                Console.WriteLine($"ERROR: {celsius}°C is below absolute zero!");
                return double.MinValue; // Indicate an error condition
            }

            double fahrenheit = (celsius * 9 / 5) + 32;
            return fahrenheit;
        }
    }
}
