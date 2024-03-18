namespace WarhammerXpCalculator.Models
{
    public class Characteristic
    {
        public int Initial { get; set; }
        public int Advances { get; set; }
        public int Current => Initial + Advances;

        public Characteristic(int initialValue)
        {
            Initial = initialValue;
            Advances = 0;
        }
    }
}
