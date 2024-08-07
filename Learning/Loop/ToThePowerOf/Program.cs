namespace ToThePowerOf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result1 = ToThePowerOf(-2, 3);
            Console.WriteLine(result1);

            int result2 = ToThePowerOf(5, 5);
            Console.WriteLine(result2);
        }

        static int ToThePowerOf(int baseNumber, int exponent)
        {
            int result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result *= baseNumber;
            }
            return result;
        }
    }
}
