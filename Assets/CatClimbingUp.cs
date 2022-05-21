using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatClimbingUp : MonoBehaviour
{
    private Animator anim;
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (PickUpItem.isDestroyed == true)
        {
            anim.SetTrigger("talk");
        }
    }
}
