namespace WarhammerXpCalculator.Models
{
    public class ExperienceLog
    {
        public int Id { get; set; }
        public int CharacterId { get; set; }
        public int XpSpent { get; set; }
        public bool InCareerDiscount { get; set; }
        public DateTime Timestamp { get; set; }
        public virtual Character character { get; set; }
    }
}
