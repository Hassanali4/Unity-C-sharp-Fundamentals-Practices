using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListNames : MonoBehaviour
{
    public List<string> names = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        foreach (var n in names)
        {
            Debug.Log(n);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var removedName = names[Random.Range(0, names.Count)];

            names.Remove(removedName);
            foreach (var n in names)
            {
                Debug.Log(n);
            }
            Debug.Log("Removed Name is : " + removedName);
        }
    }
}
