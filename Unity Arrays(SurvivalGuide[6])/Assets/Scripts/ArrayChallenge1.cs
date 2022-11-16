using UnityEngine;

public class ArrayChallenge1 : MonoBehaviour
{

    /// <summary>
    /// Create an array of 5 names and print out the last kids name.
    /// Create an array of 5 ages and corospond to each kid and print out the last age.
    /// Create an array of 5 car models and associate them with each kid and print out the last kids favorite car.
    /// </summary>

    [SerializeField]
    private string[] names = new string[5] { "Allen", "Barry", "Harry" ,"Arthus" ,"Arthur" };
    [SerializeField]
    private int[] age = new int[5] { 5, 9, 12 ,14,6};
    [SerializeField]
    private string[] carModels = new string[5] { "Nissan", "Mclaren", "Mecedeze" ,"Audi" ,"Bugati" };

    public string n = "Arthur";
    // Start is called before the first frame update
    void Start()
    {
    /// Create an array of 5 names and print out the last kids name.
        

    /// Create an array of 5 ages and corospond to each kid and print out the last age.
    

    /// Create an array of 5 car models and associate them with each kid and print out the last kids favorite car.
    }

    // Update is called once per frame
    void Update()
    {
        //Bonus -- Handle the print out when the space key is pressed

        int rand = Random.Range(0, 5);
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log("My name is "+ name[4] +$", I am {age[age.Length - 1]} years Old, and My favorite car is {carModels[carModels.Length - 1]}.");
            Debug.Log("My name is "+ names[1] +", I am " +age[age.Length - 1]+" years Old, and My favorite car is "+carModels[carModels.Length - 1]+".");
        }
    }
}
