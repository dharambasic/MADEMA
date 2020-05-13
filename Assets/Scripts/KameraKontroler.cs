using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraKontroler : MonoBehaviour
{


    public GameObject player;

    private Vector3 pomak;

    void Start()
    {
        pomak = transform.position - player.transform.position;    
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + pomak;
    }
}
