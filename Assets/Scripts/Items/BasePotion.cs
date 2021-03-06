﻿public class BasePotion : BaseStatItem
{
    public enum PotionTypes
    {
        Health,
        Energy,
        Strength,
        Inetellect,
        Vitality,
        Dexterity,
        Speed
    }

    public PotionTypes PotionType { get; set; }

    public int SpellEffectId { get; set; }
}