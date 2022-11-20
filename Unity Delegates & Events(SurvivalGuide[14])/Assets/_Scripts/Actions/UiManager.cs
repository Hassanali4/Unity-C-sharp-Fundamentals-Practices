using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public Text currentHealthText;
    private void OnEnable()
    {
        ActionPlayer.OnDemageRecieved += UpdateCurrentHealth;
    }
    private void UpdateCurrentHealth(int currentHealth)
    {
        currentHealthText.text = "Health : " + currentHealth;
    }
    private void OnDisable()
    {
        ActionPlayer.OnDemageRecieved -= UpdateCurrentHealth;
    }
}
