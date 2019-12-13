using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goToNextLevel : MonoBehaviour
{


    void OnTriggerEnter()
    {

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1"))
        {
            SceneManager.LoadScene("Continue");
            //SceneManager.LoadScene("Level2");
        }

        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2"))
        {
            SceneManager.LoadScene("3Cont");
            //SceneManager.LoadScene("Level3");
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level3"))
        {
            SceneManager.LoadScene("Win");
            //Finish Screen
            //SceneManager.LoadScene(2);
        }

    }
}
