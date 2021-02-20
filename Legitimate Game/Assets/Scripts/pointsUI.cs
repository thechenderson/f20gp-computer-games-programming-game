using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointsUI : MonoBehaviour
{
    public static int points = 0;
    public Text pointText;

    // Update is called once per frame
    void Update()
    {
        pointText.text = "Points: " + points;    
    }
}
