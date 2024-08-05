namespace Basic___Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The Celsius to Fahrenheit code has been removed.

            // Uncomment the following line if you want to use the AddAndMultiply method
            Console.WriteLine(AddAndMultiply(2, 4, 5));
        }

        // | Add two numbers
        static int AddAndMultiply(int a, int b, int c)
        {
            int output = 0;
            output = (a + b) * c;
            return output;
        }
    }
}
