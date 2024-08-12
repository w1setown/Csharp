namespace How_many_occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the main string:");
            string mainString = Console.ReadLine();

            Console.WriteLine("Enter the substring:");
            string subString = Console.ReadLine();

            int count = Occurrence(mainString, subString);
            Console.WriteLine($"The substring '{subString}' occurs {count} times in the main string.");
        }

        static int Occurrence(string mainString, string subString)
        {
            int count = 0, index = 0;
            while ((index = mainString.IndexOf(subString, index)) != -1)
            {
                count++;
                index += subString.Length;
            }
            return count;
        }
    }
}