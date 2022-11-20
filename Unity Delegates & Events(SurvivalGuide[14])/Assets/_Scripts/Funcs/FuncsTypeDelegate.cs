using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuncsTypeDelegate : MonoBehaviour
{
    /// <summary>
    /// Create a program that takes a string and return the length of it. (How many Characters)
    /// </summary>

    /*public delegate int characterLength(string text);
    characterLength cl;*/
    
    public Func<string , int> characterLength;

    void Start()
    {
        characterLength = GetCharactersLength;
        int nameCount = GetCharactersLength("hassan");
        Debug.Log(nameCount);
    }

    public int GetCharactersLength(string name)
    {
        return name.Length;
    }
}
