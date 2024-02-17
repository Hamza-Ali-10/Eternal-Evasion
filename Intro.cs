using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    public float delayTime = 15f; //time of intro video
    private float timeElapsed;

    private void Update()
    {
        timeElapsed += Time.deltaTime; //timer starts...time keeps increasing with each update

        if (timeElapsed > delayTime) //when time elapsed greater than delaytime aka time of intro video aka when video has ended
        {
            SceneManager.LoadScene("MainMenu"); //then main menu loaded.....this is because we want to go to main menu after intro and not be stuck on a black screen
        }

    }
   
}
