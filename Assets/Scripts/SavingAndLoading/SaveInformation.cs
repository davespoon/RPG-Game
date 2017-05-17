using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveInformation : MonoBehaviour
{
    public static void SaveAllInformation()
    {
        PlayerPrefs.SetString("PlayerName", GameInformation.PlayerName);
        PlayerPrefs.SetInt("PlayerLevel", GameInformation.PlayerLevel);
        PlayerPrefs.SetInt("Stamina", GameInformation.Stamina);
        PlayerPrefs.SetInt("Intellect", GameInformation.Intellect);
        PlayerPrefs.SetInt("Strength", GameInformation.Strength);
        PlayerPrefs.SetInt("Endurance", GameInformation.Endurance);

        Debug.Log("SAVED ALL INFORMATION");
    }
}