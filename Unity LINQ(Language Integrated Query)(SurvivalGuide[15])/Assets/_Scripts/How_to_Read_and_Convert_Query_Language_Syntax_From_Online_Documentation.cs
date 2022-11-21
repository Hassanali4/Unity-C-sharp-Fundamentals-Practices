using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class How_to_Read_and_Convert_Query_Language_Syntax_From_Online_Documentation : MonoBehaviour
{
    //Specify the data source
    public int[] scores = new int[] { 97 , 92 , 81 ,60 };
    // Start is called before the first frame update
    void Start()
    {
        //Define the Query Expression
        var scroreQuery =
            from score in scores
            where score > 80
            select score;

        //Now converting above query expression into an inline lembda expresion
        //1- So first just the collection or array you want to query through
        //2- Then link extention that you want to apply on it.
        //3- The select keyword is not needed to include in it.
        scores.Where(score => score > 80);
    }
}
