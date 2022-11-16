using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed = 5f;
    [SerializeField]
    private float _horizontalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         _horizontalInput = Input.GetAxis("Horizontal");
         
        transform.Translate(new Vector3(_horizontalInput , 0f,0f) * Time.deltaTime * _speed);
    }
}
