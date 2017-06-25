using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayCreatePlayerFunctions : MonoBehaviour
{
    private int classSelection;
    private string[] classSelectionNames = {"Mage", "Warrior", "Archer"};

    public void DisplayClassSelections()
    {
        classSelection = GUI.SelectionGrid(new Rect(50, 50, 300, 150), classSelection, classSelectionNames, 1);
        GUI.Label(new Rect(450, 50, 300, 300), FindClassDescription(classSelection));
        GUI.Label(new Rect(450, 100, 300, 300), FindClassStatValues(classSelection));
    }

    public void DisplayStatAlocation()
    {
    }

    public void DisplayFinalSetUp()
    {
    }

    public void DisplayMainItems()
    {
        GUI.Label(new Rect(Screen.width / 2, 20, 250, 250), "CREATE NEW PLAYER");
    }

    private string FindClassDescription(int classSelection)
    {
        if (classSelection == 0)
        {
            BaseCharacterClass tempClass = new BaseMageClass();
            return tempClass.CharacterClassDescription;
        }
        else if (classSelection == 1)
        {
            BaseCharacterClass tempClass = new BaseWarriorClass();
            return tempClass.CharacterClassDescription;
        }
        else if (classSelection == 2)
        {
            BaseCharacterClass tempClass = new BaseArcherClass();
            return tempClass.CharacterClassDescription;
        }
        return "NO CLASS FOUND";
    }

    private string FindClassStatValues(int classSelection)
    {
        if (classSelection == 0)
        {
            BaseCharacterClass tempClass = new BaseMageClass();
            string tempStats = "Vitality: " + tempClass.Vitality + "\nInellect: " + tempClass.Intellect +
                               "\nResistance: " + tempClass.Resitance + "\nDexterity: " + tempClass.Dexterity +
                               "\nStrength: " + tempClass.Strength;
            return tempStats;
        }
        return " NO STATS FOUND";
    }
}