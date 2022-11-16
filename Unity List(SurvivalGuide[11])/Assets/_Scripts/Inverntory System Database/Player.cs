using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Item[] inventory = new Item[10];

    private ItemDB _itemDatabase;

    private void Start()
    {
        _itemDatabase = GameObject.Find("ItemDB").GetComponent<ItemDB>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //request item by ID
            _itemDatabase.AddItem(0,this);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            //remove item by ID
            _itemDatabase.RemoveItem(0,this);
        }
    }
}
