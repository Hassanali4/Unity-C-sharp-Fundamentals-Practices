using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Employee : MonoBehaviour
{

    public string name;
    public string companyName;

    public abstract void CalculateMonthlySalary();        
}
