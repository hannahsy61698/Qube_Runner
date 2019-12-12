using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{


    public GameObject timeDisplay;
    public bool isTiming=false;
    public int theSeconds = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isTiming == false)
        {
            StartCoroutine(addSecond());
        }
    }

    IEnumerator addSecond() {

        isTiming = true;
        theSeconds += 1;
        timeDisplay.GetComponent<Text>().text = "" + theSeconds;
        yield return new WaitForSeconds(1);
        isTiming = false;
    }
}
