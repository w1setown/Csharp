namespace CheckNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("Positive");
            }
            else
            {
                if (num < 0)
                {
                    Console.WriteLine("Negative");
                }
                else
                {
                    Console.WriteLine("Zero");
                }
            }
        }
    }
}