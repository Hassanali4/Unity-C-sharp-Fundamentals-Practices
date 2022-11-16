using UnityEngine;

public class Pause : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //By Pressing Space Game Time will Pause
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
        }
        //By Pressing R Game Time will be Resume
        else if (Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1;
        }
        //By Pressing E Game Time will be in Slow Motion
        else if (Input.GetKeyDown(KeyCode.E))
        {
            Time.timeScale = 0.25f;
        }
    }
}
