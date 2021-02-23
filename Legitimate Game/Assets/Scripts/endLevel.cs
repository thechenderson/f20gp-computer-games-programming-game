using UnityEngine;

public class endLevel : MonoBehaviour
{

    
    public GameManager gameManager;
    void OnTriggerEnter() {
        gameManager.finishLevel();
    }

}
