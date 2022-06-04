using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadGrabArea : MonoBehaviour
{
    [SerializeField] private AudioSource audioSrc;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") == true)
        {
            audioSrc.Play();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        audioSrc.Stop();
    }
}
