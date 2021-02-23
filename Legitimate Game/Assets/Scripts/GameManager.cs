using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject endLevelUI;

    
    public void finishLevel() {
        Debug.Log("Level complete triggered");
        endLevelUI.SetActive(true);
    }


}
