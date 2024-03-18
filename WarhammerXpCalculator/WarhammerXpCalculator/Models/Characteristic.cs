namespace WarhammerXpCalculator.Models
{
    public class Characteristic
    {
        public string LongName { get; set; }
        public string ShortName { get; set; }
        public int Initial { get; set; }
        public int Advances { get; set; }
        public int Current => Initial + Advances;

        public Characteristic(string lname, string sname, int initialValue)
        {
            LongName = lname;
            ShortName = sname;
            Initial = initialValue;
            Advances = 0;
        }
        public Characteristic(string lname, string sname)
        {
            LongName = lname;
            ShortName = sname;
            Initial = 0;
            Advances = 0;
        }
        public void GenerateInitial()
        {
            Random rng = new Random();
            Initial = 20 + rng.Next(1, 10) + rng.Next(1, 10);
        }
    }
}
