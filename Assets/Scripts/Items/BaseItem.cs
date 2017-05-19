public class BaseItem
{
    public enum ItemTypes
    {
        Equipment,
        Weapons,
        Scroll,
        Potion,
        Chest
    }

    public string ItemName { get; set; }

    public string ItemDescription { get; set; }

    public int ItemId { get; set; }

    public ItemTypes ItemType { get; set; }
}