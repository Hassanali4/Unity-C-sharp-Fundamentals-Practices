using UnityEngine;

public class PlayerDemage : MonoBehaviour
{
    /// <summary>
    /// Create a program that checks if the player is dead or not. When you hit the Space key, You should demage 
    /// the player by some random value. If the player is dead (health less the 1), print out "The player has died!"
    /// 
    /// Bonus: Prevent the demage function from being called once player is dead and no negative health values
    /// </summary>

    public GameObject player;
    public int health = 100;
    // Start is called before the first frame update
    void Start()
    {
        player.GetComponent<MeshRenderer>().material.color = Color.gray;
    }

    // Update is called once per frame
    void Update()
    {
        //When you hit the Space key call the function to give demage to the player, 
        if (Input.GetKeyDown(KeyCode.Space) && IsDead() == false)
        {
            int randomDemage = Random.Range(5, 20);
            Demage(randomDemage);

        }
    }

    //Create a program that checks if the player is dead or not
    private void Demage(int demage)
    {
        health = health - demage;
        if (IsDead())
        {
            Debug.Log("The player has died");
            health = 0;
        }
    }
    private bool IsDead()
    {
        return health < 1;
    }
        


}
