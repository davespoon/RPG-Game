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
<<<<<<< HEAD
=======

        Debug.Log("Player name is: " + GameInformation.PlayerName);
        Debug.Log("Player level is : " + GameInformation.PlayerLevel);
        Debug.Log("Player dexterity is : " + GameInformation.Dexterity);
        Debug.Log("Player intellect is : " + GameInformation.Intellect);
        Debug.Log("Player stamina is : " + GameInformation.Resistance);
        Debug.Log("Player strength is : " + GameInformation.Strength);
>>>>>>> a493d3558f59f88378597c03a3572a5b1bf9c9be
    }
}