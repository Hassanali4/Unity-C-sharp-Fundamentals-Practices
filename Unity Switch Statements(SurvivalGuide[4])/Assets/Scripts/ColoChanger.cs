using UnityEngine;

public class ColoChanger : MonoBehaviour
{
    /// <summary>
    /// Create a cube that turns a cube or any gameobjects color based on your input
    /// 1 key = blue 
    /// 2 key = red 
    /// 3 key = green
    /// 4 key = black
    /// </summary>
    public GameObject cube;
    [SerializeField]
    private MeshRenderer _colortoChange;
    [SerializeField]
    private int i=-1;
    void Start()
    {
        _colortoChange = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            i = 1;
        } if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            i = 2;
        } if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            i = 3;
        } if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            i = 4 ;
        }
        if (i > 4 || i < 0)
        {
            i = 0;
        }
        switch (i)
        {
            case 1:
                _colortoChange.material.color = Color.blue;
                break;
            case 2:
                _colortoChange.material.color = Color.red;
                break;
            case 3:
                _colortoChange.material.color = Color.green;
                break;
            case 4:
                _colortoChange.material.color = Color.black;
                break;
            default:
                _colortoChange.material.color = Color.white;
                break;
        }
    }
}
