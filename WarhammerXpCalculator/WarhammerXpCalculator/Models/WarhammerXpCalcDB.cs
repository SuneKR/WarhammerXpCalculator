using Microsoft.EntityFrameworkCore;
using WarhammerXpCalculator.Models;
using WarhammerXpCalculator.Models.Skills;

namespace WarhammerXpCalculator.Models
{
    public class WarhammerXpCalcDB : DbContext
    {
        public WarhammerXpCalcDB(DbContextOptions<WarhammerXpCalcDB> options) : base(options) { }

        public virtual DbSet<Character> Characters { get; set; }
        public virtual DbSet<Party> Parties { get; set; }
        public virtual DbSet<ExperienceLog> ExperienceLogs { get; set; }
        public DbSet<WarhammerXpCalculator.Models.Characteristic> Characteristic { get; set; } = default!;
        public DbSet<WarhammerXpCalculator.Models.Skills.BasicSkill> BasicSkill { get; set; } = default!;
        
    }
}
