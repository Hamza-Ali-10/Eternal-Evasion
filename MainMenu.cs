using System.Collections;            
using System.Collections.Generic;    //Removing first two lines won't do anything
using UnityEngine;
using UnityEngine.SceneManagement;   //Directives

public class MainMenu : MonoBehaviour //Monobehaviour is the base class from which every Unity script derives...allows you to use functions like Start() Update() etc
      //Name of class/script
{
    public void PlayGame() //Function called "PlayGame"....in unity this function has linked to the play game button on main menu...when button clicked...whatevers inside function will take place
    {
        SceneManager.LoadScene("Loading0"); //if button clicked, "Loading0" scene will be loaded 
    }

    public void QuitGame() //Function called "QuitGame"....in unity this function has linked to the quit button on main menu...when button clicked...whatevers inside function will take place
    {
        Application.Quit(); //quits and closes game window if button clicked
    }

    public void Instructions() //Function called "Instructions"....in unity this function has linked to the instructions button on main menu...when button clicked...whatevers inside function will take place
    {
        SceneManager.LoadScene("Instructions"); //if button clicked, "Instructions" scene will be loaded 
    }

    public void GameDescription() //Function called "GameDescription"....in unity this function has linked to the info button on main menu...when button clicked...whatevers inside function will take place
    {
        SceneManager.LoadScene("Info"); //if button clicked, "Info" scene will be loaded 
    }

}
