using UnityEngine;

public class ifTOswitch : MonoBehaviour
{
    private int points;

    // Update is called once per frame
    void Update()
    {
        //check for input key E
        //then add 50 value to points
        if (Input.GetKeyDown(KeyCode.E))
        {
            points = 50;
        }
        //check for input key W
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            //then add 100 value to points
            points = 100;
        }
        // check for input key Q
        else if (Input.GetKeyDown(KeyCode.W))
        {
        //then add 0 value to points
            points = 0;
        }



        //make a switch to print the updated value of points 
        switch (points)
        {
        //if 50 then print 50
            case 50:
                Debug.Log("Points are 50");
                break;
        //if 100 then print 100
            case 100:
                Debug.Log("Points are 100");
                break;
        //if 0 then print 0
            case 0:
                Debug.Log("You need 50 or 1000 to recieve a message ");
                break;
        }
    }
}
