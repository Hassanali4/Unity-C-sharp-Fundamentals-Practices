using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyAI
{
    Petroling,
    Chasing,
    Attacking,
    Death,
}

public class EnemyAIScript : MonoBehaviour
{
    public EnemyAI currentState;

    private void Start()
    {
        currentState = EnemyAI.Petroling;
    }
    private void Update()
    {
        switch (currentState)
        {
            case EnemyAI.Petroling:
                Debug.Log("Petrolling");
                StartCoroutine(NextState());
                /*if (Time.time > 5)
                {
                    currentState = EnemyAI.Chasing;
                }*/
                break;
            case EnemyAI.Chasing:
                Debug.Log("Chasing");
                StartCoroutine(NextState());
                /*if (Time.time > 10)
                {
                    currentState = EnemyAI.Attacking;
                }*/
                break;
            case EnemyAI.Attacking:
                Debug.Log("Attacking");
                StartCoroutine(NextState());
                /*if (Time.time > 15)
                {
                    currentState = EnemyAI.Death;
                }*/
                break;
            case EnemyAI.Death:
                Debug.Log("Death");
                StartCoroutine(NextState());
                break;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentState = EnemyAI.Petroling;
        }
    }

    IEnumerator NextState()
    {
        yield return new WaitForSecondsRealtime(5f);
        currentState++;                               
    }
}
