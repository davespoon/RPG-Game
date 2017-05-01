using UnityEngine;

namespace Items
{
    public class CreateNewWeapon : MonoBehaviour
    {
        private BaseWeapon newWeapon;

        void Start()
        {
            CreateWeapon();
            Debug.Log(newWeapon.ItemDescription);
            Debug.Log("Weapon name: " + newWeapon.ItemName);
            Debug.Log("Weapon ID: " + newWeapon.ItemID);
            Debug.Log("Weapon type: " + newWeapon.WeaponType);
            Debug.Log("Weapon stamina: " + newWeapon.Stamina);
            Debug.Log("Weapon endurance: " + newWeapon.Endurance);
        }


        public void CreateWeapon()
        {
            newWeapon = new BaseWeapon
            {
                ItemName = "W" + Random.Range(1, 101),
                ItemDescription = "This is a new Weapon.",
                ItemID = Random.Range(1, 101),
                Stamina = Random.Range(1, 11),
                Endurance = Random.Range(1, 11),
                Strength = Random.Range(1, 11),
                SpellEffectID = Random.Range(1, 11)
            };
            ChooseWeaponType();
        }

        private void ChooseWeaponType()
        {
            int randomTemp = Random.Range(1, 7);

            switch (randomTemp)
            {
                case 1:
                    newWeapon.WeaponType = BaseWeapon.WeaponTypes.SWORD;
                    break;
                case 2:
                    newWeapon.WeaponType = BaseWeapon.WeaponTypes.STAFF;
                    break;
                case 3:
                    newWeapon.WeaponType = BaseWeapon.WeaponTypes.DAGGER;
                    break;
                case 4:
                    newWeapon.WeaponType = BaseWeapon.WeaponTypes.BOW;
                    break;
                case 5:
                    newWeapon.WeaponType = BaseWeapon.WeaponTypes.SHIELD;
                    break;
                case 6:
                    newWeapon.WeaponType = BaseWeapon.WeaponTypes.POLEARM;
                    break;
            }
        }
    }
}