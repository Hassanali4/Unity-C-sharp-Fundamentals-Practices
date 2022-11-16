using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDB: MonoBehaviour
{
    public List<Item> ItemDatabase = new List<Item>();

    public void AddItem(int itemID, Player player)
    {
        foreach (var item in ItemDatabase)
        {
            if (item.id == itemID)
            {
                player.inventory[0] = item;
                return;
            }
        }
        Debug.Log("Item does not exist!!");
    }
    public void RemoveItem(int itemID,Player player)
    {
        foreach (var item in ItemDatabase)
        {
            if (item.id == itemID)
            {
                player.inventory[0] = null;
                return;
            }
        }
        Debug.Log("Item does not exist!!!");
    }
}
