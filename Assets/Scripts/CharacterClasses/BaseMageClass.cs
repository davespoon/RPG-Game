namespace Assets.Scripts.CharacterClasses
{
    public class BaseMageClass : BaseCharacterClass
    {
        public BaseMageClass()
        {
            CharacterClassName = "Mage";
            CharacterClassDescription = "A wise wizard, can cast spells.";
            Stamina = 12;
            Dexterity = 14;
            Strength = 10;
            Intellect = 15;
        }
    }
}