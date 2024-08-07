namespace TheBigNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = { 190, 291, 145, 209, 280, 200 };
            int[] numbers2 = { -9, -2, -7, -8, -4 };

            Console.WriteLine(BigNumber(numbers1));
            Console.WriteLine(BigNumber(numbers2));
        }

        static int BigNumber(int[] numbers)
        {
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] >= max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }
    }
}
