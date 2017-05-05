using UnityEngine;

namespace Items
{
    public class CreateNewPotion : MonoBehaviour
    {
        private BasePotion _newPotion;
        private string[] _potionNames = new string[4] {"Common", "Greate", "Amazing", "Insane"};
        private string[] _potionDescription = new string[2] {"A new cool potion", "A new not-so-cool potion"};

        void Start()
        {
            CreatePotion();
            Debug.Log(_newPotion.ItemDescription);
            Debug.Log("Equipment name: " + _newPotion.ItemName);
            Debug.Log("Equipment ID: " + _newPotion.ItemId);
            Debug.Log("Equipment type: " + _newPotion.PotionType);
            Debug.Log("Equipment stamina: " + _newPotion.Stamina);
            Debug.Log("Equipment endurance: " + _newPotion.Endurance);
        }

        private void CreatePotion()
        {
            _newPotion = new BasePotion
            {
                ItemName = _potionNames[Random.Range(0, 3)] + " Potion",
                ItemId = Random.Range(0, 101),
                Stamina = Random.Range(1, 11),
                Endurance = Random.Range(1, 11),
                Strength = Random.Range(1, 11),
                SpellEffectId = Random.Range(1, 11),
                ItemDescription = _potionDescription[Random.Range(0, _potionDescription.Length)]
            };
            ChoosePotionType();
        }

        private void ChoosePotionType()
        {
            int randomTypeTemp = Random.Range(1, 8);
            switch (randomTypeTemp)
            {
                case 1:
                    _newPotion.PotionType = BasePotion.PotionTypes.Endurance;
                    break;
                case 2:
                    _newPotion.PotionType = BasePotion.PotionTypes.Energy;
                    break;
                case 3:
                    _newPotion.PotionType = BasePotion.PotionTypes.Health;
                    break;
                case 4:
                    _newPotion.PotionType = BasePotion.PotionTypes.Inetellect;
                    break;
                case 5:
                    _newPotion.PotionType = BasePotion.PotionTypes.Speed;
                    break;
                case 6:
                    _newPotion.PotionType = BasePotion.PotionTypes.Strength;
                    break;
                case 7:
                    _newPotion.PotionType = BasePotion.PotionTypes.Vitality;
                    break;
            }
        }
    }
}