namespace Sum_Average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumAvg(11, 66)); 
            Console.WriteLine(SumAvg(-10, 0)); 
        }

        static string SumAvg(int n, int m)
        {
            int sum = 0;
            int count = 0;

            for (int i = n; i <= m; i++)
            {
                sum += i;
                count++;
            }

            double avg = (double)sum / count;

            return $"Sum: {sum}, Avg: {avg}";
        }
    }
}
