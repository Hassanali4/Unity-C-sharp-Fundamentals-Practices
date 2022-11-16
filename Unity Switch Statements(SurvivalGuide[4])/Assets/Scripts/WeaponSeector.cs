using UnityEngine;

public class WeaponSeector : MonoBehaviour
{
    public int weaponID;

    /// <summary>
    /// ID 1 = Gun
    /// ID 2 = knife
    /// ID 3 = Machine Gun
    /// </summary>
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            weaponID = 1;
        }else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            weaponID = 2;
        }else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            weaponID = 3;
        }

        switch (weaponID)
        {
            case 1:
                Debug.Log("Gun");
                break;
            case 2:
                Debug.Log("knife");
                break;
            case 3:
                Debug.Log("Machine Gun");
                break;
            default:
                Debug.Log("Invalid Weapon Selcetion press 1,2 or 3");
                break;
        }
    }
}
