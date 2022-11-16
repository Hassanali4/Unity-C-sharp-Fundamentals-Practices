using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private UI_Manager _ui;
    
    private void OnEnable()
    {
        //FindObjectOfType<UI_Manager>().UpdateEnemyCount();
        _ui = GameObject.Find("UI_Manager").GetComponent<UI_Manager>();
        SpawnManager.enemyCounter++;
        _ui.UpdateEnemyCount();
        Die();
    }
    private void OnDisable()
    {
        SpawnManager.enemyCounter--;
        _ui.UpdateEnemyCount();
    }
    private void Die()
    {
        Destroy(this.gameObject, Random.Range(3, 6));
    }
}
