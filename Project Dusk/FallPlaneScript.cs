using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallPlaneScript : MonoBehaviour
{

    public Collider2D playerCollider;//Variables

    public Transform target;

    GameObject player;

    void OnTriggerEnter2D(Collider2D playerCollider)//On trigger enter for kill plane collider
    {
        player = GameObject.Find("Player");//Find the player GameObject

        player.transform.position = target.position;//And move them safely somewhere else
    }

}
