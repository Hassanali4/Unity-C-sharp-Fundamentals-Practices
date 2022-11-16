using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBehaviour : MonoBehaviour
{
    public new Text name;
    public GameObject objToChangeColor;
    private string[] ptypes = new string[6] { "Sphere", "Capsule", "Cylinder" , "Cube" , "Plane" , "Quad" };
    // Update is called once per frame
    void Update()
    {
        Utilityhelper.CreateObject(name);
        if (Input.GetKeyDown(KeyCode.C))
        {
            Utilityhelper.ChangePostion(this.gameObject);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
                Utilityhelper.ChangeColor(objToChangeColor);
           /* for (int i = 0; i < ptypes.Length; i++) 
            {
                GameObject objToChangeColor = GameObject.Find(ptypes[i]);
            }*/
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            for (int i = 0; i < ptypes.Length; i++)
            {
                //GameObject objToChangeColor = ;
                Destroy(GameObject.Find(ptypes[i]));
            }
            name.text = "No Object available";
        }
    }
}
