using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donja : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    { 
        Debug.Log("touch");

            Pass();
        
    }

    

    void Pass()
    {
        LevelMenager man = GameObject.Find("LevelMenager").GetComponent<LevelMenager>();
        man.LoadLevel("Level2");
        Destroy(gameObject);
        


    }
}
