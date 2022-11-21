using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class LinqChallenge_Quize_Grades : MonoBehaviour
{
    /// <summary>
    /// Create a program where you have an integer array of quize grades.
    /// The quize grades must be between 0-100
    /// Filter through the quize grades and create
    /// a new collection of only passing grades.
    /// -passing grades should be Above 69
    /// </summary>

    //integer array of quize grades
    public int[] quizeGrades = { 56, 46, 39, 77, 69, 70, 88, 79 };
    // Start is called before the first frame update
    void Start()
    {
        // Filter through the quize grades and create
        var FilteredQuizeGrades = quizeGrades.Where( (int quizeGrade) => 
                                                    {
                                                        if (quizeGrade > 69)
                                                            return true;
                                                        else
                                                            return false;
                                                    });
        foreach (var quizeGrade in FilteredQuizeGrades)
        {
            Debug.Log("Passing Grades :" + quizeGrade);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
