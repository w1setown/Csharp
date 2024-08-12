namespace Revert_words_order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a sentence");
            string input = Console.ReadLine();
            string reversedSentence = ReverseWordsOrder(input);
            Console.WriteLine($"Reversed sentence: {reversedSentence}");
        }

        static string ReverseWordsOrder(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            bool endsWithPeriod = input.EndsWith(".");
            if (endsWithPeriod)
            {
                input = input.TrimEnd(".");
            }

            string[] words = input.Split(" ");
            Array.Reverse(words);
            string reversedSentence = string.Join(" ", words);

            if (endsWithPeriod)
            {
                reversedSentence += ".";
            }

            return reversedSentence;
        }
    }
}