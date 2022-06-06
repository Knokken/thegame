using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WalkingAre : MonoBehaviour
{
    public Animator anim;
    public Animator anim2;
    public Animator anim3;
    public Animator anim4;
    public Animator anim5;
    public Animator anim6;
    public Animator red;

    private void Awake()
    {

    }
    private void OnTriggerStay2D(Collider2D collision)
    {

        anim.SetBool("openingEyes", true);
        anim2.SetBool("openingEyes", true);
        anim3.SetBool("openingEyes", true);
        anim4.SetBool("openingEyes", true);
        anim5.SetBool("openEyes", true);
        anim6.SetBool("openEyes", true);
        red.SetBool("Red", true);

    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        anim.SetBool("openingEyes", false);
        anim2.SetBool("openingEyes", false);
        anim3.SetBool("openingEyes", false);
        anim4.SetBool("openingEyes", false);
        anim5.SetBool("openEyes", false);
        anim6.SetBool("openEyes", false);
        red.SetBool("Red", false);

    }
}