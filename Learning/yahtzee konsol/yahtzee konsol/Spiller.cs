namespace yahtzee_konsol
{
public class Spiller
{
    public string Navn { get; private set; }  // Dette er egenskaben Navn
    public int Point { get; set; }

    public Spiller(string navn)
    {
        Navn = navn;  // Navn bruges her korrekt
        Point = 0;
    }
}
