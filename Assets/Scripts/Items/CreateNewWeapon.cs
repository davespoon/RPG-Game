using UnityEngine;

namespace Assets.Scripts.Items
{
    public class CreateNewWeapon : MonoBehaviour
    {
        private BaseWeapon _newWeapon;

        void Start()
        {
            CreateWeapon();
            Debug.Log(_newWeapon.ItemDescription);
            Debug.Log("Weapon name: " + _newWeapon.ItemName);
            Debug.Log("Weapon ID: " + _newWeapon.ItemId);
            Debug.Log("Weapon type: " + _newWeapon.WeaponType);
            Debug.Log("Weapon stamina: " + _newWeapon.Stamina);
            Debug.Log("Weapon endurance: " + _newWeapon.Dexterity);
        }


        public void CreateWeapon()
        {
            _newWeapon = new BaseWeapon
            {
                ItemName = "W" + Random.Range(1, 101),
                ItemDescription = "This is a new Weapon.",
                ItemId = Random.Range(1, 101),
                Stamina = Random.Range(1, 11),
                Dexterity = Random.Range(1, 11),
                Strength = Random.Range(1, 11),
                SpellEffectId = Random.Range(1, 11)
            };
            ChooseWeaponType();
        }

        private void ChooseWeaponType()
        {
            int randomTemp = Random.Range(1, 7);

            switch (randomTemp)
            {
                case 1:
                    _newWeapon.WeaponType = BaseWeapon.WeaponTypes.Sword;
                    break;
                case 2:
                    _newWeapon.WeaponType = BaseWeapon.WeaponTypes.Staff;
                    break;
                case 3:
                    _newWeapon.WeaponType = BaseWeapon.WeaponTypes.Dagger;
                    break;
                case 4:
                    _newWeapon.WeaponType = BaseWeapon.WeaponTypes.Bow;
                    break;
                case 5:
                    _newWeapon.WeaponType = BaseWeapon.WeaponTypes.Shield;
                    break;
                case 6:
                    _newWeapon.WeaponType = BaseWeapon.WeaponTypes.Polearm;
                    break;
            }
        }
    }
}