using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    GameManager gm;

    
    private void Start()
    {
        gm = new GameManager();
        Debug.Log("I am calling from test (Name): " + gm.Name);
        gm.Name = "Sionis";
        Debug.Log("I am calling from test (Name): " + gm.Name);
        Debug.Log("I am calling from test (Speed): " + gm.Speed);
    }
}
