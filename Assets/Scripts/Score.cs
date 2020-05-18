using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public static int pokusaj = 0;
    public static int maxPokusaj = 10;
    public Text brojpokusaja;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        brojpokusaja.GetComponent<Text>().text = maxPokusaj.ToString();
    }
}
