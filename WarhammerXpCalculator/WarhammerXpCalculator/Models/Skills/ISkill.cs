namespace WarhammerXpCalculator.Models.Skills
{
    public interface ISkill
    {
        public int Id { get; set; }
        public int CharacterId { get; set; }
        public string Name { get; set; }
        public int? CharacteristicId { get; set; }
        public int Advances { get; set; }

        public int Current { get; }
    }
}
