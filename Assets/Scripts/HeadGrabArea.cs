using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadGrabArea : MonoBehaviour
{
    [SerializeField] private AudioSource audioSrc;

   /* private IEnumerator FadeOut()
    {
        float speed = 0.05f;
        while (audioSrc.volume < 1)
        {
            audioSrc.volume -= speed;
            yield return new WaitForSeconds(0.1f);
        }
    }

    private IEnumerator FadeIn()
    {
        float speed = 0.05f;
        while (audioSrc.volume > 1)
        {
            audioSrc.volume -= speed;
            yield return new WaitForSeconds(0.1f);
        }
    }*/

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") == true)
        {
            //StartCoroutine(FadeIn());
            audioSrc.Play();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //StartCoroutine(FadeOut());
        audioSrc.Stop();
    }
}
