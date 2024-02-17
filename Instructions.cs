using System.Collections;       
using System.Collections.Generic;  //Removing first two lines won't do anything
using UnityEngine;
using UnityEngine.SceneManagement; //Directives


public class Instructions : MonoBehaviour //Monobehaviour is the base class from which every Unity script derives...allows you to use functions like Start() Update() etc
        //Name of class/script
{
    public void Back() //Function called "Back"....in unity this function has linked to the back button in instructions menu...when button clicked...whatevers inside function will take place
    {
        SceneManager.LoadScene("MainMenu"); //if button clicked, "MainMenu" scene will be loaded
    }
}
