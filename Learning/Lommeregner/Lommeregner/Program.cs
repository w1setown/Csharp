namespace Lommeregner
{
    internal class Program
    {
        static int nummer1 = 0;
        static int nummer2 = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Konsol lommeregner i C#");
            Console.WriteLine("------------------------");

            Console.WriteLine("Indtast det første tal: ");
            nummer1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indtast det andet tal: ");
            nummer2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vælg en valgmulighed fra følgende liste:");
            Console.WriteLine("\tq - Plus");
            Console.WriteLine("\tw - Minus");
            Console.WriteLine("\te - Gange");
            Console.WriteLine("\tr - Divider");
            Console.WriteLine("Hvad er dit valg?");

            string valg = Console.ReadLine();

            if (valg == "q")
            {
                Console.WriteLine($"Resultatet af {nummer1} + {nummer2} = " + (nummer1 + nummer2));
            }
            else if (valg == "w")
            {
                Console.WriteLine($"Resultatet af {nummer1} - {nummer2} = " + (nummer1 - nummer2));
            }
            else if (valg == "e")
            {
                Console.WriteLine($"Resultatet af {nummer1} * {nummer2} = " + (nummer1 * nummer2));
            }
            else if (valg == "r")
            {
                Console.WriteLine($"Resultatet af {nummer1} / {nummer2} = " + (nummer1 / nummer2));
            }
            else
            {
                Console.WriteLine("Ugyldigt valg.");
            }
        }
    }
}
