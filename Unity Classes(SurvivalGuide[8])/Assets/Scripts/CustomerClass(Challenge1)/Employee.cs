

[System.Serializable]
public class Customer
{
    /*
     * Create a program where you add "Customers" to a database. Assume 
     * you're creating some software where you need to store information.
     * 
     * Looking at this problem, you need to think about what is a customer? What "Define"
     * a customer? We'll need a custom class that represents a customer and use it as a 
     * "blue print" for all customers
     * 
     * Create atleast 3 customers via code using a cunstructor and then transition it to 
     * being able to tadd customers throught the inspector.
     * 
     * You'll need two classes. A customer Database(behaviour) which "holds"
     * customer information and a Customer class which defines a customer.
     * 
     * Customer Traits:
     * 
     * First Name
     * Last Name 
     * Age 
     * gender
     * Occupation
     */

    public string first_Name;
    public string last_Name;
    public int age;
    public string gender;
    public string occupation;

    public Customer()
    {

    }
    public Customer(string first_Name,string last_Name,int age,string gender,string occupation)
    {
        this.first_Name = first_Name;
        this.last_Name = last_Name;
        this.age = age;
        this.gender = gender;
        this.occupation = occupation;
    }

}
