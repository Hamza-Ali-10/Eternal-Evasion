using System.Collections;  
using System.Collections.Generic;  //Removing first two lines won't do anything
using UnityEngine;
using UnityEngine.SceneManagement; //Directives

public class CubeCollision : MonoBehaviour //Monobehaviour is the base class from which every Unity script derives...allows you to use functions like Start() Update() etc
        //Name of class/script
{
    public CubeCode movement;  //A reference to the whole cube movement script named "CubeCode"

    //The function below runs when we hit another object....whenever a collision will happen with obstacle..object will respawn using function below

    void OnCollisionEnter (Collision collisionInfo) //we have given the collision a name i.e "collisionInfo"
        //Name of function
    {
        if(collisionInfo.collider.name == "Cube (1)" || collisionInfo.collider.name == "Cube (2)") // if our cube collides with objects named "cube 1" or "cube 2", then respawn...for anyone wondering , obstacles in path either have the name "cube 1" or "cube 2"
        {
            movement.enabled = false; //Disables the whole cube movement script called "CubeCode" if collided with obstacle..essentially disables cube movement
            FindObjectOfType<GameManager>().EndGame(); //calls the function I made for restarting level named "endgame" located in game manager script....details for this function are in game manager script with function itself
        }
    }
}
