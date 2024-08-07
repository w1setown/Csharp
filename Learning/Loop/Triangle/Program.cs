class Program
{
    static void Main()
    {
        DrawTriangle();
    }
    static void DrawTriangle()
    {
        Console.WriteLine("LOOK ITS A PYRAMID!");
        int height = 20;
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < height - i - 1; j++)
            {
                Console.Write(" ");
            }
            for (int k = 0; k < 2 * i + 1; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
