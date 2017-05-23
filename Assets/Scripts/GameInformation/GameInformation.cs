using UnityEngine;

public class GameInformation : MonoBehaviour
{
    public static BaseEquipment EquipmentOne { get; set; }
    public static BaseCharacterClass PlayerClass { get; set; }
    public static string PlayerName { get; set; }
    public static int PlayerLevel { get; set; }
    public static int Stamina { get; set; }
    public static int Dexterity { get; set; }
    public static int Intellect { get; set; }
    public static int Strength { get; set; }
    public static float CurrentXp { get; set; }
    public static float RequiredXp { get; set; }

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}