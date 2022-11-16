using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpAndDown : MonoBehaviour
{
    [SerializeField]
    private int speed;
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.S))
        {
            speed++;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            speed--;
        }
        if (speed < 0)
            speed = 0;
        if (speed > 20)
            Debug.Log("Slow Down!!");
        else if(speed == 0)
            Debug.Log("Speed UP!!");
    }
}
