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
            SceneManager.LoadScene(1);
        }

        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2"))
        {
            SceneManager.LoadScene(2);
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2"))
        {

            //Finish Screen
            //SceneManager.LoadScene(2);
        }

    }
}
