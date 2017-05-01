using System.Collections;
using System.Collections.Generic;
using Items;
using UnityEngine;

public class CreateNewEquipment : MonoBehaviour
{
    private BaseEquipment newEquipment;
    private string[] itemNames = new string[4] {"Common", "Great", "Amazing", "Insane"};
    private string[] itemDescription = new string[2] {"A new cool Item", "A new not-so-cool Item"};

    void Start()
    {
        CreateEquipment();
        Debug.Log(newEquipment.ItemDescription);
        Debug.Log("Equipment name: " + newEquipment.ItemName);
        Debug.Log("Equipment ID: " + newEquipment.ItemID);
        Debug.Log("Equipment type: " + newEquipment.EquipmentType);
        Debug.Log("Equipment stamina: " + newEquipment.Stamina);
        Debug.Log("Equipment endurance: " + newEquipment.Endurance);
    }

    private void CreateEquipment()
    {
        newEquipment = new BaseEquipment
        {
            ItemName = itemNames[Random.Range(0, 3)] + " Item",
            ItemID = Random.Range(0, 101),
            Stamina = Random.Range(1, 11),
            Endurance = Random.Range(1, 11),
            Strength = Random.Range(1, 11),
            SpellEffectID = Random.Range(1, 11),
            ItemDescription = itemDescription[Random.Range(0, itemDescription.Length)]
        };

        ChooseItemType();
    }

    private void ChooseItemType()
    {
        int randomTypeTemp = Random.Range(1, 9);
        switch (randomTypeTemp)
        {
            case 1:
                newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.HEAD;
                break;
            case 2:
                newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.SHOULDERS;
                break;
            case 3:
                newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.CHEST;
                break;
            case 4:
                newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.LEGS;
                break;
            case 5:
                newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.FEET;
                break;
            case 6:
                newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.NECK;
                break;
            case 7:
                newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.EARRING;
                break;
            case 8:
                newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.RING;
                break;
        }
    }
}