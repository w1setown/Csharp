namespace Modulo_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user for input
            Console.WriteLine("Tilføj 1. integer:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Tilføj 2. integer:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Tilføj 3. integer:");
            int c = int.Parse(Console.ReadLine());

            // Call the ModuloOperation method with user inputs
            int result = ModuloOperation(a, b, c);
            Console.WriteLine($"The result is: {result}");
        }

        static int ModuloOperation(int a, int b, int c)
        {
            int firstModulo = a % b;
            int secondModulo = firstModulo % c;
            return secondModulo;
        }
    }
}
