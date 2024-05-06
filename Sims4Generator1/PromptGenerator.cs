namespace Sims4Generator1
{
    public class PromptGenerator
    {
        // generates the type of house to be built
        public string TypeOfHouse()
        {
            // different types of houses that can come up into the prompt
            string[] typeOfHouse =
            {
                "RANCH", "BARN", "MANSION", "COTTAGE", "BUNGALOW", "TREEHOUSE", "TOWNHOUSE", "MOBILE HOME", "BOATHOUSE", "CABIN"
            };

            // randomizer
            Random rand = new();
            int index = rand.Next(typeOfHouse.Length);
            return typeOfHouse[index];
        }
        
        // generates the color of the house
        public string ColorOfHouse()
        {
            // different colors of houses that can come up into the prompt
            string[] colorOfHouse =
            {
                "RED", "BROWN", "BLACK", "YELLOW", "BLUE", "GREEN", "GOLD", "SILVER", "PINK", "ORANGE", "PURPLE"
            };

            // randomizer
            Random rand = new();
            int index = rand.Next(colorOfHouse.Length);
            return colorOfHouse[index];
        }

        // generates the size of lot to build the house on
        public string LotSizeOfHouse()
        {
            // different lot sizes you can build on in the sims
            string[] lotSize =
            {
                "20x15", "30x30", "30x40", "40x40", "40x50", "60x60"
            };

            // randomizer
            Random rand = new();
            int index = rand.Next(lotSize.Length);
            return lotSize[index];
        }

        // generates the number of sims to be living in the household
        public string NumberOfSims()
        {
            // number of sims to live within the house
            string[] numberOfSims =
            {
                "1", "2", "3", "4", "5", "6", "7", "8"
            };

            // randomizer
            Random rand = new();
            int index = rand.Next(numberOfSims.Length);
            return numberOfSims[index];
        }
    }
}
