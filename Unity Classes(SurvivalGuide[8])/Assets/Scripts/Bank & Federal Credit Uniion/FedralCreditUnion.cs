using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class FedralCreditUnion : Bank
{
    public int availableCashToLend;
    public void LoanApproval()
    {
        Debug.Log("The amount of loan can be given : " + availableCashToLend);        
    }
}
