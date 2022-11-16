using UnityEngine;

public class ArrayChallenge2 : MonoBehaviour
{

    /// <summary>
    /// Randomly print out the any kid but also print the age and car of that persons according to its number if 4th is selected then
    /// age & car also should be 4th
    /// </summary>

    [SerializeField]
    private string[] names2 = new string[5] { "Allen", "Barry", "Harry", "Arthus", "Arthur" };
    [SerializeField]
    private int[] age2 = new int[5] { 5, 9, 12, 14, 6 };
    [SerializeField]
    private string[] car = new string[5] { "Nissan", "Mclaren", "Mecedeze", "Audi", "Bugati" };

    public string n = "Arthur";
    
    void Update()
    {
        //Bonus -- Handle the print out when the space key is pressed

        int rand = Random.Range(0, 5);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log("My name is "+ name[4] +$", I am {age[age.Length - 1]} years Old, and My favorite car is {carModels[carModels.Length - 1]}.");
            Debug.Log("My name is " + names2[rand] + ", I am " + age2[rand] + " years Old, and My favorite car is " + car[rand] + ".");
        }
    }
}
