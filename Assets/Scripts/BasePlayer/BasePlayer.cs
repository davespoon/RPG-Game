using System.Collections;
using System.Collections.Generic;
using CharacterClasses;
using UnityEngine;

public class BasePlayer
{
    public string PlayerName { get; set; }
    public int PlayerLevel { get; set; }
    public BaseCharacterClass PlayerClass { get; set; }
    public int Stamina { get; set; }
    public int Endurance { get; set; }
    public int Intellect { get; set; }
    public int Strenght { get; set; }
}