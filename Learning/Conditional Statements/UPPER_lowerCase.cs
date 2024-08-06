namespace UPPERCASE_lowercase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 character string:");
            string input = Console.ReadLine();

            if (input.Length == 3)
            {
                bool isUppercase = CheckIfUppercase(input);
                Console.WriteLine($"Uppercase letters: {isUppercase}");
            }
            else
            {
                Console.WriteLine("The input is not 3 characters long.");
            }
        }

        static bool CheckIfUppercase(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsUpper(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
