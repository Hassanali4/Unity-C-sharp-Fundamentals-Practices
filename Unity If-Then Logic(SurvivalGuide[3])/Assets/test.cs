using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    [SerializeField] private GameObject cube;
    [SerializeField] private int _speed;
    private MeshRenderer mr;
    // Start is called before the first frame update
    void Start()
    {
        mr = cube.GetComponent<MeshRenderer>();
        mr.material.color = Color.red;
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            _speed -= 5;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            _speed += 5; 

        }
        if (_speed > 20)
        {
            Debug.Log("Slow Down!!");
            mr.material.color = Color.green;
        }else if (_speed == 0)
        {
            Debug.Log("Speed Up!!");
        }
        else if(_speed < 0)
        {
            _speed = 0;
        }
    }
}
