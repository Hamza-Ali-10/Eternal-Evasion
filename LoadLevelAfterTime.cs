using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelAfterTime : MonoBehaviour
{
    //script for loading the loading scenes one after another
    
    public float delayTime = 3f;
    public string sceneToLoad;
    private float timeElapsed = 0; //Declarations
        
    private void Update()
    {
        timeElapsed += Time.deltaTime; //timer starts ....time keeps increasing with each update

        if(timeElapsed > delayTime) //when time elapsed reaches the time delay set beforehand then
        {
            SceneManager.LoadScene(sceneToLoad); //next scene is loaded...here general "scenetoload" is written but in unity this script is attached to all loading scenes and over there it is specified which scene to load exactly
        }
        
    }
}
