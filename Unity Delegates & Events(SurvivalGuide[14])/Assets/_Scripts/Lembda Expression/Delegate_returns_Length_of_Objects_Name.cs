using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegate_returns_Length_of_Objects_Name : MonoBehaviour
{
    /// <summary>
    /// Create a delegate of type int that returns the length of gameObjects name.
    /// Use lembda Expression to avoid having a ---dedicated metod.
    /// </summary>

    public Func<int> GetNameLength;

    // Start is called before the first frame update
    void Start()
    {
        GetNameLength = () => gameObject.name.Length;
        Debug.Log("Name Count : " + GetNameLength());
    }
}
