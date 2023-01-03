using UnityEngine;

public class Looping_Evenly_And_Oddly : MonoBehaviour
{
    /// <summary>
    /// Create a program that prints out 0-10 and then prints out only even numbers to 20 and only odd nunbers to 30.
    /// HINT : User moduluse operator
    /// </summary>
    // Update is called once per frame
    public void Update()
    {
        //Create a program that prints out 0 - 10
        for (int i = 0; i < 30; i++)
        {
            if (i < 10 && i > 0)
                Debug.Log(i);
            if (i < 21 && i > 0)
            {
                if (i % 2 == 0)
                    Debug.Log("Even : " + i);
            }
            if (i < 31 && i > 0)
            {
                if (i % 2 != 0)
                    Debug.Log("Odd : " + i);
            }
        }
    }        
}
