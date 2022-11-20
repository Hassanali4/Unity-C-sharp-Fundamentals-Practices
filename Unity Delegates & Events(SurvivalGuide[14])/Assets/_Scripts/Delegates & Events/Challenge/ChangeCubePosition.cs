using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCubePosition : MonoBehaviour
{
    private void OnEnable()
    {
        //Subscribing or Registering in OnCLicked event in PositionEvent having an event named OnClicked
        PositionEvent.onTeleport += Spawn;
    }
    private void OnDisable()
    {
        //Un-Subscribing or Un-Registering in OnCLicked event in PositionEvent having an event named OnClicked
        PositionEvent.onTeleport -= Spawn;   
    }
    //ChangePosition function to change the current position of the Object to (5, 2, 0) in world space 
    public void Spawn(Vector3 pos)
    {
        transform.position = pos;
    }
}
