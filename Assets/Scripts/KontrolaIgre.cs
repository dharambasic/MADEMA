using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KontrolaIgre : MonoBehaviour
{

    public float zSila = 0;

   
    void Start()
    {
       
    }

   
    void Update()
    {

        if(Input.GetKeyDown("z"))
        {
            zSila += 100;
        }

        if (Input.GetKeyDown("x"))
        {
            zSila += 10;
        }

        
    }
    

   void OnMouseDown()
    {
        GetComponent<Rigidbody>().AddRelativeForce(0, 0, zSila);
    }
}
