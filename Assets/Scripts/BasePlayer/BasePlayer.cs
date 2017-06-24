public class BasePlayer
{
    public string PlayerName { get; set; }

    public int PlayerLevel { get; set; }

    public BaseCharacterClass PlayerClass { get; set; }

    public int Vitality { get; set; }

    public int Intellect { get; set; }
    
    public int Resistance { get; set; }
    
    public int Dexterity { get; set; }
    
    public int Strength { get; set; }

    public int Gold { get; set; }

    public int CurrentXP { get; set; }

    public int RequiredXP { get; set; }
}