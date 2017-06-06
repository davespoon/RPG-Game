using UnityEngine;

public class SaveInformation : MonoBehaviour
{
    public static void SaveAllInformation()
    {
        PlayerPrefs.SetString("PlayerName", GameInformation.PlayerName);
        PlayerPrefs.SetInt("PlayerLevel", GameInformation.PlayerLevel);
        PlayerPrefs.SetInt("Resistance", GameInformation.Resistance);
        PlayerPrefs.SetInt("Intellect", GameInformation.Intellect);
        PlayerPrefs.SetInt("Strength", GameInformation.Strength);
        PlayerPrefs.SetInt("Dexterity", GameInformation.Dexterity);

        if (GameInformation.EquipmentOne != null)
        {
            PPSerialization.Save("EquipmentItemOne", GameInformation.EquipmentOne);
        }

        Debug.Log("SAVED ALL INFORMATION");
    }
}