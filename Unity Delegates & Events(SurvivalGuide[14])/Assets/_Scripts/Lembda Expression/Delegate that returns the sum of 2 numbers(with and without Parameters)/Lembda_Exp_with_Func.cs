using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lembda_Exp_with_Func : MonoBehaviour
{
    /// <summary>
    /// Create a delegate of type int that returns the sum of tow numbers.Use lembda Expression to avoid having a ---dedicated metod.
    /// </summary>

    //Create a delegate of type void that returns the sum of tow numbers ---having a return type(func)
    public Func<int, int, int> Sum;

    // Start is called before the first frame update
    void Start()
    {
        Sum = (a, b) =>
        {
            return a + b;
        };
        int sum = Sum(5, 5);
        Debug.Log(sum);
    }

}


