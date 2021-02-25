using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

void Start () {
    Cursor.visible = false;
}

    public GameObject endLevelUI;
    public bool levelComplete = false;

    public void finishLevel() 
    {

        if (levelComplete == false)
        {
            levelComplete = true;
            endLevelUI.SetActive(true);     

        }
           

    }


}
