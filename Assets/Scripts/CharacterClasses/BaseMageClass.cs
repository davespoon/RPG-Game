using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMageClass : BaseCharacterClass
{
    public BaseMageClass()
    {
        CharacterClassName = "Mage";
        CharacterClassDescription = "A wise wizard, can cast spells.";
        Stamina = 12;
        Endurance = 14;
        Strength = 10;
        Intellect = 15;
    }
}