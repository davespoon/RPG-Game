using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseScroll : BaseItem
{
    private int spellEffectID;

    public int SpellEffectId
    {
        get { return spellEffectID; }
        set { spellEffectID = value; }
    }
}