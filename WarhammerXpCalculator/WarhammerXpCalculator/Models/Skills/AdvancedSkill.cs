namespace WarhammerXpCalculator.Models.Skills
{
    public class AdvancedSkill : ISkill
    {
        public string Name { get; set; }
        public Characteristic SkillCharacteristic { get; set; }
        public int Advances { get; set; }
        public int Current
        {
            get => CurrentValue;
            set
            {
                if (Advances > 0) { CurrentValue = SkillCharacteristic.Current + Advances; }
                else { CurrentValue = 0; }
            }
        }
        private int CurrentValue { get; set; }
        public AdvancedSkill(string name, Characteristic skillCharacteristic)
        {
            Name = name;
            SkillCharacteristic = skillCharacteristic;
        }
    }
}
