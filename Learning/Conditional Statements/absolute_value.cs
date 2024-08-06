namespace Absolute_value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer:");
            int number = int.Parse(Console.ReadLine());
            int absoluteValue = Math.Abs(number);
            Console.WriteLine($"The absolute value is {absoluteValue}");
        }
    }
}