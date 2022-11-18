using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{ 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray origin = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(origin,out hitInfo))
            {
                IDemagable objClicked = hitInfo.collider.GetComponent<IDemagable>();
                if (objClicked != null)
                {
                    objClicked.Demage(500);
                }
            }
        }
    }
}
