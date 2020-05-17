using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ignore : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform PlayerPrefab;

    void Start()
    {
        Transform player = Instantiate(PlayerPrefab) as Transform;
        Physics.IgnoreCollision(player.GetComponent<Collider>(), GetComponent<Collider>());
    }
}
