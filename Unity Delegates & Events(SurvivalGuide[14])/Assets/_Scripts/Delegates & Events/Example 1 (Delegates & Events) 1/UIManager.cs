using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text deathCountText;
    public int deathCount;
    private void OnEnable()
    {
        Player.onDeath += UpdateOnDeathCount;
    }
    private void OnDisable()
    {
        Player.onDeath -= UpdateOnDeathCount;
    }
    public void UpdateOnDeathCount()
    {
        deathCount++;
        deathCountText.text = "Death Count : " + deathCount.ToString();
    }
}
