using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
   
    public void onclickStart()
    {
        SceneManager.LoadScene("Level1");
    }

    public void onclickExit()
    {
        Application.Quit();
    }

    public void onclickMain()
    {
        SceneManager.LoadScene("Start");
    }

    public void onclickRestart()
    {
        SceneManager.LoadScene("Level1");
    }

    public void onclickRestart2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void onclickRestart3()
    {
        SceneManager.LoadScene("Level3");
    }

}
