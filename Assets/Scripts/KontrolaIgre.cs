using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KontrolaIgre : MonoBehaviour
{

    public float Sila = 0;
    public Transform Arrow;
    public float zScale = 1;

    void Start()
    {

    }


    void Update()
    {

        if (Input.GetAxis("Mouse ScrollWheel") > 0f) 
        {
            Sila += 50;
            zScale += 1;
            Arrow.GetComponent<Transform>().localScale = new Vector3(1, 1, zScale);
        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0f) 
        {
            Sila -= 50;
            zScale -= 50;
            Arrow.GetComponent<Transform>().localScale = new Vector3(-1, -1, zScale);
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

        StartCoroutine(Stop());
    }


    IEnumerator Stop()
    {
        yield return new WaitForSeconds(5);
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        yield return new WaitForSeconds(0.1f);
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        transform.localEulerAngles = new Vector3(0, 0, 0);
        Arrow.GetComponent<Renderer>().enabled = true;

}
}