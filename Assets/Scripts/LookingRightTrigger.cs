using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookingRightTrigger : MonoBehaviour
{
    public Animator cat;
    private void Awake()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") == true)
        {
            cat.Play("looking right");
            Destroy(gameObject.GetComponent<BoxCollider2D>());
        }
    }
}
