namespace CharacterClasses
{
    public class BaseWarriorClass : BaseCharacterClass
    {
        public BaseWarriorClass()
        {
            CharacterClassName = "Warrior";
            CharacterClassDescription = "A strong and powerfull hero.";
            Stamina = 15;
            Endurance = 12;
            Strength = 14;
            Intellect = 10;
        }
    }
}