﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donja9 : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {


        Pass();

    }



    void Pass()
    {
        LevelMenager man = GameObject.Find("LevelMenager").GetComponent<LevelMenager>();
        man.LoadLevel("Level_10");
        Destroy(gameObject);



    }
}
