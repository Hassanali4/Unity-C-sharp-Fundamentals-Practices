using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionPlayer : MonoBehaviour
{
    /*public delegate void onDemage(int currentHealth);
    public static event onDemage OnDemageRecieved;*/

    public static Action<int> OnDemageRecieved;
    public int health { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        health = 10;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Demage();
        }
    }

    void Demage()
    {
        health--;
        if (OnDemageRecieved != null)
            OnDemageRecieved(health);
    }
}
