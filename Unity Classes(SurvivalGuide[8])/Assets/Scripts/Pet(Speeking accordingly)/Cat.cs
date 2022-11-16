using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Pet
{
    protected override void Speek()
    {
        Debug.Log("Meao Meao!");
    }
}
