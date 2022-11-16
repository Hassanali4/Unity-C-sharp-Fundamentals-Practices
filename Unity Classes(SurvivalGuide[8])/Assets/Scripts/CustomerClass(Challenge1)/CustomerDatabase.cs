using UnityEngine;

public class CustomerDatabase : MonoBehaviour
{
    [SerializeField]
    public Customer[] customers;
    // Start is called before the first frame update
    void Start()
    {
        customers[0] = new Customer("Don", "Jon", 28, "Male", "Bodygard");
        customers[1] = new Customer("Charllot", "Danes", 23, "Female", "Secretary");
        customers[2] = new Customer("Micheal", "Jackson", 26, "Male", "Dancer & Singer");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public Customer AddCustomers(string first_Name,string last_Name,int age,string gender,string occupation)
    {
       var customers = new Customer(first_Name,last_Name,age,gender,occupation);

        return customers;
    }
}
