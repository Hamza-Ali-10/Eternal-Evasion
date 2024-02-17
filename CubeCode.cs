using System.Collections;                         
using System.Collections.Generic;                 //Removing first two lines won't do anything
using UnityEngine;
using UnityEngine.SceneManagement;                //Directives

public class CubeCode : MonoBehaviour             //Monobehaviour is the base class from which every Unity script derives...allows you to use functions like Start() Update() etc
          //Name of class/script                  //So basically class CubeCode is a derived class and the base class is class Monobehaviour which Unity provides - in other words inheritance

{
    public float moveSpeedForward;                //Declarations
    public float moveSpeedSide;                   //Public means they can be accessed outside script in programs...private means they are only accessible in script (public declarations visible in unity while private not)
    public float jumpheight;
    public float jumpforce;
    private Vector3 jump;                         //Vector3 = 3D vector
    private Rigidbody rigidBody;                  //Adding a Rigidbody component to an object will put its motion under the control of Unity's physics engine
                                                  //Enables game object to react to real time physics like gravity, forces, collisions etc
    void Start()                                  //Start function gets called only once at start of game
    {
        jump = new Vector3(0f, jumpheight, 0f);   //New 3D vector created with x and z dimensions 0 and y dimension = jumpheight
        rigidBody = GetComponent<Rigidbody>();    //Rigidbody component of cube in unity can now be accessed using variable "rigidBody"...now we don't have to write GetComponent<Rigidbody>() again and again, rather just use the variable rigidBody to reference the rigid body component in unity  
    }
    
    void Update()                                 //Update function gets called after every frame
    {
        //"transform" means you are manipulating the position, rotation or scale of an object...and "transform.Translate" means you are going to manipulate the position of the object specifically 

        transform.Translate(moveSpeedSide * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, 0f);   

//for right and left movement (y and z component set to zero as we only want movement in x direction here....Input.GetAxis("Horizontal") basically checks whether right or left key being pressed and passes on 0 i.e not pressed, 1 i.e +ve x or right, -1 i.e -ve x or left....it tells the direction...getaxis is preferred over getaxisraw as getaxis gradually changes value from 0 to 1 or -1 but getaxisraw changes the value instantly without any steps so getaxis smoother....and basically speed is multiplied by time to get the distance object should be translated...deltaTime is basically the time in seconds it took to complete the last frame, used to make game movement frame rate independent, no matter the frame rate distance it moves then will be constant...so by using Time.deltaTime ur basically telling the program that i want my object to move x meters per second instead of x meters per frame)

        transform.Translate(moveSpeedForward * Vector3.forward * Time.deltaTime);                    

//Vector3.forward is another way of writing Vector3(0,0,1)....cube will move at constant speed in +ve z direction i.e forward

        //The if statement below restricts no. of jumps to 1.....double jumps etc not possible..only when cube comes back to ground after first jump will it be able to jump again 
        
        if (rigidBody.velocity.y == 0)                                      //checking whether cube on ground or air....on ground would mean y = 0
        {
            if (Input.GetKeyDown(KeyCode.Space))                            //if on ground, then checks whether "space" key being pressed or not 
            {   
                                                                            //if both conditions true, then force applied to cube for jump
                rigidBody.AddForce(jump * jumpforce, ForceMode.Impulse);    //rigidbody.addforce means force being applied to cube through the rigid body component...ForceMode.Impulse adds an instant force impulse to the rigidbody, using its mass...so basically the entirety of the force vector supplied to the AddForce call will be applied all at once, immediately
            }
        }
        
        //the if statement below is for respawning the cube when it falls off platform 

        if(rigidBody.position.y < -1f)                   //if cube more than 1 unit below platform ,then respawned
        {
            FindObjectOfType<GameManager>().EndGame();   //calls the function I made for restarting level named "endgame" located in game manager script....details for this function are in game manager script with function itself
        }
    }
}
