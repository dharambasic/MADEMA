using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donja3 : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {


        Pass();
        Score.maxPokusaj = 15;
    }



    void Pass()
    {
        LevelMenager man = GameObject.Find("LevelMenager").GetComponent<LevelMenager>();
        man.LoadLevel("Level4");
        Destroy(gameObject);



    }
}
