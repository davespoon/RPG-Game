using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePlayerGUI : MonoBehaviour
{
    public enum PlayerCreationStates
    {
        ClassSelection,
        StatAlocation,
        FinalSetUp
    }

    public static PlayerCreationStates currentState;
    private DisplayCreatePlayerFunctions displayFunctions = new DisplayCreatePlayerFunctions();

    void Start()
    {
        currentState = PlayerCreationStates.ClassSelection;
    }

    void Update()
    {
        switch (currentState)
        {
            case PlayerCreationStates.ClassSelection:
                Debug.Log("Class selection");
                break;
            case PlayerCreationStates.StatAlocation:
                Debug.Log("Class selection");
                break;
            case PlayerCreationStates.FinalSetUp:
                Debug.Log("Class selection");
                break;
        }
    }

    void OnGUI()
    {
        if (currentState == PlayerCreationStates.ClassSelection)
        {
            displayFunctions.DisplayClassSelections();
            Debug.Log("Display player selection function");
        }

        if (currentState == PlayerCreationStates.StatAlocation)
        {
            displayFunctions.DisplayStatAlocation();
            Debug.Log("Display player stat alocation function");
        }

        if (currentState == PlayerCreationStates.FinalSetUp)
        {
            displayFunctions.DisplayFinalSetUp();
            Debug.Log("Display player final setup function");
        }
    }
}