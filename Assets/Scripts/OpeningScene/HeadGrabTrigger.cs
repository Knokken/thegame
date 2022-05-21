using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class HeadGrabTrigger : MonoBehaviour
{
    public Animator player;
    private void Awake()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        player.SetBool("headGrabWalk", true);

    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        player.SetBool("headGrabWalk", false);

    }
}
