namespace Divisible
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first integer:");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second integer:");
            int number2 = int.Parse(Console.ReadLine());

            int result = CalculateResult(number1, number2);
            Console.WriteLine($"The result is: {result}");
        }

        static int CalculateResult(int number1, int number2)
        {
            if ((number1 % 2 == 0 || number1 % 3 == 0) && (number2 % 2 == 0 || number2 % 3 == 0))
            {
                return number1 * number2;
            }

            else
            {
                return number1 + number2;
            }
        }
    }
}