using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointsUI : MonoBehaviour
{
    /* Set the initial value for points*/
    public static int points = 0;

    /*Set a customisable text to place on the UI*/
    public Text pointText;

    // Update is called once per frame
    void Update()
    {
        /*Set the text of the points UI to display the current points acquired by the player*/
        pointText.text = "Points: " + points;    
    }
}
