using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDemagable , IShootable
{
    public int Health { get ; set ; }

    public void Demage(int demageAmount)
    {
        Health -= demageAmount;
        GetComponent<MeshRenderer>().material.color = Color.red;

    }

    public void shoot()
    {
        throw new System.NotImplementedException();
    }
}
