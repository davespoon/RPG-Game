using UnityEngine;

namespace Assets.Scripts.SavingAndLoading
{
    public class LoadInformation : MonoBehaviour
    {
        public static void LoadAllInformation()
        {
            GameInformation.GameInformation.PlayerName = PlayerPrefs.GetString("PlayerName");
            GameInformation.GameInformation.PlayerLevel = PlayerPrefs.GetInt("PlayerLevel");
            GameInformation.GameInformation.Stamina = PlayerPrefs.GetInt("Stamina");
            GameInformation.GameInformation.Intellect = PlayerPrefs.GetInt("Intellect");
            GameInformation.GameInformation.Strength = PlayerPrefs.GetInt("Strength");
            GameInformation.GameInformation.Dexterity = PlayerPrefs.GetInt("Dexterity");
        }
    }
}