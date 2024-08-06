namespace Absolute_value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer:");
            int number = int.Parse(Console.ReadLine());

            int absoluteValue = 0;
            if (number < 0)
            {
                if (number != 0)
                {
                    absoluteValue = -number;
                }
            }
            else
            {
                absoluteValue = number;
            }

            Console.WriteLine($"The absolute value is {absoluteValue}");
        }
    }
}
