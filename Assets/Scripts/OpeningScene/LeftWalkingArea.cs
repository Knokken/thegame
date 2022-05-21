using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Animations;


public class LeftWalkingArea : MonoBehaviour
{
    public Animator anim;
    public Animator anim2;
    public Animator anim4;
    private void Awake()
    {

    }
    private void OnTriggerStay2D(Collider2D collision)
    {

        anim.SetBool("openingEyes", true);
        anim2.SetBool("openingEyes", true);
        anim4.SetBool("openEyes", true);

    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        anim.SetBool("openingEyes", false);
        anim2.SetBool("openingEyes", false);
        anim4.SetBool("openEyes", false);

    }
}
