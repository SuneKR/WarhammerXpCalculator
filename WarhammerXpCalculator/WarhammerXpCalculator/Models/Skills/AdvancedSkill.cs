namespace WarhammerXpCalculator.Models.Skills
{
    public class AdvancedSkill : ISkill
    {
        public int Id { get; set; }
        public int CharacterId { get; set; }
        public string Name { get; set; } = null!;
        public int? CharacteristicId { get; set; } = null!;
        public int Advances { get; set; }

        public virtual Character? SkillCharacter { get; set; }
        public virtual Characteristic? SkillCharacteristic { get; set; }

        public int Current
        {
            get
            {
                using (var dbContext = new WarhammerXpCalcDB())
                {
                    var characteristic = dbContext.Characteristics.FirstOrDefault(c => c.Id == CharacteristicId);
                    if (characteristic != null) { return characteristic.Current + Advances; }
                    return 0;
                }
            }
        }
    }
}
