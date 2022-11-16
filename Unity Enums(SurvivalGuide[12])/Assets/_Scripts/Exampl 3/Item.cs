using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Item 
{
    public string name;
    public int id;
    Sprite icon;

    public enum ItemType
    {
        Non,
        Weapon,
        Consumable,
    }

    public ItemType itemType;

    public void Action()
    {
        Debug.Log("This is " + itemType);
    }
}
