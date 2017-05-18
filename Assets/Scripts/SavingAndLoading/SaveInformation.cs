using UnityEngine;

namespace Assets.Scripts.SavingAndLoading
{
    public class SaveInformation : MonoBehaviour
    {
        public static void SaveAllInformation()
        {
            PlayerPrefs.SetString("PlayerName", GameInformation.GameInformation.PlayerName);
            PlayerPrefs.SetInt("PlayerLevel", GameInformation.GameInformation.PlayerLevel);
            PlayerPrefs.SetInt("Stamina", GameInformation.GameInformation.Stamina);
            PlayerPrefs.SetInt("Intellect", GameInformation.GameInformation.Intellect);
            PlayerPrefs.SetInt("Strength", GameInformation.GameInformation.Strength);
            PlayerPrefs.SetInt("Dexterity", GameInformation.GameInformation.Dexterity);

            Debug.Log("SAVED ALL INFORMATION");
        }
    }
}