using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lembda_Expression_Intro : MonoBehaviour
{
    /// <summary>
    /// Create a program that takes a string and return the length of it. (How many Characters)
    /// 
    /// Using Lembda Expression any kind of single line Method or Function can be simplified in code
    /// but a little complex in understanding and implementing at first.
    /// Because it takes the parameter and single line code it needs to work in just
    /// A single assigning line.
    /// </summary>

    public Func<string, int> characterLength;

    void Start()
    {
        //The get character will be turned into a single lembda Expression which will remove its function definition code 
        characterLength = (name) => name.Length;
        int nameCount = characterLength("hassan");
        Debug.Log(nameCount);
    }

    /*public int GetCharactersLength(string name)
    {
        return name.Length;
    }*/
}
