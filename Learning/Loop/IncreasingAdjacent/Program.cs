namespace IncreasingAdjacent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 45, 23, 44, 68, 65, 70, 80, 81, 82 };
            int[] array2 = { 7, 3, 5, 8, 9, 3, 1, 4 };

            Console.WriteLine(ThreeIncreasingAdjacent(array1));
            Console.WriteLine(ThreeIncreasingAdjacent(array2));

        }
        static bool ThreeIncreasingAdjacent(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 2; i++)
            {
                if (numbers[i + 1] == numbers[i] + 1 && numbers[i + 2] == numbers[i + 1] + 1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
