using System.Collections;
using System.Collections.Generic;
using CharacterClasses;
using UnityEngine;

public class TestGUI : MonoBehaviour
{
    private BaseCharacterClass classPrimo = new BaseMageClass();
    private BaseCharacterClass classSecundo = new BaseWarriorClass();

    private void OnGUI()
    {
        GUILayout.Label(classPrimo.CharacterClassName);
        GUILayout.Label(classPrimo.CharacterClassDescription);
        GUILayout.Label(classPrimo.Intellect.ToString());


        GUILayout.Label(classSecundo.CharacterClassName);
        GUILayout.Label(classSecundo.CharacterClassDescription);
    }
}