using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLoading : MonoBehaviour
{
    void Start()
    {
        LoadInformation.LoadAllInformation();

        Debug.Log("Player name is: " + GameInformation.PlayerName);
        Debug.Log("Player level is : " + GameInformation.PlayerLevel);
        Debug.Log("Player dexterity is : " + GameInformation.Dexterity);
        Debug.Log("Player intellect is : " + GameInformation.Intellect);
        Debug.Log("Player stamina is : " + GameInformation.Resistance);
        Debug.Log("Player strength is : " + GameInformation.Strength);
    }

    void Update()
    {
    }
}