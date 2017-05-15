using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavingAndLoading : MonoBehaviour
{
    public static void SaveAllInformation()
    {
        PlayerPrefs.SetInt("PlayerLevel", GameInformation.PlayerLevel);
        PlayerPrefs.SetString("PlayerName", GameInformation.PlayerName);
        PlayerPrefs.SetString("PlayerName", GameInformation.PlayerName);

    }
}