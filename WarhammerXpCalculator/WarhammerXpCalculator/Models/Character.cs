using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using WarhammerXpCalculator.Models.Skills;
using static System.Net.WebRequestMethods;
using System.Net.Http;
using System.Text.Json;
using System.Diagnostics;

namespace WarhammerXpCalculator.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Player { get; set; } = "";
        public virtual Party? Party { get; set; } = null;
        public string Name { get; set; } = "";
        public string Species { get; set; } = "";
        public string Class { get; set; } = "";
        public string Career { get; set; } = "";
        public string CareerTier { get; set; } = "";
        public string Status { get; set; } = "";
        public string Size { get; set; } = "";
        public int Age { get; set; }
        public string Height { get; set; } = "";
        public string Hair { get; set; } = "";
        public string Eyes { get; set; } = "";
        public string StarSign { get; set; } = "";

        //Characteristics
        public List<int> CharacteristicIds { get; set; } = new List<int>();

        //Skills
        public List<int> AdvancedSkillIds { get; set; } = new List<int>();
        public List<int> BasicSkillIds { get; set; } = new List<int>();
        
        //Talents
        public List<Talents> Talents { get; set; } = new List<Talents>();

        //Attributes
        public int FatePoints { get; set; }
        public int FortunePoints { get; set; }
        public int ResiliencePoints { get; set; }
        public int ResolvePoints { get; set; }
        public string Motivation { get; set; }
        public string ShortTermAmbition { get; set; }
        public string LongTermAmbition { get; set; }
        public int MovementMove { get; set; }
        public int MovementWalk { get; set; }
        public int MovementRun { get; set; }
        public int ExperienceGainIndividually{ get; set; }
        public int ExperienceSpent { get; set; }
        public int Wounds { get; set; }
       
        public Character(string name, string species, string @class, string career, string careerTier, string size, int age, string height, string hair, string eyes, string starSign, string motivation, string shortTermAmbition, string longTermAmbition, int fate, int resilience, int move)
        {
            Name = name;
            Species = species;
            Class = @class;
            Career = career;
            CareerTier = careerTier;
            Size = size;
            Age = age;
            Height = height;
            Hair = hair;
            Eyes = eyes;
            StarSign = starSign;
            FatePoints = fate;
            FortunePoints = fate;
            ResiliencePoints = resilience;
            ResolvePoints = resilience;
            MovementMove = move;
            MovementWalk = move * 2;
            MovementRun = move * 4;
            Motivation = motivation;
            ShortTermAmbition = shortTermAmbition;
            LongTermAmbition = longTermAmbition;

            if(CharacteristicIds == null || CharacteristicIds.Count != 10)
            {
                CharacteristicIds = new List<int>();
                SetupCharacteristics();
            }

            /*
            if(Characteristics.FirstOrDefault(c => c.ShortName == "WS") == null) { InitializeCharacteristic("Weapon Skill", "WS"); }
            if(Characteristics.FirstOrDefault(c => c.ShortName == "BS") == null) { InitializeCharacteristic("Ballistic Skill", "BS"); }
            if(Characteristics.FirstOrDefault(c => c.ShortName == "S") == null) { InitializeCharacteristic("Strength", "S"); }
            if(Characteristics.FirstOrDefault(c => c.ShortName == "S") == null) { InitializeCharacteristic("Toughness", "T"); }
            if (Characteristics.FirstOrDefault(c => c.ShortName == "I") == null) { InitializeCharacteristic("Initiative", "I"); }
            if(Characteristics.FirstOrDefault(c => c.ShortName == "Ag") == null) { InitializeCharacteristic("Agility", "Ag"); }
            if(Characteristics.FirstOrDefault(c => c.ShortName == "Dex") == null) { InitializeCharacteristic("Dexterity", "Dex"); }
            if(Characteristics.FirstOrDefault(c => c.ShortName == "Int") == null) { InitializeCharacteristic("Intelligence", "Int"); }
            if(Characteristics.FirstOrDefault(c => c.ShortName == "WP") == null) { InitializeCharacteristic("Willpower", "WP"); }
            if(Characteristics.FirstOrDefault(c => c.ShortName == "Fel") == null) { InitializeCharacteristic("Fellowship", "Fel"); }

            /*

            BasicSkills = new List<BasicSkill>
            {
                new BasicSkill { Name = "Art (Every)", SkillCharacteristic = cDex },
                new BasicSkill { Name = "Athletics", SkillCharacteristic = cAg },
                new BasicSkill { Name = "Bibery", SkillCharacteristic = cFel },
                new BasicSkill { Name = "Charm", SkillCharacteristic = cFel },
                new BasicSkill { Name = "Charm Animal", SkillCharacteristic = cWP },
                new BasicSkill { Name = "Climb", SkillCharacteristic = cS },
                new BasicSkill { Name = "Cool", SkillCharacteristic = cWP },
                new BasicSkill { Name = "Consume Alchohol", SkillCharacteristic = cT },
                new BasicSkill { Name = "Dodge", SkillCharacteristic = cAg },
                new BasicSkill { Name = "Drive", SkillCharacteristic = cAg },
                new BasicSkill { Name = "Endurance", SkillCharacteristic = cT },
                new BasicSkill { Name = "Enterain (Every)", SkillCharacteristic = cFel },
                new BasicSkill { Name = "Gamble", SkillCharacteristic = cInt },
                new BasicSkill { Name = "Gossip", SkillCharacteristic = cFel },
                new BasicSkill { Name = "Haggle", SkillCharacteristic = cFel },
                new BasicSkill { Name = "Intimidate", SkillCharacteristic = cS },
                new BasicSkill { Name = "Intuition", SkillCharacteristic = cI },
                new BasicSkill { Name = "Leadership", SkillCharacteristic = cFel },
                new BasicSkill { Name = "Melee (Basic)", SkillCharacteristic = cWS },
                new BasicSkill { Name = "Melee (Every)", SkillCharacteristic = cWS },
                new BasicSkill { Name = "Navigation", SkillCharacteristic = cI },
                new BasicSkill { Name = "Outdoor Survival", SkillCharacteristic = cInt },
                new BasicSkill { Name = "Perception", SkillCharacteristic = cI },
                new BasicSkill { Name = "Ride (Every)", SkillCharacteristic = cAg },
                new BasicSkill { Name = "Row", SkillCharacteristic = cS },
                new BasicSkill { Name = "Stealth (Every)", SkillCharacteristic = cAg },
                
            };
            */
        }
        public Character() : this("","","","","","",0,"","","","","","","",0,0,0) { }

        public string GetPartyName()
        {
            if (Party != null) { return Party.Name; }
            return "";
        }
        public int XpTotal()
        {
            if (Party != null) { return ExperienceGainIndividually + Party.PartyAwardedXP; }
            return ExperienceGainIndividually;
        }

        public int XpUnspent()
        {
            return XpTotal() - ExperienceSpent;
        }

        public async void SetupCharacteristics()
        {
            await InitializeCharacteristic("Weapon Skill", "WS");
            await InitializeCharacteristic("Ballistic Skill", "BS");
            await InitializeCharacteristic("Strength", "S");
            await InitializeCharacteristic("Toughness", "T");
            await InitializeCharacteristic("Initiative", "I");
            await InitializeCharacteristic("Agility", "Ag");
            await InitializeCharacteristic("Dexterity", "Dex");
            await InitializeCharacteristic("Intelligence", "Int");
            await InitializeCharacteristic("Willpower", "WP");
            await InitializeCharacteristic("Fellowship", "Fel");
        }

        private async Task InitializeCharacteristic(string lname, string sname)
        {
            using (var Http = new HttpClient())
            {
                Http.BaseAddress = new Uri("http://localhost:5254/");
                Http.DefaultRequestHeaders.Accept.Clear();
                Http.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    Characteristic NewCharacteristic = new Characteristic { LongName = lname, ShortName = sname, CharacterId = Id };
                    var response = await Http.PostAsJsonAsync("api/Characteristics", NewCharacteristic);
                    response.EnsureSuccessStatusCode();

                    
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Characteristic? InitializedCharacteristic = JsonSerializer.Deserialize<Characteristic>(responseBody);
                    if (InitializedCharacteristic != null) { CharacteristicIds.Add(InitializedCharacteristic.Id); }
                }
                catch (HttpRequestException e)
                {
                    Debug.WriteLine($@"Error with following error message: { e.Message }");

                }
            }
        }
    }

    


}
