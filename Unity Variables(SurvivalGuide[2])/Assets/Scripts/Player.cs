using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    /// <summary>
    /// public or private reference
    /// data types (strings ,bool ,float ,int )
    /// optional -- a value
    /// </summary>

    //create a variable for my name
    //................. for my age
    //................. for my location

    //----Challange 1.1.name
    public new string name = "Jonathon";
    //----Challange 1.2.age
    public int age = 25;
    public string location = "Lahore";

    /// <summary>
    /// ----------Challenge Variables----------
    /// Create a variable to store your name
    /// .................... store your age
    /// .................... store your speed
    /// Create a health cariable
    /// Create a score variable
    /// Create a speed variable
    /// variable to check if all keys are collected 
    /// variable for ammo count
    /// ----------------------------------------
    /// </summary>

    //----Challange 1.3.speed
    public float mySpeed = 5.5f;
    //----Challange 1.4.health cariable
    public int health = 100;
    //----Challange 1.5.score variable
    public int score = 95;
    //----Challange 1.6.speed variable
    public float speed;
    //----Challange 1.7.all keys are collected
    public bool keysAreCollected;
    //----Challange 1.8.ammo count
    public int ammo;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"My name is {name}," +
                  $"Age is {age}, " +
                  $"Location is {location}, " +
                  $"Speed is {mySpeed}, " +
                  $"Health is {100}, " +
                  $"Score is {score}" +
                  $"Do i have collected all the keys {keysAreCollected}" +
                  $"Ammo count is {ammo}");
    }

    // Update is called once per frame
    void Update()
    {
        if (age == 26)
        {
            name = "Hassan Ali";
            location = "Lahore,Pakistan";
        }
        Debug.Log($"My name is {name} My age is {age.ToString()}, I live in {location}");
    }
}
