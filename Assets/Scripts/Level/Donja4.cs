using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donja4 : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {


        Pass();
        Score.maxPokusaj = 10;
    }



    void Pass()
    {
        LevelMenager man = GameObject.Find("LevelMenager").GetComponent<LevelMenager>();
        man.LoadLevel("Level5");
        Destroy(gameObject);



    }
}
