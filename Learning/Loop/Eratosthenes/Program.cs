namespace Eratosthenes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bigNumber = 69;                              //😏😏😏😏😏😏😏
            var primeGang = GetPrimeNumbers(bigNumber);
            Console.WriteLine(string.Join(", ", primeGang));
        }
        static List<int> GetPrimeNumbers(int bigNumber)
        {
            var isItPrime = new bool[bigNumber + 1];
            Array.Fill(isItPrime, true, 2, bigNumber - 1);

            for (int num = 2; num * num <= bigNumber; num++)
            {
                if (isItPrime[num])
                {
                    for (int multiple = num * num; multiple <= bigNumber; multiple += num)
                    {
                        isItPrime[multiple] = false;
                    }
                }
            }
            var primeGang = new List<int>();
            for (int num = 2; num <= bigNumber; num++)
            {
                if (isItPrime[num])
                {
                    primeGang.Add(num);
                }
            }
            return primeGang;
        }
    }
}
