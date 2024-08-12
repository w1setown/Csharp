namespace String_in_reverse_order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to reverse:");
            string input = Console.ReadLine();
            string reversed = ReverseString(input);
            Console.WriteLine("Reversed string: " + reversed);
        }

        static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}


// How it works:
//  The method ReverseString reverses the given string by converting it to a character array,
//  reversing the array, and then converting it back to a string.

//  For example, if the input string is "hello":
//      The string is first converted to a character array: ['h', 'e', 'l', 'l', 'o']
//      The character array is then reversed: ['o', 'l', 'l', 'e', 'h']
//      Finally, the reversed character array is converted back to a string: "olleh"