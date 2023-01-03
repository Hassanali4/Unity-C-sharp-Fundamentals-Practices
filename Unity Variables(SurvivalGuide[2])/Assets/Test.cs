using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private float[] grades = new float[5];
    [SerializeField] private float _totalAverage;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < grades.Length;i++)
        {
            grades[i] = Random.Range(1f, 100f);
            _totalAverage += grades[i];
        }
        Debug.Log($"Your grades Total Average is :{_totalAverage / grades.Length}.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
