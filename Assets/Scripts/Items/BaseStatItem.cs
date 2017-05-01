namespace Items
{
    public class BaseStatItem : BaseItem
    {
        private int stamina;
        private int endurance;
        private int strength;
        private int intellect;

        public int Stamina
        {
            get { return stamina; }
            set { stamina = value; }
        }

        public int Endurance
        {
            get { return endurance; }
            set { endurance = value; }
        }

        public int Strength
        {
            get { return strength; }
            set { strength = value; }
        }

        public int Intellect
        {
            get { return intellect; }
            set { intellect = value; }
        }
    }
}