namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)

        {
            PrintMultiplicationTable();
        }

        static void PrintMultiplicationTable()
        {
            for (int inte = 1; inte <= 10; inte++) 
            {
                for (int num = 1; num <= 10; num++) 
                {
                    int Table = inte * num;
                    Console.Write(Table + "\t");
                    // \t is used to add a tab space between the numbers:
                    // 1 2 3 4 5 6 7 8 9 10 is how it looks without \t
                    // 1   2   3   4   5   6   7   8   9   10 is how it looks with \t 
                }

                Console.WriteLine(); 
            }
        }
    }
}
