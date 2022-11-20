using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Callback_System_Example : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CallBack(() => 
        {
            Debug.Log("The Routine has finished!.");
            Debug.Log("This delegate system is soo Cool.!!!");
        }));
    }

    private IEnumerator CallBack(Action callBack = null)
    {
        yield return new WaitForSeconds(5.0f);
        if (callBack != null)
            callBack();
    }
}
