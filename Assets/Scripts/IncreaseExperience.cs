using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseExperience
{
    private static float _xpToGive;

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
            //player should be leveled up
            //CREATE LEVEL UP SCRIPT!!!
        }
    }
}