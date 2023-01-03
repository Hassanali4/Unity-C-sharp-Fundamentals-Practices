[System.Serializable]
public class CUstomer
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

    public string name;
    public string occupation;
    public int salary;

    public CUstomer(string name, string occupation, int salary)
    {
        this.name = name;
        this.occupation = occupation;
        this.salary = salary;
    }

    public CUstomer()
    {

    }
}