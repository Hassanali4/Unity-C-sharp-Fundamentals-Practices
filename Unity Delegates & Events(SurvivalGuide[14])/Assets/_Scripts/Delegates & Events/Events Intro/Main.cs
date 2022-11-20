using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public delegate void ActionClick();
    public static event ActionClick OnClick;

    // Start is called before the first frame update
    public void OnButonClick()
    {
        if (OnClick != null)
            OnClick();
        
    }
}
