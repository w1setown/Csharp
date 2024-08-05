
{
    internal class CelsiusToFahrenheitProgram
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the temperature in celsius:");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = ConvertedTemperature(celsius);
            Console.WriteLine($"Temp is: {fahrenheit}°F");
        }

        static double ConvertedTemperature(double celsius)
        {
            if (celsius < -271.15)
            {
                Console.WriteLine($"ERROR {celsius}°C is below absolute zero!");   
            }
            double fahrenheit = (celsius * 9 / 5) + 32;
            return fahrenheit;
        }
    }
}
