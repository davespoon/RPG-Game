using UnityEngine;

public class SaveInformation : MonoBehaviour
{
    public static void SaveAllInformation()
    {
        PlayerPrefs.SetString(" PlayerName", GameInformation.PlayerName);
        PlayerPrefs.SetInt("PlayerLevel", GameInformation.PlayerLevel);
        PlayerPrefs.SetInt("Stamina", GameInformation.Stamina);
        PlayerPrefs.SetInt("Intellect", GameInformation.Intellect);
        PlayerPrefs.SetInt("Strength", GameInformation.Strength);
        PlayerPrefs.SetInt("Dexterity", GameInformation.Dexterity);

        Debug.Log("SAVED ALL INFORMATION");
    }
}