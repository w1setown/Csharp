namespace mExtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintResult("##abc##def");
            PrintResult("12####78");
            PrintResult("gar##d#en");
            PrintResult("++##--##++");
            PrintResult("++######++");
        }
        static void PrintResult(string input)
        {
            string result = ExtractString(input);
            if (string.IsNullOrEmpty(result))
            {
                Console.WriteLine("lmao string empty ");
            }
            else
            {
                Console.WriteLine(result);
            }
        }
        static string ExtractString(string input)
        {
            int start = input.IndexOf("##");
            if (start == -1) return string.Empty;

            int end = input.IndexOf("##", start + 2);
            if (end == -1) return string.Empty;

            return input.Substring(start + 2, end - start - 2);
        }
    }
}
