using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullTimeEmployee : Employee
{
    public float salary;

    public override void CalculateMonthlySalary()
    {
        Debug.Log("This is Calculate Monthly Salary of Fulltime Employee");
        Debug.Log("Full Time Salary Monthly is : " +(salary / 12));
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
