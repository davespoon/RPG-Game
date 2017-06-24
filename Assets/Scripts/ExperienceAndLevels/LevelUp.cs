using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUp
{
    public int MaxPlayerLevel = 50;

    public void LevelUpCharacter()
    {
        if (GameInformation.CurrentXp > GameInformation.RequiredXp)
        {
            GameInformation.CurrentXp -= GameInformation.RequiredXp;
        }
        else GameInformation.CurrentXp = 0;

        if (GameInformation.PlayerLevel < MaxPlayerLevel) GameInformation.PlayerLevel++;
        else GameInformation.PlayerLevel = MaxPlayerLevel;


        DetermineRequiredXP();
    }

    private void DetermineRequiredXP()
    {
        float temp = (GameInformation.PlayerLevel * 1000) + 250;
        GameInformation.RequiredXp = temp;
    }
}