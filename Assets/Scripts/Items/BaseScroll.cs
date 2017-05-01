namespace Items
{
    public class BaseScroll : BaseItem
    {
        private int spellEffectID;

        public int SpellEffectId
        {
            get { return spellEffectID; }
            set { spellEffectID = value; }
        }
    }
}