namespace WarhammerXpCalculator.Models.Skills
{
    public class AdvancedSkill : ISkill
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Characteristic SkillCharacteristic { get; set; }
        public int Advances { get; set; }
        public int Current => SkillCharacteristic.Current + Advances;

        public AdvancedSkill(string name, Characteristic skillCharacteristic)
        {
            Name = name;
            SkillCharacteristic = skillCharacteristic;
            Advances = 1;
        }
        public AdvancedSkill() : this("",new Characteristic()) { }
    }
}
