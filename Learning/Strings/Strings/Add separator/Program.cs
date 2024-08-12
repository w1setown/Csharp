namespace Add_separator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gib me a string!");
            string inputString = Console.ReadLine();

            Console.WriteLine("Now GIB ME A SEPARATOR");
            string separator = Console.ReadLine();

            string result = AddSeparator(inputString, separator);
            Console.WriteLine("Now check this out: " + result);
        }
        
        static string AddSeparator(string str, string sep)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                result += str[i];
                if (i != str.Length - 1)
                {
                    result += sep;
                }
            }
            return result;
        }
    }
}

// How it works:
//  If str is "hello" and sep is "-", the loop will work as follows:
//  result starts as "".
//	After the first iteration(i = 0), result becomes "h".
//	The separator "-" is added, so result becomes "h-".
//	After the second iteration(i = 1), result becomes "h-e".
//  The separator "-" is added, so result becomes "h-e-".
//	This continues until the last character, resulting in "h-e-l-l-o".