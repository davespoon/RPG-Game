using UnityEngine;

public class LoadInformation : MonoBehaviour
{
    public static void LoadAllInformation()
    {
        GameInformation.PlayerName = PlayerPrefs.GetString("PlayerName");
        GameInformation.PlayerLevel = PlayerPrefs.GetInt("PlayerLevel");
        GameInformation.Resistance = PlayerPrefs.GetInt("Resistance");
        GameInformation.Intellect = PlayerPrefs.GetInt("Intellect");
        GameInformation.Strength = PlayerPrefs.GetInt("Strength");
        GameInformation.Dexterity = PlayerPrefs.GetInt("Dexterity");
        GameInformation.Gold = PlayerPrefs.GetFloat("Gold");

        if (PlayerPrefs.GetString("EquipmentItemOne") != null)
        {
            GameInformation.EquipmentOne = (BaseEquipment) PPSerialization.Load("EquipmentItemOne");
        }
    }
}