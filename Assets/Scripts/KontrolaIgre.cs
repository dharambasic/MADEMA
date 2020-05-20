using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KontrolaIgre : MonoBehaviour
{

    public float Sila = 0;
    public Transform Arrow;
    public float zScale = 0;
    public Rigidbody rb;
   
   

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {

        


        if (Input.GetAxis("Mouse ScrollWheel") > 0f) 
        {
            Sila += 150;
            zScale += 0.5f;

            

            Arrow.GetComponent<Transform>().localScale = new Vector3(1, zScale, 1);
        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0f) 
        {
            Sila -= 150;
            zScale -= 0.5f;


        

            if (Sila > 0)
            {
                Arrow.GetComponent<Transform>().localScale = new Vector3(1, zScale, 1);
            }

            if (Sila < 0)
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


        if (Input.GetKey(KeyCode.Escape))
        {

            LevelMenager man = GameObject.Find("LevelMenager").GetComponent<LevelMenager>();
            man.LoadLevel("MainMenuScene");

        }
    }


    void OnMouseDown()
    {

       
        if(Input.GetMouseButtonDown(0) && rb.velocity == Vector3.zero)
        {
            rb.AddRelativeForce(0, 0, Sila);
            Score.pokusaj += 1;
            Score.maxPokusaj -= 1;
        }

        
        Arrow.GetComponent<Renderer>().enabled = false;
        
        Debug.Log(Score.pokusaj + " " + Score.maxPokusaj);

        if (Score.maxPokusaj == 0)
        {
            LevelMenager man = GameObject.Find("LevelMenager").GetComponent<LevelMenager>();
            man.LoadLevel("LoseScene");
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