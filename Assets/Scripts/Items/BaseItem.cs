using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseItem
{
    private string itemName;
    private string itemDescription;
    private string itemID;

    public enum ItemTypes
    {
        EQUIPMENT,
        WEAPONS,
        SCROLL,
        POTION,
        CHEST
    }

    private ItemTypes itemType;

    public string ItemName
    {
        get { return itemName; }
        set { itemName = value; }
    }

    public string ItemDescription
    {
        get { return itemDescription; }
        set { itemDescription = value; }
    }

    public string ItemID
    {
        get { return itemID; }
        set { itemID = value; }
    }

    public ItemTypes ItemType
    {
        get { return itemType; }
        set { itemType = value; }
    }
}