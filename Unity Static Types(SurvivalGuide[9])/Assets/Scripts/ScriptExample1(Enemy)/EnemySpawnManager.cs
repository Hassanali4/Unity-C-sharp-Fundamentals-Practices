using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Text enemyCount;

    public static int enemyCounter;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(enemyPrefab,new Vector3(Random.value,Random.value,Random.value),Quaternion.Euler(Random.value, Random.value, Random.value));
            enemyCounter++;
            enemyCount.text = "EnemyCount : " + enemyCounter.ToString();
        }
    }
}
