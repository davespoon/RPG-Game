using Assets.Scripts.CharacterClasses;
using UnityEngine;

namespace Assets.Scripts.GameInformation
{
    public class GameInformation : MonoBehaviour
    {
        public static string PlayerName { get; set; }
        public static int PlayerLevel { get; set; }
        public static BaseCharacterClass PlayerClass { get; set; }
        public static int Stamina { get; set; }
        public static int Dexterity { get; set; }
        public static int Intellect { get; set; }
        public static int Strength { get; set; }

        private void Awake()
        {
            DontDestroyOnLoad(transform.gameObject);
        }
    }
}