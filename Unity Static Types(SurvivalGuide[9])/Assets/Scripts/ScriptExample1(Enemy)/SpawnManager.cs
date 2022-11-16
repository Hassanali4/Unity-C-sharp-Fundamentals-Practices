using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemy;
    public static int enemyCounter;
    //Transform _randPos;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            
            //_randPos.position = new Vector3(Random.value, Random.value, Random.value);
            Instantiate(enemy, new Vector3(Random.value, Random.value, Random.value),Quaternion.Euler(Random.value, Random.value, Random.value));

        }
    }
}
