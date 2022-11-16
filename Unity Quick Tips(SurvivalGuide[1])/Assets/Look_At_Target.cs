using UnityEngine;

public class Look_At_Target : MonoBehaviour
{
    [SerializeField]
    private Transform _toLookAt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //To look at something we have to first find out the direction of it
        //Formula to find the direction of something is ,
        //direction = destination - source
        Vector3 directionToFace = _toLookAt.position - transform.position;
        //Now to access our current rotation = Quaternion Look Rotation
        transform.rotation = Quaternion.LookRotation(directionToFace);

        //Now to make our rotation to look a more smooth towards target which is possible with the help of Quaternion.slerp
        //Quaternion.slerp only needs (our current position to strat rotating from,
        //                              towards the targets World space Angles in Quaternions,
        //                              with numbers of meters to move * Multiplied with time to have smooth movement frames)
        //Quaternion _targetRotation = Quaternion.LookRotation(directionToFace);

        //transform.rotation = Quaternion.Slerp(transform.rotation, _targetRotation, Time.deltaTime);
            

        //Also to draw a Line in Scene view to exactly specify from our source(currentLocation) to destination(TargetLoction)
        Debug.DrawRay(transform.position, directionToFace,Color.red);



    }
}
