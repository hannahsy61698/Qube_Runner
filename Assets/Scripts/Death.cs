using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  void OnTriggerEnter()
    {

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1"))
        {
            // add load death scene here
            //this restarts back from the start of the level
            SceneManager.LoadScene("End");
            //SceneManager.LoadScene(0);
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2"))
        {
            // add load death scene here
            //this restarts back from the start of the level
            //SceneManager.LoadScene(1);
            SceneManager.LoadScene("End2");
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level3"))
        {
            // add load death scene here
            //this restarts back from the start of the level
            //SceneManager.LoadScene(3);
            SceneManager.LoadScene("End3");
        }
    }


}
