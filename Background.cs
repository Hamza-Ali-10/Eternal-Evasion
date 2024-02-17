using System.Collections; 
using System.Collections.Generic; //Removing first two lines won't do anything
using UnityEngine; //Directives

public class Background : MonoBehaviour
{
    //well there may be many methods of setting a background in unity 3d...but we went for a bit of a clever method ...essentially the background u see when u play is a 2d canvas in 3d space but its moving...moving at the same speed as cube so it seems as if background is just never ending when really it just stays a fixed distance away from cube :p
    
    public float moveSpeedForward; //speed of background(same as speed of cube)

    void Update() 
    {
        //"transform" means you are manipulating the position, rotation or scale of an object...and "transform.Translate" means you are going to manipulate the position of the object specifically 

        transform.Translate(moveSpeedForward * Vector3.forward * Time.deltaTime); //Vector3.forward is another way of writing Vector3(0,0,1)....background will move at constant speed in +ve z direction i.e forward
    }
}
