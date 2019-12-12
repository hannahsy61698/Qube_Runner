using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HighGem : MonoBehaviour
{

    public GameObject score_text;
    public AudioSource collectSound;

    void OnTriggerEnter()
    {
        GlobalScore.currentScore += 3000;
        collectSound.Play();
        Destroy(gameObject);
    }
}
