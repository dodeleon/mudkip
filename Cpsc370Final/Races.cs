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

        // Uncomment if you bring back Languages:
        // private List<string> _languages;
        // public List<string> Languages
        // {
        //     get => _languages;
        //     set => _languages = value;
        // }

        // -------------------------
        // Constructors
        // -------------------------
        
        /// <summary>
        /// Parameterless constructor (optional).
        /// Useful if you want to create a Race
        /// without immediately specifying details.
        /// </summary>
        public Race()
        {
        }

        /// <summary>
        /// Main constructor that initializes all fields.
        /// </summary>
        public Race(string name, int? approximateMaxAge, string alignmentDescription,
                    string sizeCategory, string speedDescription)
        {
            _name = name;
            _approximateMaxAge = approximateMaxAge;
            _alignmentDescription = alignmentDescription;
            _sizeCategory = sizeCategory;
            _speedDescription = speedDescription;
        }

        // -------------------------------
        // Static Properties for Races
        // -------------------------------
        // NOTE: Below, we're using the new constructor rather than object initializers,
        // which is often cleaner.

        public static Race Elf => new Race(
            name: "Elf",
            approximateMaxAge: 750,
            alignmentDescription: "Elves love freedom, variety, and self-expression, " +
                                  "leaning toward the gentler aspects of chaos. They value " +
                                  "and protect others' freedom as well as their own, and " +
                                  "are good more often than not. Drow are often evil.",
            sizeCategory: "Medium",
            speedDescription: "Your base walking speed is 30 feet."
        );

        public static Race Dwarf => new Race(
            name: "Dwarf",
            approximateMaxAge: 350,
            alignmentDescription: "Most dwarves are lawful, believing in the benefits of " +
                                  "a well-ordered society. They tend toward good, with a " +
                                  "strong sense of fair play and justice.",
            sizeCategory: "Medium",
            speedDescription: "Your base walking speed is 25 feet. It is not reduced by wearing heavy armor."
        );

        public static Race Gnome => new Race(
            name: "Gnome",
            approximateMaxAge: 500,
            alignmentDescription: "Gnomes are generally good. Those leaning toward Law are " +
                                  "scholars and inventors, while those leaning toward Chaos " +
                                  "are tricksters and minstrels. They are light-hearted and " +
                                  "favor harmless pranks over vicious schemes.",
            sizeCategory: "Small",
            speedDescription: "Your base walking speed is 25 feet."
        );

        public static Race Dragonborn => new Race(
            name: "Dragonborn",
            approximateMaxAge: 80,
            alignmentDescription: "Dragonborn often choose between extremes, aligning " +
                                  "with either Bahamut (good) or Tiamat (evil). Many are " +
                                  "good, but evil dragonborn can be quite terrible.",
            sizeCategory: "Medium",
            speedDescription: "Your base walking speed is 30 feet."
        );

        public static Race HalfOrc => new Race(
            name: "Half-Orc",
            approximateMaxAge: 75,
            alignmentDescription: "Half-orcs inherit a tendency toward chaos from their orcish " +
                                  "side. Many are evil if raised among orcs.",
            sizeCategory: "Medium",
            speedDescription: "Your base walking speed is 30 feet."
        );

        public static Race Halfling => new Race(
            name: "Halfling",
            approximateMaxAge: 150,
            alignmentDescription: "Most halflings are lawful good, kind-hearted, and community-oriented. " +
                                  "They detest oppression and cruelty.",
            sizeCategory: "Small",
            speedDescription: "Your base walking speed is 25 feet."
        );

        public static Race Human => new Race(
            name: "Human",
            approximateMaxAge: 100,
            alignmentDescription: "Humans tend toward no particular alignment. The best and worst are found among them.",
            sizeCategory: "Medium",
            speedDescription: "Your base walking speed is 30 feet."
        );

        public static Race Tiefling => new Race(
            name: "Tiefling",
            approximateMaxAge: 110,
            alignmentDescription: "Tieflings often face mistrust, and many drift toward evil. " +
                                  "They also tend toward chaotic alignments due to independent natures.",
            sizeCategory: "Medium",
            speedDescription: "Your base walking speed is 30 feet."
        );
    }
}
