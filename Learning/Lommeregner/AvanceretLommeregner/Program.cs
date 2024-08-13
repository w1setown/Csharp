namespace AvanceretLommeregner
{
    public class Program
    {
        public static double nummer1 = 0; // Jeg har ændret datatypen fra int til double
        public static double nummer2 = 0; // Årsagen er, at jeg vil have at lommeregneren kunne håndtere decimaltal

        public static void Main(string[] args)
        {
            Console.WriteLine("Konsol lommeregner i C#");
            Console.WriteLine("------------------------");

            Console.WriteLine("Indtast det første tal: ");
            nummer1 = Convert.ToDouble(Console.ReadLine());

            bool forrsætUdregning = true;

            while (forrsætUdregning)
            {
                Console.WriteLine("Indtast det næste tal: ");
                nummer2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Vælg en valgmulighed fra følgende liste:");
                Console.WriteLine("\tq - Plus");
                Console.WriteLine("\tw - Minus");
                Console.WriteLine("\te - Gange");
                Console.WriteLine("\tr - Divider");
                Console.WriteLine("\ta - Procentdel");
                Console.WriteLine("\ts - Potens");
                Console.WriteLine("\tx - Afslut");
                Console.WriteLine("Hvad er dit valg?");

                string valg = Console.ReadLine();

                if (valg == "q")
                {
                    nummer1 = Plus(nummer1, nummer2);
                    Console.WriteLine($"Resultatet er {nummer1}");
                }
                else if (valg == "w")
                {
                    nummer1 = Minus(nummer1, nummer2);
                    Console.WriteLine($"Resultatet er {nummer1}");
                }
                else if (valg == "e")
                {
                    nummer1 = Gange(nummer1, nummer2);
                    Console.WriteLine($"Resultatet er {nummer1}");
                }
                else if (valg == "r")
                {
                    if (nummer2 != 0)
                    {
                        nummer1 = Divider(nummer1, nummer2);
                        Console.WriteLine($"Resultatet er {nummer1}");
                    }
                    else
                    {
                        Console.WriteLine("Fejl: Division med nul er ikke tilladt.");
                    }
                }
                else if (valg == "a")
                {
                    nummer1 = Procent(nummer1, nummer2);
                    Console.WriteLine($"{nummer2}% af det første tal er {nummer1}");
                }
                else if (valg == "s")
                {
                    nummer1 = Potens(nummer1, nummer2);
                    Console.WriteLine($"{nummer1} hævet til {nummer2} er {nummer1}");
                }
                else if (valg == "x")
                {
                    forrsætUdregning = false;
                }
                else
                {
                    Console.WriteLine("Ugyldigt valg.");
                }

                if (forrsætUdregning)
                {
                    Console.WriteLine("Vil du lave en ny udregning? (y/n)");
                    string svar = Console.ReadLine().ToLower();
                    if (svar != "y")
                    {
                        forrsætUdregning = false;
                    }
                }
            }
        }

        public static double Plus(double a, double b)
        {
            return a + b;
        }

        public static double Minus(double a, double b)
        {
            return a - b;
        }

        public static double Gange(double a, double b)
        {
            return a * b;
        }

        public static double Divider(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Dividering med 0 er ikke tilladt.");
            }
            return a / b;
        }

        public static double Procent(double total, double percent)
        {
            return (total * percent) / 100;
        }

        public static double Potens(double a, double b)
        {
            return Math.Pow(a, b);
        }
    }
}
