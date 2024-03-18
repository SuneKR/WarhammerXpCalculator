using WarhammerXpCalculator.Models.Skills;

namespace WarhammerXpCalculator.Models
{
    public class Character
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public string Class { get; set; }
        public string Career { get; set; }
        public string CareerTier { get; set; }
        public string Size { get; set; }
        public int Age { get; set; }
        public string Height { get; set; }
        public string Hair { get; set; }
        public string Eyes { get; set; }
        public string StarSign { get; set; }

        //Characteristics
        public Characteristic WS { get; set; }
        public Characteristic BS { get; set; }
        public Characteristic S { get; set; }
        public Characteristic T { get; set; }
        public Characteristic I { get; set; }
        public Characteristic Ag { get; set; }
        public Characteristic Dex { get; set; }
        public Characteristic Int { get; set; }
        public Characteristic WP { get; set; }
        public Characteristic Fel { get; set; }

        //Basic skills
        //public BasicSkill ArtAny(string "Art", Characteristic Dex)
        List<BasicSkill> BasicSkills = new List<BasicSkill>
        { 
            new BasicSkill {Name = "Art", SkillCharacteristic = Dex},
        
        };

        public Character(string name, string species, string @class, string career, string careerTier, string size, int age, string height, string hair, string eyes, string starSign, Characteristic wS, Characteristic bS, Characteristic s, Characteristic t, Characteristic i, Characteristic ag, Characteristic dex, Characteristic @int, Characteristic wP, Characteristic fel)
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
            WS = wS;
            BS = bS;
            S = s;
            T = t;
            I = i;
            Ag = ag;
            Dex = dex;
            Int = @int;
            WP = wP;
            Fel = fel;
        }
    }

    
}
