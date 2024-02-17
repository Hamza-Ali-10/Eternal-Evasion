using System.Collections;
using System.Collections.Generic; //Removing first two lines won't do anything
using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    public Transform targetObject; //aka cube

    public Vector3 cameraOffset; //maintain a specific distance from cube aka offset

    public float smoothFactor;

    public bool lookAtTarget;
    
    // Start is called before the first frame update
    void Start()
    {
        cameraOffset = transform.position - targetObject.transform.position; //we could try to calculate the offset ourselves by trial and error...but instead we just calculate the initial offset between camera and cube and store it in cameraoffset
    }

    void LateUpdate() //lateupdate allows for all of the other objects to update first ....we want to move the camera after everything else already has
    {
        Vector3 newPosition = targetObject.transform.position + cameraOffset; //position of camera will be the position of cube + initial offset = newposition
        transform.position = Vector3.Slerp(transform.position, newPosition, smoothFactor); //Slerp is for smoothness in movement
                              //first parameter is the current position...second is new position..and third is smoothfactor
        
        //Camera rotation with cube, gives a better looking view too
        if (lookAtTarget) //will always be true as it is a public variable and has been marked tick in unity aka true
        {
            transform.LookAt(targetObject);
        }
       
    }
}
