using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class IncreaseExperience
{
    private static float _xpToGive;
    private static LevelUp _leveUpScript = new LevelUp();

    public static void AddExperience()
    {
        _xpToGive = GameInformation.PlayerLevel * 100;
        GameInformation.CurrentXp += _xpToGive;

        CheckIfPlayerCanBeLeveled();
    }

    public static void AddExperienceFromBattleLose()
    {
        _xpToGive = GameInformation.PlayerLevel * 10;
        GameInformation.CurrentXp += _xpToGive;

        CheckIfPlayerCanBeLeveled();
    }

    private static void CheckIfPlayerCanBeLeveled()
    {
        if (GameInformation.CurrentXp >= GameInformation.RequiredXp)
        {
            _leveUpScript.LevelUpCharacter();
        }
    }
}