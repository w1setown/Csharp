namespace CheckSorted
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first integer:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second integer:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter third integer:");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 <= num2 && num2 <= num3)
            {
                Console.WriteLine("Sorted");
            }
            else
            {
                Console.WriteLine("Not sorted");
            }
        }
    }
}