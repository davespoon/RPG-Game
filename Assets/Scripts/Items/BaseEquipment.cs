public class BaseEquipment : BaseStatItem
{
    public enum EquipmentTypes
    {
        Head,
        Chest,
        Shoulders,
        Legs,
        Feet,
        Neck,
        Earring,
        Ring
    }

    public EquipmentTypes EquipmentType { get; set; }

    public int SpellEffectId { get; set; }
}