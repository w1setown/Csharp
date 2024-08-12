using System.Linq;

namespace Sort_characters_descending
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            char[] sortedChars = input.OrderByDescending(c => c).ToArray();
            Console.WriteLine(new string(sortedChars));
        }
    }
}