namespace terning
{
    public class Tæller
    {
        public int CountRolls(int antalTerninger, TerningSlag diceRoller)
        {
            int slagTæller = 0;

            while (true)
            {
                slagTæller++;
                Console.Write($"\rSlag: {slagTæller}");
                bool alleSeksere = true;

                for (int i = 0; i < antalTerninger; i++)
                {
                    int slag = diceRoller.Roll();
                    if (slag != 6)
                    {
                        alleSeksere = false;
                        break;
                    }
                }

                if (alleSeksere)
                {
                    break;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Det tog {slagTæller} slag for at alle blev sekser.");
            return slagTæller;
        }
    }
}
