using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    public Text activeEnemyCount;
    public void UpdateEnemyCount()
    {
        activeEnemyCount.text = "Enemies Count : " + SpawnManager.enemyCounter;
    }
}
