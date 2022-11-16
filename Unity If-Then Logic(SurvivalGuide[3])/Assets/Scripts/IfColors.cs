using UnityEngine;

public class IfColors : MonoBehaviour
{
    [SerializeField]
    private GameObject cube;
    private byte score;
    // Start is called before the first frame update
    void Start()
    {
        cube.GetComponent<MeshRenderer>().material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            score += 10;
        }
        if (score > 50)
            cube.GetComponent<MeshRenderer>().material.color = Color.green;

        Debug.Log("Points:" + score);

    }
}
