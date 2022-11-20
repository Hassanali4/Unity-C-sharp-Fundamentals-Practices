using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateReturnsGameObjectsName : MonoBehaviour
{
    /// <summary>
    /// Create a delegate of type void that takes a gameObjec & returns the gameObjects name.
    /// </summary>

    public static Action<GameObject> Name;

    public GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        Name = (NameObj) => Debug.Log(NameObj.name);
        Name(obj);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}