using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegates : MonoBehaviour
{
    public delegate void ChangeColor(Color newColor);
    public ChangeColor onColorChange;

    public delegate void OnComplete();
    public OnComplete onComplete;

    // Start is called before the first frame update
    void Start()
    {
        onColorChange = UpdateColor;

        if (onColorChange != null)
            onColorChange(Color.red);

        onComplete += Task;
        onComplete += Task2;
        onComplete += Task3;

        if (onComplete != null)
            onComplete();
    }

    public void UpdateColor(Color newColor)
    {
        Debug.Log("Changed Color Value : " + newColor.ToString());
    }

    public void Task()
    {
        Debug.Log("Task 1 is Finished ");
    }
    public void Task2()
    {
        Debug.Log("Task 2 is Finished ");
    }public void Task3()
    {
        Debug.Log("Task 3 is Finished ");
    }

}
