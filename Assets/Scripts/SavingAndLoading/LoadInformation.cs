using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadInformation : MonoBehaviour
{
    public static void LoadAllInformation()
    {
        GameInformation.PlayerName = PlayerPrefs.GetString("PlayerName");
        GameInformation.PlayerLevel = PlayerPrefs.GetInt("PlayerLevel");
        GameInformation.Stamina = PlayerPrefs.GetInt("Stamina");
        GameInformation.Intellect = PlayerPrefs.GetInt("Intellect");
        GameInformation.Strength = PlayerPrefs.GetInt("Strength");
        GameInformation.Endurance = PlayerPrefs.GetInt("Endurance");
    }
}