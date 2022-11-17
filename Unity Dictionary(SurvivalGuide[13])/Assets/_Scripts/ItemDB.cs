using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDB : MonoBehaviour
{
    public List<item> items = new List<item>();

    public Dictionary<int, item> itemDictionary = new Dictionary<int, item>();

    private void Start()
    {

        item sword = new item();
        sword.name = "Sword";
        sword.id = 0;

        item bread = new item();
        bread.name = "Bread";
        bread.id = 1;
        
        item Cape = new item();
        Cape.name = "Cape";
        Cape.id = 2;

        itemDictionary.Add(0, sword);
        itemDictionary.Add(1, bread);
        itemDictionary.Add(2, Cape);

        //As there must be questoin in your mind like why do i need dictionary this was easily doable with List
        //but with List i need to sort through the List or Array and then find the right one needed.
        //Dictionary makes it very easy to get this item using its Key value pairs by just passing the keys.

        //how to accessing value of a Dictionary
        var item = itemDictionary[0];

        //how to loop through a Dictionary using a Key and Value paire generic method.
        /*foreach(KeyValuePair<int, item> Item in itemDictionary)
        {
            Debug.Log("Key :" + Item.Key);
            Debug.Log("Value :" + Item.Value);
        }*/

        //how to loop through a Dictionary using a Value .
        /*foreach(item item1 in itemDictionary.Values)
        {
            Debug.Log("Key :" + item1.name);
        }*

        //how to loop through a Dictionary using a Key .
        /*foreach(int Key in itemDictionary.Keyes)
        {
            Debug.Log("Key :" + Key);
        }*/

        //what if a key does not exist in dictionary 
        if (itemDictionary.ContainsKey(0))
        {
            Debug.Log("Key is Found!");
            Debug.Log("Sword");
        }
        else
        {
            Debug.Log("Key Does not exist");
        }
    }
}
