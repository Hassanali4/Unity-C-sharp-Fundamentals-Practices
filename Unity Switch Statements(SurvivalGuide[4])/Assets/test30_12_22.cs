using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test30_12_22 : MonoBehaviour
{

    [SerializeField] private int _speed;
    [SerializeField] private int ms;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 30; i++)
        {
            if (i < 11)
            {
                Debug.Log(i);
            }
            if (i % 2 == 0 && i < 21 && i > 11)
            {
                Debug.Log("even : " + i);
            }
            if (i % 2 == 1 && i < 30 && i > 20)
            {
                Debug.Log("odd : " + i);
            }
        }
;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 
}
