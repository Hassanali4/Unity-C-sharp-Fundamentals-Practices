using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    //public bool isGameOver;
    //is public so that others scripts like playerManager can access it and tell the GameManager to display game over screen so on...

    /// <summary>
    /// There is some Commented code with Publi isGameOver (Member) & GameOver (Method) but all of this is public which is really 
    /// Dangerous for Scalable & Scalable coding for the Developer & advanced future Projects
    /// That is why addvanced OOP features of csharp have to be used like Properties that helps in reducing.
    /// The most begginer habit of making everything public writting more code here and there.
    /// </summary>

    /*public bool IsGameOver 
    { 
        get 
        {
            return IsGameOver;
        }
        set 
        {
            if (value == true)
            {
                Debug.Log("Oh no the game is over!");
            }
            IsGameOver = value; 
        }
    }*/

    /// <summary>
    /// Create properties for the Following:
    ///Speed(read-Only)
    ///Name(public)
    /// </summary>

    private readonly float _speed = 10f;
    private string _name = "old Name";

    public float Speed 
    { 
        get 
        { 
            return _speed;
        }
    }
    public string Name 
    { 
        get 
        { 
            return _name; 
        } 
        set 
        { 
            _name = value;
            Debug.Log("(Property)Name has been setted as : " + _name);

        }
    }
    private void Start()
    {
        //IsGameOver = false;

        /*Debug.Log("Speed : "+ Speed);
        Debug.Log("Names (old Value) : " + Name);
        string n = "New Name";
        Debug.Log("Name (New Value) :" + Name);*/
    }

    // Update is called once per frame
    void Update()
    {
       /* if (Input.GetKeyDown(KeyCode.Space))
        {
            IsGameOver = true;

        }*/
        if (Input.GetKeyDown(KeyCode.A))
        {
            Name = "Albert";
        }
    }

    //some more code in fucntion for game over functionality
    /*public void GameOver()
    {
        isGameOver = true;
        // Game over screen enabled 
        //audio executed
        //Options to Exit or Replay Game shown to the player
    }*/
}
