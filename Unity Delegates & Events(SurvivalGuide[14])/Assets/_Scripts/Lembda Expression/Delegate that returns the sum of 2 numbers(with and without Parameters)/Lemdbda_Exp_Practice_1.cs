using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Lemdbda_Exp_Practice_1 : MonoBehaviour
{
    /// <summary>
    /// Create a delegate of type void that returns the sum of tow numbers.Use lembda Expression to avoid having a ---dedicated metod.
    /// </summary>

    public Action<int, int> Sum;

    // Start is called before the first frame update
    void Start()
    {
        Sum = (a, b) =>
        {
            var total = a + b;
            if (total < 100)
                Debug.Log("Total is less then 100.");

            Debug.Log("Total is : " + total);
        };
        Sum(5, 6);
    }

}
