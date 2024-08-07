namespace ElementaryOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please give me the first integer");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Please give me the second integer");
            double b = double.Parse(Console.ReadLine());

            double[] results = Values(a, b);

            Console.WriteLine($"Addition: {results[0]}");
            Console.WriteLine($"Subtraction: {results[1]}");
            Console.WriteLine($"Multiplication: {results[2]}");
            Console.WriteLine($"Division: {results[3]}");
        }
        static double[] Values(double a, double b)
        {
            double[] results = new double[4];
            results[0] = a + b;
            results[1] = a - b;
            results[2] = a * b;
            results[3] = a / b;

            return results;
        }
    }
}

