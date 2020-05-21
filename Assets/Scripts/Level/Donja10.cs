using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donja10 : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("touch");

        Pass();
        Score.maxPokusaj = 20;

    }



    void Pass()
    {
        LevelMenager man = GameObject.Find("LevelMenager").GetComponent<LevelMenager>();
        man.LoadLevel("WinScene");

        Destroy(gameObject);



    }
}
