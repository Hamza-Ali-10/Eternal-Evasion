using System.Collections;           
using System.Collections.Generic;    //Removing first two lines won't do anything
using UnityEngine;
using UnityEngine.SceneManagement;  //Directives

public class GameManager : MonoBehaviour //Monobehaviour is the base class from which every Unity script derives...allows you to use functions like Start() Update() etc
      //Name of class/script
{
    bool gameHasEnded = false;  //Initially game would be playing so setting "gameHasEnded" to false 
    public float restartDelay; //Time delay after dying, before restarting 

    public void EndGame() //Function called "EndGame"....if cube hits obstacles or falls over, then scene restarted
    {
        if(gameHasEnded == false) //checking whether game was initially playing
        {
            gameHasEnded = true; //if so then "gameHasEnded" will become true
            Debug.Log("Game Over"); //logs a message to unity console, removing it won't change anything
            Invoke("Restart", restartDelay); //Invoke takes two parameters, first one will be the scene we want to load , second will the delay that happens before loading scene
        }     //so when cube dies, restart function located below invoked with time delay, reason for using invoke and not simply loading scene is we want cube dying to be a bit dramatic, so a time delay achieves that
    }

    void Restart() //invoked when cube dies
    {
        SceneManager.LoadScene("PressPtoPlay"); //It gets the name of scene we are currently on i.e. gamescene and loads it, essentially it restarts it
    }
    //SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    void Update() //for the "press p to play screen"
    {
        if(SceneManager.GetActiveScene().name == "PressPtoPlay") //checks whether we are on "press p to play" screen or not
        {
            if (Input.GetKeyDown(KeyCode.P)) //then checks whether "P" being pressed
            {
                SceneManager.LoadScene("GameScene"); //if both conditions true, then "gamescene" restarted
            }
        }
        
    }

}
