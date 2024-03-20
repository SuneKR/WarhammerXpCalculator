namespace WarhammerXpCalculator.Models.Skills
{
    public class BasicSkill : ISkill
    {
        public string Id { get; set; }
        public string Name { get; set; } = null!;
        public Characteristic SkillCharacteristic { get; set; } = null!;
        public int Advances { get; set; }
        public int Current => SkillCharacteristic.Current + Advances;

        /*
        public BasicSkill(string name, Characteristic skillCharacteristic)
        {
            this.Name = name;
            this.SkillCharacteristic = skillCharacteristic;
        }
        */
    }
}
