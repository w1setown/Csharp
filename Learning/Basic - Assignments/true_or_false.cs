namespace True_False
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsResultTheSame(2 + 2, 2 * 2));
            Console.WriteLine(IsResultTheSame(9 / 3, 16 - 1));
        }

        static int IsResultTheSame(int result1, int result2)
        {
            return result1 == result2 ? 1 : 0;
        }
    }
}
