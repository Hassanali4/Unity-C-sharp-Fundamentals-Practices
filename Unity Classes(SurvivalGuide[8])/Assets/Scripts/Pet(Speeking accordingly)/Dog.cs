using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Pet
{
    protected override void Speek()
    {
        Debug.Log("Bark Bark!");
    }
}
