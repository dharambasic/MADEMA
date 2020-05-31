using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donja2 : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        

        Pass();
        Score.maxPokusaj = 15;
    }



    void Pass()
    {
        LevelMenager man = GameObject.Find("LevelMenager").GetComponent<LevelMenager>();
        man.LoadLevel("Level3");
        Destroy(gameObject);



    }
}
