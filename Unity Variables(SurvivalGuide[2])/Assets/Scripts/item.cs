using UnityEngine;

public class item : MonoBehaviour
{

    public new string name = "LeftHook";
    public string description= "A LeftHook is more commonly known as a left super punch because of its name that is so unknown locally it deals some fair amount of demage." +
                                " The special thing about this item is that it is infiniet and have very fast speed";    
    public Sprite image;
    public float attackStrength = 25f;
    void Start()
    {
        Debug.Log("Item name is : " + name);
        Debug.Log("Item Description : " + description);
        Debug.Log("Item Attack Strength : " + attackStrength);        
    }
}
