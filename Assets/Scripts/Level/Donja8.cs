using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donja8 : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {


        Pass();

    }



    void Pass()
    {
        LevelMenager man = GameObject.Find("LevelMenager").GetComponent<LevelMenager>();
        man.LoadLevel("Level_9");
        Destroy(gameObject);



    }
}
