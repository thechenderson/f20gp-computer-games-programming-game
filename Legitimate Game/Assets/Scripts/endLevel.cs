using UnityEngine;

public class endLevel : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
        {
            if (collision.transform.name == "Player") {
            Destroy(gameObject);
            FindObjectOfType<GameManager>().finishLevel();
            Debug.Log ("Finshed Game");
            }
            

        }

}
