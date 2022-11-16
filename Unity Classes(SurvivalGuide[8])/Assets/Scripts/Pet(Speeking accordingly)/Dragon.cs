using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : Pet
{
    protected override void Speek()
    {
        Debug.Log("Grarrr Grarrr!!!");
    }
}
