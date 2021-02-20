using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointCollection : MonoBehaviour
{    
    /*If the player collides with the sphere then add a point and remvoe the sphere from the world*/
    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "Player") {
          pointsUI.points += 1;
          Debug.Log ("Collected Point Sphere");
          Destroy(gameObject);
        }
        

    }


}
