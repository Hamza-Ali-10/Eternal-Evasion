using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //This line allows us to write code for user interface, score can then be seen on UI.

public class Score : MonoBehaviour
{
    public Transform Cube;
    public Text scoreText;

    void Update()
    {
        scoreText.text = Cube.position.z.ToString("0");  //"0" to make score less precise, instead of decimal places it just shows integers only now.
      //takes the z position of cube i.e distance cube has moved in z/forward direction and displays as score  
      
    }
}
