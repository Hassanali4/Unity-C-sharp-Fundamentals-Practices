using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player
{
    public string name;
    public int id;

    public player(int id)
    {
        this.id = id;
    }
}

public class Main : MonoBehaviour
{
    public Dictionary<int, player> playerDictionary = new Dictionary<int, player>();
    player p2;

    // Start is called before the first frame update
    void Start()
    {
        player p1 = new player(1);
        p1.name = "James";
        p2 = new player(200);    
        p2.name = "Kyle";
        player p3 = new player(3);    
        p3.name = "Jessica";

        playerDictionary.Add(p1.id, p1);
        playerDictionary.Add(p2.id, p2);
        playerDictionary.Add(p3.id, p3);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var player = playerDictionary[p2.id];
            Debug.Log(player.name);
        }
    }
    
}
