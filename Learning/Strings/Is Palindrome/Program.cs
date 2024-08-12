namespace Is_Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string:");
            string inputString = Console.ReadLine();

            bool isPalindrome = IsPalindrome(inputString);
            if (isPalindrome)
            {
                Console.WriteLine("The string is a palindrome.");
            }
            else
            {
                Console.WriteLine("The string is not a palindrome.");
            }
        }

        static bool IsPalindrome(string str)
        {
            int left = 0;
            int right = str.Length - 1;

            while (left < right)
            {
                if (str[left] != str[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
    }
}

// How it works:
//  The method IsPalindrome checks if a string is a palindrome by comparing characters from the start and end moving towards the center.
//  If any characters don't match, it returns false. If all characters match, it returns true.

//  For example, if the input string is madam:
//      The first and last characters (m and m) are compared and match.
//      The second and second-last characters (a and a) are compared and match.
//      This continues until the middle of the string, confirming it is a palindrome.
