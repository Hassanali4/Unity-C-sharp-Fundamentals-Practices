using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
    {
        //Subscribing or Registering itself to an event of Main.cs Script that will run On Button click
        Main.OnClick += Fall;
    }

    private void OnDisable()
    {
        //Un-Subscribing or Un-Registering itself to an event of Main.cs Script that will run On Button click
        Main.OnClick -= Fall;
    }

    // To make this object fall using rigidbody Component
    void Fall()
    {
        GetComponent<Rigidbody>().useGravity = true;
    }

}
