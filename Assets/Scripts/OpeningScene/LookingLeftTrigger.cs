using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookingLeftTrigger : MonoBehaviour
{
    public Animator cat;
    private void Awake()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") == true)
        {
            cat.Play("looking left");
            Destroy(gameObject.GetComponent<BoxCollider2D>());
        }
    }
    
}
