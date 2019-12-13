using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Continues : MonoBehaviour
{
    public void onClickCont()
    {
        SceneManager.LoadScene("Level2");
    }

    public void onClickCont3()
    {
        SceneManager.LoadScene("Level3");
    }
}
