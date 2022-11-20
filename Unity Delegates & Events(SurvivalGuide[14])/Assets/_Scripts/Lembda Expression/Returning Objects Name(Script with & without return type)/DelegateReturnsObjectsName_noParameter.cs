using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateReturnsObjectsName_noParameter : MonoBehaviour
{
    /// <summary>
    /// Create a delegate of type void that returns the gameObjects name.
    /// </summary>

    public static Action GetName;

    // Start is called before the first frame update
    void Start()
    {
        GetName = () => Debug.Log("Name : " + gameObject.name);
        GetName();
    }
}
