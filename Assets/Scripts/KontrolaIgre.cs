using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KontrolaIgre : MonoBehaviour
{

    public float Sila = 0;
    public Transform Arrow;
    public float zScale = 0;
   

    void Start()
    {

    }


    void Update()
    {

        if (Input.GetAxis("Mouse ScrollWheel") > 0f) 
        {
            Sila += 50;
            zScale += 1;

            if(Sila > 500)
            {
                zScale = 5;
            }

            Arrow.GetComponent<Transform>().localScale = new Vector3(1, zScale, 1);
        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0f) 
        {
            Sila -= 50;
            zScale -= 1;

          
            if(zScale > 0)
            {
                Arrow.GetComponent<Transform>().localScale = new Vector3(1, zScale, 1);
            }

            if (zScale < 0)
            {
                Arrow.GetComponent<Transform>().localScale = new Vector3(1, zScale, 1);
                

            }
        }


        if (Input.GetKeyDown("e"))
        {
            transform.Rotate(0, 10, 0);
        }

        if(Input.GetKeyDown("q"))
        {
            transform.Rotate(0, -10, 0);
        }



    }


    void OnMouseDown()
    {
        GetComponent<Rigidbody>().AddRelativeForce(0, 0, Sila);
        Arrow.GetComponent<Renderer>().enabled = false;
        Score.pokusaj += 1;
        Score.maxPokusaj -= 1;
        Debug.Log(Score.pokusaj + " " + Score.maxPokusaj);

        if (Score.maxPokusaj == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Score.maxPokusaj = 10;
        }
        StartCoroutine(Stop());
    }


    IEnumerator Stop()
    {
        yield return new WaitForSeconds(5);
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        yield return new WaitForSeconds(.1f);
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        transform.localEulerAngles = new Vector3(0, 0, 0);
        Arrow.GetComponent<Renderer>().enabled = true;

}
}