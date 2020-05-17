using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KontrolaIgre : MonoBehaviour
{

    public float Sila = 0;


    void Start()
    {

    }


    void Update()
    {

        if (Input.GetAxis("Mouse ScrollWheel") > 0f) 
        {
            Sila += 10;
        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0f) 
        {
            Sila -= 10;
        }




    }


    void OnMouseDown()
    {
        GetComponent<Rigidbody>().AddRelativeForce(0, 0, Sila);
    }
}