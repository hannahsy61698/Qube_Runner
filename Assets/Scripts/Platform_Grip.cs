﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_Grip : MonoBehaviour
{

    public GameObject Ledge;
    public GameObject player;
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
        player.transform.parent = Ledge.transform;
    }


    void OnTriggerExit()
    {
        player.transform.parent = null;
    }
}
