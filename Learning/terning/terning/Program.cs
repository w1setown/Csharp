using System.Diagnostics.Metrics;

namespace terning
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Antal terninger: ");
            string input = Console.ReadLine();
            int antalTerninger;
            if (int.TryParse(input, out antalTerninger) && antalTerninger > 0)
            {
                DiceRoller diceRoller = new DiceRoller();
                Counter counter = new Counter();
                counter.CountRolls(antalTerninger, diceRoller);
            }
            else
            {
                Console.WriteLine("ADVARSEL: Giv et positivt tal.");
            }
        }
    }
}
