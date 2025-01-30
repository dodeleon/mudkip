using System.Collections.Generic;

namespace Cpsc370Final
{
    public class Race
    {
        // -------------------------
        // Private Fields
        // -------------------------
        private string _name;
        private int? _approximateMaxAge;
        private string _alignmentDescription;
        private string _sizeCategory;
        private string _speedDescription;
        //private List<string> _languages;

        // -------------------------
        // Public Properties
        // -------------------------
        public string Name
        {
            get => _name;
            set => _name = value;
        }

       
    
        public int? ApproximateMaxAge
        {
            get => _approximateMaxAge;
            set => _approximateMaxAge = value;
        }

        public string AlignmentDescription
        {
            get => _alignmentDescription;
            set => _alignmentDescription = value;
        }
        

        public string SizeCategory
        {
            get => _sizeCategory;
            set => _sizeCategory = value;
        }

        public string SpeedDescription
        {
            get => _speedDescription;
            set => _speedDescription = value;
        }

        // public List<string> Languages
        // {
        //     get => _languages;
        //     set => _languages = value;
        // }

        // -------------------------------
        // Static Properties for Races
        // -------------------------------

        public static Race Elf => new Race
        {
            _name = "Elf",
            
            _approximateMaxAge = 750,
            _alignmentDescription = "Elves love freedom, variety, and self-expression, so they lean strongly " +
                                    "towards the gentler aspects of chaos. They value and protect others' freedom " +
                                    "as well as their own, and are good more often than not. Drow are often evil.",
            _sizeCategory = "Medium",
            _speedDescription = "Your base walking speed is 30 feet.",
            //_languages = new List<string> { "Common", "Elvish" }
        };

        public static Race Dwarf => new Race
        {
            _name = "Dwarf",
           
            _approximateMaxAge = 350,
            _alignmentDescription = "Most dwarves are lawful, believing in the benefits of a well-ordered society. " +
                                    "They tend toward good, with a strong sense of fair play and justice.",
            _sizeCategory = "Medium",
            _speedDescription = "Your base walking speed is 25 feet. It is not reduced by wearing heavy armor.",
            //_languages = new List<string> { "Common", "Dwarvish" }
        };

        public static Race Gnome => new Race
        {
            _name = "Gnome",
            _approximateMaxAge = 500,
            _alignmentDescription = "Gnomes are generally good. Those leaning toward Law are scholars and inventors, " +
                                    "while those leaning toward Chaos are tricksters and minstrels. They are light-hearted " +
                                    "and favor harmless pranks over vicious schemes.",
            _sizeCategory = "Small",
            _speedDescription = "Your base walking speed is 25 feet.",
            //_languages = new List<string> { "Common", "Gnomish" }
        };

        public static Race Dragonborn => new Race
        {
            _name = "Dragonborn",
            
            _approximateMaxAge = 80,
            _alignmentDescription = "Dragonborn often choose between extremes, aligning with either Bahamut (good) " +
                                    "or Tiamat (evil). Many are good, but evil dragonborn can be quite terrible.",
            _sizeCategory = "Medium",
            _speedDescription = "Your base walking speed is 30 feet.",
            //_languages = new List<string> { "Common", "Draconic" }
        };

        public static Race HalfOrc => new Race
        {
            _name = "Half-Orc",
          
            
            _approximateMaxAge = 75,
            _alignmentDescription = "Half-orcs inherit a tendency toward chaos from their orcish side. " +
                                    "Many are evil if raised among orcs.",
            _sizeCategory = "Medium",
            _speedDescription = "Your base walking speed is 30 feet.",
            //_languages = new List<string> { "Common", "Orc" }
        };

        public static Race Halfling => new Race
        {
            _name = "Halfling",
            _approximateMaxAge = 150, // mid 2nd century 
            _alignmentDescription = "Most halflings are lawful good, kind-hearted, and community-oriented. " +
                                    "They detest oppression and cruelty.",
            _sizeCategory = "Small",
            _speedDescription = "Your base walking speed is 25 feet.",
            //_languages = new List<string> { "Common", "Halfling" }
        };

        public static Race Human => new Race
        {
            _name = "Human",
        
            _approximateMaxAge = 100,
            _alignmentDescription = "Humans tend toward no particular alignment. The best and worst are found among them.",
            _sizeCategory = "Medium",
            _speedDescription = "Your base walking speed is 30 feet.",
            // _languages = new List<string>
            // {
            //     "Common",
            //     "[One extra language of your choice]"
            // }
        };

        public static Race Tiefling => new Race
        {
            _name = "Tiefling",
            _approximateMaxAge = 110, // Example: "a few years longer" than humans
            _alignmentDescription = "Tieflings often face mistrust, and many drift toward evil. " +
                                    "They also tend toward chaotic alignments due to independent natures.",
            _sizeCategory = "Medium",
            _speedDescription = "Your base walking speed is 30 feet.",
            //_languages = new List<string> { "Common", "Infernal" }
        };
    }
}
