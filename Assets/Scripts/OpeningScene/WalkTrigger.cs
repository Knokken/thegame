using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;


public class WalkTrigger : MonoBehaviour
{
    public Animator player;
    private void Awake()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.SetTrigger("toWalk");
        player.SetBool("walk", true);

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        player.SetTrigger("toRun");
        player.SetBool("walk", false);

    }
}
