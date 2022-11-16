using UnityEngine;

public class ObjectWithColor : MonoBehaviour
{
    /// <summary>
    /// Create a program where you assign a cube in the inspector and when you hit
    /// the space key , you pass the object into a function called changeColor. The function should take the GameObject 
    /// and a color to change to and the operation should be handled within the function
    /// </summary>

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
            ChangeObjectsColor(obj, Color.blue);
        }
    }
    private void ChangeObjectsColor(GameObject obj, Color collor)
    {
        obj.GetComponent<MeshRenderer>().material.color = collor;
    }
}
