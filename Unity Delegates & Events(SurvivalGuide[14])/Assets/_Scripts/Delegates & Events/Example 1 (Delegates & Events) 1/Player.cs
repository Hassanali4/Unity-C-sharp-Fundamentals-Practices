using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public delegate void OnDeath();
    public static event OnDeath onDeath;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<MeshRenderer>().material.color = new Color(Random.value,Random.value,Random.value);
            Death();
        }
    }

    public void Death()
    {
        if (onDeath != null)
            onDeath();
    }
}
