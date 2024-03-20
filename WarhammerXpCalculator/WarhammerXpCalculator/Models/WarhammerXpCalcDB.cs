using Microsoft.EntityFrameworkCore;

namespace WarhammerXpCalculator.Models
{
    public class WarhammerXpCalcDB : DbContext
    {
        public WarhammerXpCalcDB(DbContextOptions<WarhammerXpCalcDB> options) : base(options) { }

        public virtual DbSet<Character> Characters { get; set; }
        public virtual DbSet<Party> Parties { get; set; }
        public virtual DbSet<ExperienceLog> ExperienceLogs { get; set; }
        
    }
}
