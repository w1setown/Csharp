using System;

namespace Compress_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Compression tiiiime, gib me strink");
            string? input = Console.ReadLine();
            if (input == null)
            {
                input = "";
            }
            Console.WriteLine("Compressed string: " + Undercompression(input));
        }

        static string Undercompression(string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            var result = "";
            var count = 1;

            for (var i = 1; i < str.Length; i++)
            {
                if (str[i] == str[i - 1])
                {
                    count++;
                }
                else
                {
                    result += str[i - 1] + count.ToString();
                    count = 1;
                }
            }

            result += str[^1] + count.ToString();
            return result.Length < str.Length ? result : str;
        }
    }
}
