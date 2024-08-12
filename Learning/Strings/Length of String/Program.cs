namespace String_Length
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string:");
            string inputString = Console.ReadLine();

            int length = GetStringLength(inputString);
            Console.WriteLine("The length of the string is: " + length);
        }

        static int GetStringLength(string str)
        {
            int length = 0;
            foreach (char c in str)
            {
                length++;
            }
            return length;
        }
    }
}

// How it works:
//  The method GetStringLength calculates the length of a string by iterating through each character in the string.
//  For each character, it increments the length counter by 1.

//  For example, if the input string is "hello":
//      The length starts at 0.
//      After the first character ('h'), the length becomes 1.
//      After the second character ('e'), the length becomes 2.
//      This continues until the last character, resulting in a length of 5.
