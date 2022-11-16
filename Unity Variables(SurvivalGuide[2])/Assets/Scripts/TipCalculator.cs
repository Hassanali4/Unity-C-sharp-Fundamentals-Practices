using UnityEngine;

public class TipCalculator : MonoBehaviour
{
    //bill is 40
    public float bill = 40f;
    //Tips is 20% or based on what the user wants
    public float tip = 20f;
    //calculate the total amount
    public float total;

    // Start is called before the first frame update
    void Start()
    {
        //So the tip will be provided to us by user ,
        //But there is a problem with it. Its not in Percentage its only the value of how much percent of tip should be, from total.
        int tipAmount = (int)(bill * (tip / 100));

        total = bill + tipAmount;

        //Your bill is : and your Tip is : So your total ammount is : totalAmount
        Debug.Log($"Your bill is {bill}: and your Tip is :{tip}So your total ammount is : {total}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
