namespace WarhammerXpCalculator.Models.Skills
{
    public class BasicSkill : ISkill
    {
        public string Name { get; set; }
        public Characteristic SkillCharacteristic { get; set; }
        public int Advances { get; set; }
        public int Current { get => CurrentValue; set => CurrentValue = SkillCharacteristic.Current + Advances; }
        private int CurrentValue { get; set; }

        public BasicSkill(string name, Characteristic skillCharacteristic)
        {
            this.Name = name;
            this.SkillCharacteristic = skillCharacteristic;
        }
    }
}
