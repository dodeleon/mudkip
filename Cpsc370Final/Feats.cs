namespace Cpsc370Final
{
    public class Feat
    {
        public string FeatName { get; set; }
        public string FeatDescription { get; set; }

        public Feat(string featName, string featDescription)
        {
            FeatName = featName;
            FeatDescription = featDescription;
        }
    }
}