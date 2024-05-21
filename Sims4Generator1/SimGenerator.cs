namespace Sims4Generator1
{
    public class SimGenerator
    {
        // generates the age of the sim
        public string AgeOfSim()
        {
            // different ages the sim could be
            string[] ageOfSim =
            {
                "BABY", "INFANT", "TODDLER", "CHILD", "TEEN", "YOUNG ADULT", "ADULT", "ELDER"
            };

            // randomizer
            Random rand = new();
            int index = rand.Next(ageOfSim.Length);
            return ageOfSim[index];
        }

        // generates the style of the sim
        public string StyleOfSim()
        {
            // different aesthetic for the sim
            string[] styleOfSim =
            {
                "GOTH", "SPORTY", "ARTSY", "EMO", "PUNK", "BASIC", "OUTDOORSY", "GRANOLA", "PREPPY", "BOHO", "GRUNGE"
            };

            // randomizer
            Random rand = new();
            int index = rand.Next(styleOfSim.Length);
            return styleOfSim[index];
        }

        // generates the hair color for the sim
        public string ColorOfHair()
        {
            // different hair colors the sim could have
            string[] colorOfHair =
            {
                "BLACK", "BROWN", "BLONDE", "LIGHT BROWN", "DIRTY BLONDE", "RED", "BLUE", "PURPLE", "PINK"
            };

            // randomizer
            Random rand = new();
            int index = rand.Next(colorOfHair.Length);
            return colorOfHair[index];
        }
    }
}

