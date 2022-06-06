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
    IEnumerator WaitForTalk()
    {
        yield return new WaitForSeconds(6);
        anim.SetTrigger("talk");
    }

    /*private void Update()
    {
        if (PickUpItem.isDestroyed == true)
        {
            StartCoroutine(WaitForTalk());
        }
    }*/

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (PickUpItem.isDestroyed == true)
        {
            StartCoroutine(WaitForTalk());
        }
    }
}
