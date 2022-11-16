using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Employee
{
    public int id;
    public string firstName, lastName;
    public float salary;

    public static string company;

    public Employee(int id, string firstName, string lastName, float salary)
    {
        this.id = id;
        this.firstName = firstName;
        this.lastName = lastName;
        this.salary = salary;

        Debug.Log("Instance is created");
    }
    static Employee()
    {
        company = "HassanDev.HQ";
        Debug.Log("Static Instance is created");
    }

}

public class StaticCunstructor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var e1 = new Employee(1,"Allen","Walker",26);
        var e2 = new Employee(1,"barry","pots",26);
        var e3 = new Employee(1,"harry","Potter",26);
        var e4 = new Employee(1,"Ron","Weasly",26);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
