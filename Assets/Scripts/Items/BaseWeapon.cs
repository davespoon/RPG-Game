namespace Assets.Scripts.Items
{
    public class BaseWeapon : BaseStatItem
    {
        public enum WeaponTypes
        {
            Sword,
            Staff,
            Dagger,
            Bow,
            Shield,
            Polearm
        }

        public WeaponTypes WeaponType { get; set; }

        public int SpellEffectId { get; set; }
    }
}