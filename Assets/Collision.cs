using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("ouch!");
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("What the heck was that?");  
    }
}


