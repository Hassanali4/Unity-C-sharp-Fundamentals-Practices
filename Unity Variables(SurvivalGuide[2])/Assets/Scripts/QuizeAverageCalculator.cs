using UnityEngine;

public class QuizeAverageCalculator : MonoBehaviour
{
    [SerializeField] private float[] quiz;
    [SerializeField] private float average;

    // Start is called before the first frame update
    void Start()
    {
        int i = 0;
        while (i < quiz.Length)
        {
            quiz[i] = Mathf.Round((Random.Range(0f, 100f)) * 100f) / 100f;
            average += quiz[i];
            Debug.Log($"Quize{i + 1} grade :{quiz[i]}");
            i++;
        }

        //average = Mathf.Round((average / quiz.Length) * 100f) / 100f;

        Debug.Log($"Average is : {average/quiz.Length}");

    }
}
