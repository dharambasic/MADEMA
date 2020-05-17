using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pad : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
    {


        Die();

    }



    void Die()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);


    }




}



