using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointCollection : MonoBehaviour
{
    // Start is called before the first frame update
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "Player") {
          pointsUI.points += 1;
          Debug.Log ("Collected Point Sphere");
          Destroy(gameObject);
        }
        

    }


}
