using UnityEngine;

public class PositionMattersChallenge : MonoBehaviour
{
    /// <summary>
    /// Create an Array of 5 different positions and use a custom method to generate a random index, and then use a custom method 
    /// to set the position to that sub index
    /// </summary>

    //Create an Array of 5 different positions
    public Vector3[] positions;

    public GameObject obj;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SetThePositionToSubIndex(RandomIndexGenerator(positions.Length, 0));
        }
    }

    //use a custom method to generate a random index
    private int RandomIndexGenerator(int max, int min = 0)
    {
        return Random.Range(0, positions.Length);
    }

    //use a custom method to set the position to that sub index
    private void SetThePositionToSubIndex(int index)
    {
        obj.GetComponent<Transform>().position = positions[index];
        obj.GetComponent<MeshRenderer>().material.color = new Color(Random.value,Random.value,Random.value);
    }
}
