using System;
using System.Collections.Generic;
using System.Linq;

namespace yahtzee_konsol
{
    public class Spil
    {
        private List<Spiller> spillere;
        private int maxSpillere = 4;
        private int antalKastPrTur = 3; // Maksimalt antal kast per tur
        private int antalTerninger = 5; // Antal terninger i spillet
        private int[] terninger = new int[5];

        public Spil()
        {
            spillere = new List<Spiller>();
        }

        public void StartSpil()
        {
            Console.WriteLine("Velkommen til Yatzy!");

            int antalSpillere = 0;
            while (antalSpillere < 1 || antalSpillere > maxSpillere)
            {
                Console.Write($"Indtast antal spillere (1-{maxSpillere}): ");
                int.TryParse(Console.ReadLine(), out antalSpillere);
            }

            for (int i = 1; i <= antalSpillere; i++)
            {
                Console.Write($"Indtast navnet på spiller {i}: ");
                string spillerNavn = Console.ReadLine();
                spillere.Add(new Spiller(spillerNavn));
            }

            Console.Clear(); // Rydder konsollen og starter spillet
            VisResultattavle(); // Initial visning af resultattavlen

            AfviklSpil();
        }

        private void AfviklSpil()
        {
            foreach (var spiller in spillere)
            {
                for (int runde = 0; runde < 13; runde++) // 13 runder i Yatzy
                {
                    SpilTur(spiller);
                }
            }
            VisResultattavle(); // Vis slutresultat
            Console.WriteLine("Spillet er slut! Tak for at spille.");
        }

        private void SpilTur(Spiller spiller)
        {
            Console.Clear();
            Console.WriteLine($"\n{spiller.Navn}'s tur!");

            // Spiller får op til tre kast
            int[] behold = new int[antalTerninger];
            for (int kast = 1; kast <= antalKastPrTur; kast++)
            {
                RulTerninger(behold);
                VisTerninger();

                if (kast < antalKastPrTur)
                {
                    Console.WriteLine("Indtast numrene på de terninger, du vil beholde (f.eks. 1 3 5), eller tryk Enter for at kaste igen:");
                    string input = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(input))
                    {
                        behold = input.Split(' ').Select(int.Parse).Select(i => i - 1).ToArray();
                    }
                }
            }

            // Spiller vælger en kategori at score i
            Console.WriteLine("Vælg en kategori at score i:");
            Console.WriteLine("1. Enere, 2. Toere, 3. Treere, 4. Firere, 5. Femmere, 6. Seksere, 7. Tre ens, 8. Fire ens, 9. Fuldt hus, 10. Lille straight, 11. Stor straight, 12. Yatzy, 13. Chance");
            int kategori = int.Parse(Console.ReadLine());
            scorer(spiller, kategori);
            VisResultattavle();
            Console.WriteLine("\nTryk på Enter for at fortsætte...");
            Console.ReadKey();
        }

        private void RulTerninger(int[] behold)
        {
            Random rnd = new Random();
            for (int i = 0; i < antalTerninger; i++)
            {
                if (!behold.Contains(i)) // Kun rul de terninger, der ikke er valgt at beholdes
                {
                    terninger[i] = rnd.Next(1, 7);
                }
            }
        }

        private void VisTerninger()
        {
            Console.WriteLine("Terninger:");
            for (int i = 0; i < antalTerninger; i++)
            {
                Console.Write($"[{terninger[i]}] ");
            }
            Console.WriteLine();
        }

        private void scorer(Spiller spiller, int kategori)
        {
            int score = 0;
            switch (kategori)
            {
                case 1: // Enere
                    score = terninger.Count(t => t == 1);
                    break;
                case 2: // Toere
                    score = terninger.Count(t => t == 2) * 2;
                    break;
                case 3: // Treere
                    score = terninger.Count(t => t == 3) * 3;
                    break;
                case 4: // Firere
                    score = terninger.Count(t => t == 4) * 4;
                    break;
                case 5: // Femmere
                    score = terninger.Count(t => t == 5) * 5;
                    break;
                case 6: // Seksere
                    score = terninger.Count(t => t == 6) * 6;
                    break;
                case 7: // Tre ens
                    score = terninger.GroupBy(t => t).Any(g => g.Count() >= 3) ? terninger.Sum() : 0;
                    break;
                case 8: // Fire ens
                    score = terninger.GroupBy(t => t).Any(g => g.Count() >= 4) ? terninger.Sum() : 0;
                    break;
                case 9: // Fuldt hus
                    score = terninger.GroupBy(t => t).Any(g => g.Count() == 3) && terninger.GroupBy(t => t).Any(g => g.Count() == 2) ? 25 : 0;
                    break;
                case 10: // Lille straight
                    score = terninger.OrderBy(t => t).Distinct().SequenceEqual(new int[] { 1, 2, 3, 4, 5 }) ? 30 : 0;
                    break;
                case 11: // Stor straight
                    score = terninger.OrderBy(t => t).Distinct().SequenceEqual(new int[] { 2, 3, 4, 5, 6 }) ? 40 : 0;
                    break;
                case 12: // Yatzy
                    score = terninger.Distinct().Count() == 1 ? 50 : 0;
                    break;
                case 13: // Chance
                    score = terninger.Sum();
                    break;
                default:
                    Console.WriteLine("Ugyldig kategori!");
                    break;
            }
            spiller.Point += score;
            Console.WriteLine($"{spiller.Navn} scorede {score} point i kategori {kategori}");
        }

        private void VisResultattavle()
        {
            int tavleStartX = Console.WindowWidth - 30; // Placér tavlen 30 tegn fra højre kant

            // Gem den nuværende cursor position for at kunne vende tilbage
            int cursorLeft = Console.CursorLeft;
            int cursorTop = Console.CursorTop;

            // Opdaterer resultattavlen
            Console.SetCursorPosition(tavleStartX, 0); // Placér cursoren til højre
            Console.WriteLine("Resultattavle:");
            for (int i = 0; i < spillere.Count; i++)
            {
                Console.SetCursorPosition(tavleStartX, i + 1);
                Console.WriteLine($"{spillere[i].Navn}: {spillere[i].Point} point");
            }

            // Vend tilbage til den tidligere position
            Console.SetCursorPosition(cursorLeft, cursorTop);
        }
    }

    public class Spiller
    {
        public string Navn { get; private set; }
        public int Point { get; set; }

        public Spiller(string navn)
        {
            Navn = navn;
            Point = 0;
        }
    }
}
