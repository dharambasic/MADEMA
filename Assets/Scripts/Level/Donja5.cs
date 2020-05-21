using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donja5 : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {


        Pass();
        Score.maxPokusaj = 20;
    }



    void Pass()
    {
        LevelMenager man = GameObject.Find("LevelMenager").GetComponent<LevelMenager>();
        man.LoadLevel("Level6");
        Destroy(gameObject);



    }
}
