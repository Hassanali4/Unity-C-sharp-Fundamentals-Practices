using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IDemagable
{
    public int Health { get ; set ; }

    public void Demage(int demageAmount)
    {
        Health -= demageAmount;
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
