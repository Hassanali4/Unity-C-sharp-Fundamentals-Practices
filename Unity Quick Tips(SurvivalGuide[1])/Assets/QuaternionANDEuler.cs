using UnityEngine;

public class QuaternionANDEuler : MonoBehaviour
{
    [SerializeField]
    private GameObject cubeObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //This line instantiates a cube object that has been referanced from outside of the script through inspector to the script
         //cube will have Position(x=0,y=0,z=0) & Quaternion handles rotation so Quaternion.identity will have its Quaternion 4 
         //angles be like Quaternion(x=0,y=0,z=0,w=0) which will be compiled later by unity built in system in Quaternion.Euler(x=0,y=0,z=0) 
        Instantiate(cubeObject, Vector3.zero, Quaternion.identity);
        //This line instantiates a cube object that has been referanced from outside of the script through inspector to the script
        //cube will have Position(x=0,y=0,z=0) by using the Vector3 shorthand Vector3.zero & Quaternion handles rotation so Quaternion.Euler will have its Quaternion 4 
        //angles be like Quaternion(x,y,z,w) which will be compiled later by unity built in system in Quaternion.Euler(x=SomeValue,y=SomeValue,z=SomeValue) 
        Instantiate(cubeObject, Vector3.zero, Quaternion.Euler(0f, 35f, 0f));
    }
}
