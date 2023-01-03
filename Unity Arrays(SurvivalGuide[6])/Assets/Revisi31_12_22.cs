using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revisi31_12_22 : MonoBehaviour
{
    /*//Create an array of 5 names and print out the last kids name
    [SerializeField] private string[] names;
    //Create an array of 5 ages that corospond to each kid and print out the last age
    [SerializeField] private int[] ages;
    //Create an array of 5 car models and associate them with each kid and print out the last kids favorite can
    [SerializeField] private string[] carModels;*/

    //2nd
    //Create a program where you assign a cube in the inspector and when you hit
    //public GameObject[] game_Object;
    //the space key, you pass that object into a function called ChangeColor. The function should take both the GameObject
    //and a color to change to and the operation should be handled within the function.

    //3rd
    // Create a program that checks if the player is dead or not. When you hit the space key, you should damage
    //the player by a random amount. If the player is dead (health less than 1), print out "The player has died!"
    //Bonus: Prevent the damage function from being called once player is dead and по negative health values
    //[SerializeField] private int _health = 100;

    //4rth
    //Create an array of 5 different positions and use a custom method to generate a random index, and then use a custom
    //method to set the position to that sub index.

    [SerializeField] private Vector3[] positions;

    // Start is called before the first frame update
    void Start()
    {
        positions = new Vector3[5];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_health != 0)
                Damage();
            else
                Debug.Log("The player has Died!");
            if (_health < 0) _health = 0;
        }
    }

    private Vector3 RandomIndex()
    {
        if (_health  > 0)
        {
            var v = Random.Range(1, 26);
            _health -= v;
        }
    }
}
