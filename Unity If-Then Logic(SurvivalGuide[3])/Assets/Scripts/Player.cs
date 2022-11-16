using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float[] quiz;
    [SerializeField]
    private float average;

    private void Start()
    {
        //5 quize grades
        int i = 0;
        while (i < quiz.Length)
        {
            quiz[i] = Mathf.Round(Random.Range(0f, 100f) * 100) / 100f;
            average += quiz[i];
            i++;
        }
        //Calculate average quize grades
        average = average / quiz.Length;


        //Prints A  = > 90
        if (average >= 90.00)
        {
            Debug.Log($"Grade :{average} = A");
        }
        //Prints B  = > 80 but less then 90
        else if (average >= 80 && average < 90)
        {
            Debug.Log($"Grade :{average} = B");
        }
        //print C  = > 70 < 80
        else if (average >= 70 && average < 80)
        {
            Debug.Log($"Grade :{average} = C");
        }
        //Print F less then 70
        else if (average < 70)
        {
            Debug.Log($"Grade :{average} = F");
        }
        //Default Case
        else
        {
            Debug.Log("Invalid Grades");
        }


    }
        

}
