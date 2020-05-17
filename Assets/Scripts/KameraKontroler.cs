using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraKontroler : MonoBehaviour
{

   

    public Transform target;
    public float speed = 50f;
    private Vector3 pomak;

    void Start()
    {
        pomak = transform.position - target.transform.position;    
    }




    // Update is called once per frame
    void LateUpdate()
    {


        transform.position = target.transform.position + pomak;
        

        transform.RotateAround(target.position, Vector3.up, Input.GetAxis("Horizontal") * speed * Time.deltaTime);

       
    }
}
