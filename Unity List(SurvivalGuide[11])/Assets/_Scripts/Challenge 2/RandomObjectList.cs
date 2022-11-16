using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomObjectList : MonoBehaviour
{
    public Text numberOfObjectsSpawned;

    //Create a list or array of gameObjects to spawn
    public List<GameObject> objsToSpawn;
    public List<GameObject> objsCreated;
    private int counter = 0;//counter variable to check if spawning exceedes 10
    /// <summary>
    ///  Challenge: Create a list or array of gameObjects to spawn & randomly spawn objects with 
    ///  position on the scereen between -10 to 10  in X/Y when you hit the space key. Every object you spawn
    ///  should be store in a list named objectsCreated.
    ///  when you have spawn 10 objects , you will no longer be able to spawn objects and will turn
    ///  all objects created GREEN and CLEAR the List.
    /// </summary>

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //when you hit the space key
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ///  when you have spawn 10 objects , you will no longer be able to spawn objects 
            if(!(counter > 9))
            {
                counter++;
                //randomly spawn objects with position on the scereen between -10 to 10  in X/Y
                GameObject obj = objsToSpawn[Random.Range(0,objsToSpawn.Count)];
                //  Every object you spawn should be store in a list named objectsCreated.
                objsCreated.Add(Instantiate(obj, new Vector3(Random.Range(-10, 11), Random.Range(-10, 11), 0f), Quaternion.identity) as GameObject);
                
            }
            if(counter == 10)
            {
                //and will turn all objects created GREEN and CLEAR the List.
                foreach (var obj in objsCreated)
                {
                    obj.GetComponent<MeshRenderer>().material.color = Color.green;
                    StartCoroutine(RemoveObjects());
                }

            }

        }
        numberOfObjectsSpawned.text = "Spawned : " + counter.ToString();
    }

    IEnumerator RemoveObjects()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f);
            objsCreated.Clear();
            break;
        }
    }
}
