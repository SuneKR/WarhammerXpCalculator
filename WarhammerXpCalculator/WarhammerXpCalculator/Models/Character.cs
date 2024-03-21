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

        public List<Characteristic> Characteristics { get; set; } = new List<Characteristic>();

        /*
        public Characteristic cWS { get; set; } = new Characteristic("Weapon Skill", "WS");
        
        public Characteristic cWS { get; set; } = await InitializeCharacteristic("Weapon Skill", "WS");

        public async Task<Characteristic> InitializeCharacteristic(string lname, string sname)
        {
            var response = await Http.PostAsJsonAsync("api/Characteristics", new Characteristic(lname, sname));
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Characteristic>();
            }
            return null;
        }
        //var response = await Http.PostAsJsonAsync("api/Characteristics", newCharacter);
        //api/Characteristics
        

        public Characteristic cBS { get; set; } = new Characteristic("Ballistic Skill", "BS");
        public Characteristic cS { get; set; } = new Characteristic("Strength", "S");
        public Characteristic cT { get; set; } = new Characteristic("Toughness", "T");
        public Characteristic cI { get; set; } = new Characteristic("Initiative", "I");
        public Characteristic cAg { get; set; } = new Characteristic("Agility", "Ag");
        public Characteristic cDex { get; set; } = new Characteristic("Dexterity", "Dex");
        public Characteristic cInt { get; set; } = new Characteristic("Intelligence", "Int");
        public Characteristic cWP { get; set; } = new Characteristic("Willpower", "WP");
        public Characteristic cFel { get; set; } = new Characteristic("Fellowship", "Fel");
        */

        //Skills
        public List<AdvancedSkill> AdvancedSkills { get; set; } = new List<AdvancedSkill>();
        public List<BasicSkill> BasicSkills { get; set; } = new List<BasicSkill>();
        
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

            Debug.WriteLine("Before InitializeCharacteristic()");

            InitializeCharacteristic("Weapon Skill", "WS");
            InitializeCharacteristic("Ballistic Skill", "BS");
            InitializeCharacteristic("Strength", "S");
            InitializeCharacteristic("Toughness", "T");
            InitializeCharacteristic("Initiative", "I");
            InitializeCharacteristic("Agility", "Ag");
            InitializeCharacteristic("Dexterity", "Dex");
            InitializeCharacteristic("Intelligence", "Int");
            InitializeCharacteristic("Willpower", "WP");
            InitializeCharacteristic("Fellowship", "Fel");



            /*
            Characteristics.Add(new Characteristic { LongName = "Weapon Skill", ShortName = "WS" });
            Characteristics.Add(new Characteristic { LongName = "Ballistic Skill", ShortName = "BS" });
            Characteristics.Add(new Characteristic { LongName = "Strength", ShortName = "S" });
            Characteristics.Add(new Characteristic { LongName = "Toughness", ShortName = "T" });
            Characteristics.Add(new Characteristic { LongName = "Initiative", ShortName = "I" });
            Characteristics.Add(new Characteristic { LongName = "Agility", ShortName = "Ag" });
            Characteristics.Add(new Characteristic { LongName = "Dexterity", ShortName = "Dex" });
            Characteristics.Add(new Characteristic { LongName = "Intelligence", ShortName = "Int" });
            Characteristics.Add(new Characteristic { LongName = "Willpower", ShortName = "WP" });
            Characteristics.Add(new Characteristic { LongName = "Fellowship", ShortName = "Fel" });
             * 
            Characteristics = new List<Characteristics>
            {
                new Characteristic { LongName = "Weapon Skill", ShortName = "WS" },
                new Characteristic { LongName = "Ballistic Skill", ShortName = "BS" },
                new Characteristic { LongName = "Strength", ShortName = "S" },
                new Characteristic { LongName = "Toughness", ShortName = "T" },
                new Characteristic { LongName = "Initiative", ShortName = "I" },
                new Characteristic { LongName = "Agility", ShortName = "Ag" },
                new Characteristic { LongName = "Dexterity", ShortName = "Dex" },
                new Characteristic { LongName = "Intelligence", ShortName = "Int" },
                new Characteristic { LongName = "Willpower", ShortName = "WP" },
                new Characteristic { LongName = "Fellowship", ShortName = "Fel" },
            };

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

        private async Task InitializeCharacteristic(string lname, string sname)
        {
            Debug.WriteLine($"InitializeCharacteristic({sname}) started");

            using (var Http = new HttpClient())
            {
                Http.BaseAddress = new Uri("http://localhost:5254/");
                Http.DefaultRequestHeaders.Accept.Clear();
                Http.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    var characteristicData = new { LongName = lname, ShortName = sname };
                    HttpResponseMessage response = await Http.PostAsJsonAsync("api/Chraracteristics", characteristicData);
                    response.EnsureSuccessStatusCode();

                    string InitializedCharacteristicAsString = await response.Content.ReadAsStringAsync();
                    Characteristic? InitializedCharacteristic = JsonSerializer.Deserialize<Characteristic>(InitializedCharacteristicAsString);
                    if (InitializedCharacteristic != null)
                    {
                        Characteristics.Add(InitializedCharacteristic);
                        Debug.WriteLine($"InitializeCharacteristic({sname}) added");
                    }
                    else { Debug.WriteLine($"InitializedCharacteristic == null"); }
                }
                catch (HttpRequestException e)
                {
                    Debug.WriteLine($@"Error with following error message: { e.Message }");
                }
            }
        }
    }

    


}
