namespace Number_of_words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a sentence so I can count it!");
            string input = Console.ReadLine();
            int wordCount = CountWords(input);
            if (wordCount == 69)
            {
                Console.WriteLine($"{wordCount} words... nice");
            }
            else
            {
                Console.WriteLine($"This sentence has {wordCount} words! Waow that is alot!");
            }
        }

        static int CountWords(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }

            string[] words = input.Split(" ");
            return words.Length;
        }
    }
}
