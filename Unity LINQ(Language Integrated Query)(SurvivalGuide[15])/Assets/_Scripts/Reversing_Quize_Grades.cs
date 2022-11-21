using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Reversing_Quize_Grades : MonoBehaviour
{
    /// <summary>
    /// Create a program where you have an integer array of quize grades.
    /// The quize grades must be between 0-100
    /// Filter through the quize grades and create
    /// a new collection of only passing grades.
    /// -passing grades should be Above 69
    /// </summary>

    //integer array of quize grades
    public int[] quizeGrades = { 50, 50, 39, 77, 69, 70, 88, 79, 95 };

    // Start is called before the first frame update
    void Start()
    {
        var passingGrades = quizeGrades.Where(qg => qg > 69).OrderByDescending(g => g).Reverse();// Printing the list in Descending Ordered lis in Reverse
        //var passingGrades = quizeGrades.Where(qg => qg > 69).OrderByDescending(g => g).Sum();// Printing the total sum of the whole list
        //var passingGrades = quizeGrades.Where(qg => qg > 69).OrderByDescending(g => g); // Printing the list in Descending Order
        foreach (var grade in passingGrades)
        {
            Debug.Log("Grade : " + grade);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
