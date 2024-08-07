namespace Cube_of
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to find its cube:");
            string input = Console.ReadLine();

            double number;
            if (double.TryParse(input, out number))
            {
                double result = TheCubeOf(number);
                Console.WriteLine("The cube of " + number + " is " + result);
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }

        static double TheCubeOf(double number)
        {
            return number * number * number;
        }
    }
}
