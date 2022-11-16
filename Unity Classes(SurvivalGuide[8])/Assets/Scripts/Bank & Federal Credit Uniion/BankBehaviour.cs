using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BankBehaviour : MonoBehaviour
{
    public Bank details;

    public void DepositCash()
    {
        Debug.Log("The amount of " + details.cashInVault + " have been deposited successfully");
    }
    public void CheckBalence()
    {
        Debug.Log("Amount of cash is in your account :"+ details.cashInVault);
    }
    public void WithdrawAmount()
    {
        Debug.Log("The amount of " + details.cashInVault + " have been deposited successfully");
    }
}
