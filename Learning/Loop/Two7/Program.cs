namespace Two7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 8, 2, 5, 7, 9, 0, 7, 7, 3, 1 };
            int[] arr2 = { 9, 4, 5, 3, 7, 7, 7, 3, 2, 5, 7, 7 };

            Console.WriteLine(Count77(arr1));
            Console.WriteLine(Count77(arr2)); 
        }
        static int Count77(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == 7 && arr[i + 1] == 7)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
