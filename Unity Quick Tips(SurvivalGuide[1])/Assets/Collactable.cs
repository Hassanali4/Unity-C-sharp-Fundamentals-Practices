using UnityEngine;

public class Collactable : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //add a collectabe sound
            //add an ability to the player
            //add a power-up to the player 
            Destroy(this.gameObject);
        }
    }
}
