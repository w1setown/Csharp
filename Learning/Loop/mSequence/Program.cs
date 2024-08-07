namespace mSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Letters("ds"));
            Console.WriteLine(Letters("or"));
            Console.WriteLine(Letters("az"));

        }
        static string Letters(string input)
        {
            char start = input[0];
            char end = input[1];
            string result = "";
            for (char c = start; c <= end; c++)
            {
                result += c;
            }
            return result;
        }
    }
}
