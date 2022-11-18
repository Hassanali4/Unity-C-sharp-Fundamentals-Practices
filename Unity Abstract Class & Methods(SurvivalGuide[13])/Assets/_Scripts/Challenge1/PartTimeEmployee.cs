using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartTimeEmployee : Employee
{
    public float hoursWorked;
    public float SalaryRate;

    public override void CalculateMonthlySalary()
    {
        Debug.Log("This is Monthly Salary Implementation of Part Time Employee.");
        Debug.Log("Part Time Salary Monthly is : " + (hoursWorked * SalaryRate));
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
