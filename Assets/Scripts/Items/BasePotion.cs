using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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