
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
