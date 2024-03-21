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
        public virtual DbSet<Characteristic> Characteristics { get; set; }
        public virtual DbSet<AdvancedSkill> AdvancedSkills { get; set; }
        public virtual DbSet<BasicSkill> BasicSkills { get; set; }
        public virtual DbSet<Talents> Talents { get; set; }
        
    }
}
