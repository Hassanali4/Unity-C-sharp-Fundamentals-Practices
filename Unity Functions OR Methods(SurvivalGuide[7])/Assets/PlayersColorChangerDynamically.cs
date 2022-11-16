using UnityEngine;

public class PlayersColorChangerDynamically : MonoBehaviour
{
    public GameObject[] players;
    // Start is called before the first frame update
    void Start()
    {
        players = PlayerFinder();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private GameObject[] PlayerFinder()
    {
        GameObject[] allPlayers = GameObject.FindGameObjectsWithTag("Player");
        foreach (var p in allPlayers)
        {
            p.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
        }
        return allPlayers;
    }
}
