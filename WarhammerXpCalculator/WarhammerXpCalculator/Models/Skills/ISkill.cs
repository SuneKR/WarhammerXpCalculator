namespace WarhammerXpCalculator.Models.Skills
{
    public interface ISkill
    {
        public string Name { get; set; }
        public Characteristic SkillCharacteristic { get; set; }
        public int Advances { get; set; }
        public int Current => SkillCharacteristic.Current + Advances;
    }
}
