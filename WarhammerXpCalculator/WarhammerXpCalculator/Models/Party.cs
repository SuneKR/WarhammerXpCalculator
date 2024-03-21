namespace WarhammerXpCalculator.Models
{
    public class Party
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortTermPartyAmbition { get; set; }
        public string LongTermPartyAmbition { get; set; }
        public int PartyAwardedXP { get; set; }

        public Party(int id)
        {
            Id = id;
            Name = "";
            ShortTermPartyAmbition = "";
            LongTermPartyAmbition = "";
            PartyAwardedXP = 0;

        }
        public Party(int id, string name, string shortTermPartyAmbition, string longTermPartyAmbition, int partyAwardedXP)
        {
            Id = id;
            Name = name;
            ShortTermPartyAmbition = shortTermPartyAmbition;
            LongTermPartyAmbition = longTermPartyAmbition;
            PartyAwardedXP = partyAwardedXP;
        }

        public Party() 
        {
            Name = "";
            ShortTermPartyAmbition = "";
            LongTermPartyAmbition = "";
            PartyAwardedXP = 0;
        }
    }
}
