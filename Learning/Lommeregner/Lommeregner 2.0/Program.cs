﻿namespace Lommeregner_2._0
{
    internal class Program
    {
        static double nummer1 = 0; // Jeg har ændret datatypen fra int til double
        static double nummer2 = 0; // Årsagen er, at jeg vil have at lommeregneren kunne håndtere decimaltal

        static void Main(string[] args)
        {
            Console.WriteLine("Konsol lommeregner i C#");
            Console.WriteLine("------------------------");

            Console.WriteLine("Indtast det første tal: ");
            nummer1 = Convert.ToDouble(Console.ReadLine());

            bool forrsæt= true;

            while (forrsæt)
            {
                Console.WriteLine("Indtast det næste tal: ");
                nummer2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Vælg en valgmulighed fra følgende liste:");
                Console.WriteLine("\tq - Plus");
                Console.WriteLine("\tw - Minus");
                Console.WriteLine("\te - Gange");
                Console.WriteLine("\tr - Divider");
                Console.WriteLine("\tx - Afslut");
                Console.WriteLine("Hvad er dit valg?");

                string valg = Console.ReadLine();

                if (valg == "q")
                {
                    nummer1 = nummer1 + nummer2;
                    Console.WriteLine($"Resultatet er {nummer1}");
                }
                else if (valg == "w")
                {
                    nummer1 = nummer1 - nummer2;
                    Console.WriteLine($"Resultatet er {nummer1}");
                }
                else if (valg == "e")
                {
                    nummer1 = nummer1 * nummer2;
                    Console.WriteLine($"Resultatet er {nummer1}");
                }
                else if (valg == "r")
                {
                    if (nummer2 != 0)
                    {
                        nummer1 = nummer1 / nummer2;
                        Console.WriteLine($"Resultatet er {nummer1}");
                    }
                    else
                    {
                        Console.WriteLine("Fejl: Division med nul er ikke tilladt.");
                    }
                }
                else if (valg == "x")
                {
                    forrsæt = false;
                }
                else
                {
                    Console.WriteLine("Ugyldigt valg.");
                }

                if (continueCalculating)
                {
                    Console.WriteLine("Vil du lave en ny beregning? (ja/nej)");
                    string svar = Console.ReadLine().ToLower();
                    if (svar != "ja")
                    {
                        forrsæt = false;
                    }
                }
            }
        }
    }
}
