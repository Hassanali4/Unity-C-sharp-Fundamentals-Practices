using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck : Pet
{
    protected override void Speek()
    {
        Debug.Log("Quack Quack");
    }
}
