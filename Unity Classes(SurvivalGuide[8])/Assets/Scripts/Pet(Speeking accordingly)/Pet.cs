using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pet : MonoBehaviour
{
    protected new string name;

    protected virtual void Speek()
    {
        Debug.Log("Speeking!");
    }

    private void Start()
    {
        Speek();
    }

}
