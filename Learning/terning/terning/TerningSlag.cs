namespace terning
{
    public class TerningSlag
    {
        private Random _random;

        public TerningSlag()
        {
            _random = new Random();
        }

        public int Roll()
        {
            return _random.Next(1, 7);
        }
    }
}
