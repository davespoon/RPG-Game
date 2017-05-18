using UnityEngine;

namespace Assets.Scripts.Items
{
    public class CreateNewEquipment : MonoBehaviour
    {
        private BaseEquipment _newEquipment;
        private string[] _itemNames = new string[4] {"Common", "Great", "Amazing", "Insane"};
        private string[] _itemDescription = new string[2] {"A new cool Item", "A new not-so-cool Item"};

        void Start()
        {
            CreateEquipment();
            Debug.Log(_newEquipment.ItemDescription);
            Debug.Log("Equipment name: " + _newEquipment.ItemName);
            Debug.Log("Equipment ID: " + _newEquipment.ItemId);
            Debug.Log("Equipment type: " + _newEquipment.EquipmentType);
            Debug.Log("Equipment stamina: " + _newEquipment.Stamina);
            Debug.Log("Equipment endurance: " + _newEquipment.Dexterity);
        }

        private void CreateEquipment()
        {
            _newEquipment = new BaseEquipment
            {
                ItemName = _itemNames[Random.Range(0, 3)] + " Item",
                ItemId = Random.Range(0, 101),
                Stamina = Random.Range(1, 11),
                Dexterity = Random.Range(1, 11),
                Strength = Random.Range(1, 11),
                SpellEffectId = Random.Range(1, 11),
                ItemDescription = _itemDescription[Random.Range(0, _itemDescription.Length)]
            };
            ChooseItemType();
        }

        private void ChooseItemType()
        {
            int randomTypeTemp = Random.Range(1, 9);
            switch (randomTypeTemp)
            {
                case 1:
                    _newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.Head;
                    break;
                case 2:
                    _newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.Shoulders;
                    break;
                case 3:
                    _newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.Chest;
                    break;
                case 4:
                    _newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.Legs;
                    break;
                case 5:
                    _newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.Feet;
                    break;
                case 6:
                    _newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.Neck;
                    break;
                case 7:
                    _newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.Earring;
                    break;
                case 8:
                    _newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.Ring;
                    break;
            }
        }
    }
}