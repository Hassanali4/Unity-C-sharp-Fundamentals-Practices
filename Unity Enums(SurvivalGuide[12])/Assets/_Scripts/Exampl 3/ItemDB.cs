using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDB : MonoBehaviour
{
    public List<Item> item = new List<Item>();

    private void Start()
    {
        item[1].Action();
    }
}
