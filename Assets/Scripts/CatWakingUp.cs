using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatWakingUp : MonoBehaviour
{
    private Animator anim;
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        anim.Play("waking up");
        Destroy(gameObject.GetComponent<BoxCollider2D>());
    }
}
