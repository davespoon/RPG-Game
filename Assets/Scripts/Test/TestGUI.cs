using UnityEngine;

public class TestGui : MonoBehaviour
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