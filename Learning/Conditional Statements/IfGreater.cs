namespace IfGreater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input 3 integers
            Console.WriteLine("First integer:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Second integer:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Third integer:");
            int num3 = int.Parse(Console.ReadLine());

            // Checks
            if (num1 * num2 > num3)
            {
                Console.WriteLine("Multiplication is greater.");
            }
            else
            {
                if (num1 + num2 > num3)
                {
                    Console.WriteLine("Sum is greater.");
                }
                else
                {
                    Console.WriteLine("Neither is greater.");
                }
            }
        }
    }
}
