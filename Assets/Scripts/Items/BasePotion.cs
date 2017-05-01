namespace Items
{
    public class BasePotion : BaseStatItem
    {
        public enum PotionTypes
        {
            HEALTH,
            ENERGY,
            STRENGTH,
            INETELLECT,
            VITALITY,
            ENDURANCE,
            SPEED
        }

        private PotionTypes potionType;
        private int spellEffectID;

        public PotionTypes PotionType
        {
            get { return potionType; }
            set { potionType = value; }
        }

        public int SpellEffectId
        {
            get { return spellEffectID; }
            set { spellEffectID = value; }
        }
    }
}