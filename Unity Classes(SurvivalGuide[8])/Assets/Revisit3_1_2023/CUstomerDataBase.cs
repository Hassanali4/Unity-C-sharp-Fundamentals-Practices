using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CUstomerDataBase : MonoBehaviour
{
    /*Create a program where you add "Customers"
   a database.Assume you're creating some software where you need to store to customer information.
   Looking at this problem, you need to think about what is a customer? What "defines"
   a customer? We'll need a custom class that represents a customer and use it as
   a "blue print" for all customers
   Create atleast 3 customers via code using a constructor and then transition
   it to being able to add customers through the inspector.
   You'll need two classes. A CustomerDatabase (behavior) which "holds"
   customer information and a Customer class which defines a customer.
   Customer*/

    [SerializeField]
    private CUstomer[] Customer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
