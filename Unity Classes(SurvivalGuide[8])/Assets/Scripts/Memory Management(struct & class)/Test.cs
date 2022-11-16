using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct item1 // value type 
{
    public string name;
    public int itemID;
}
/*List of different value types
 * byte , bool , char , long, double , int , float , struct
*/

public class item // reference type
{
    public string name;
    public int itemID;

    public item(string name, int itemID)
    {
        this.name = name;
        this.itemID = itemID;
    }
}
/*List of different reference types
 * class , delegates ,strings , all arrays
*/


public class Test : MonoBehaviour
{
    item sword = new item("Sword", 2);

    item1 bread;

    private void Start()
    {
        bread.name = "Bread";
        bread.itemID = 3;

        Debug.Log("class Item value before change: " + sword.name);
        ChangeValue(sword);
        Debug.Log("class Item value before change(after name change): " + sword.name);
        Debug.Log("struct Item value before change: " + bread.name);
        ChangeValue(bread);
        Debug.Log("struct Item value before change(after name change): " + bread.name);
    }

    void ChangeValue(item1 structItem)// value type
    {
        structItem.name = "Dirty Bread";
    }
    void ChangeValue(item itemClass)// reference type
    {
        itemClass.name = "Legendary Sword";
    }

    /*By running the test you user can observe that the struct item does not change because struct is a value type and it can only 
     * within the scope it is created which is inside the class if another function try to access it
     * Then this value is copied to that fucnction or class scope and a new instance for it will be craeted within its scope.
     * And all the types of data types and there memory management is compulsory to know as it is common for programmers in the field.
     */
}
